using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject clone;

    public bool is_falling = true;

    public float fall_interval = 1;

    //1 - Red, 2 - Green, 3 - Blue, 4 - Orange, 5 - Purple, 6 - Yellow, 7 - Cyan
    public int block_id;

    Vector3 clone_kick_position;
    Vector2[] rot_data;
    GameObject fallen_blocks_parent;
    
    float previous_time;

    //1 - 4
    int rotation;

    void Start ()
    {
        //Non-mono, so no start function; have to initialize here
        Rotation_Data.PopulateDictionary();

        rotation = 1;
        previous_time = Time.time;
        fallen_blocks_parent = GameObject.Find("Fallen Blocks");
    }

    void Update ()
    {
        //Listens for user input
        GetInput();

        //Handles falling process
        if (is_falling) { Fall(); }
    }

    void GetInput ()
    {
        //Rotate
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Check if valid
            if (CanRotate(rotation))
            {
                //Change rotation index
                if (rotation == 4) { rotation = 1; } else rotation++;

                //Actual rotation
                RotateBlock(gameObject, rotation);
            }
            else if (CanKick(rotation))
            {
                //Move to kick location
                transform.position = clone_kick_position;

                //Change rotation index
                if (rotation == 4) { rotation = 1; } else rotation++;

                //Actual rotation
                RotateBlock(gameObject, rotation);
            }
        }
        //Move right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CanMove(1, rotation)) { transform.Translate(Vector3.right); }
        }
        //Move left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CanMove(2, rotation)) { transform.Translate(Vector3.left); }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Jump to bottom
        }

        //Ability to store pieces as well
    }

    //Handles the block falling mechanic
    void Fall ()
    {
        if (Time.time > previous_time + fall_interval)
        {
            if (CanMove(3, rotation))
            {
                transform.Translate(Vector3.down);
                previous_time = Time.time;
            }
        }
    }

    //Checking for L-R or D movement
    bool CanMove (int move_type, int rot)
    {
        //Determining where to spawn clone
        Vector3 v = new Vector3(0f, 0f, 0f);
        switch(move_type)
        {
            case 1: v = new Vector3 (transform.position.x + 1, transform.position.y, 0); break;
            case 2: v = new Vector3 (transform.position.x - 1, transform.position.y, 0); break;
            case 3: v = new Vector3 (transform.position.x, transform.position.y - 1, 0); break;
        }

        //Spawning clone and match rotation
        GameObject c =  Instantiate(clone, v, Quaternion.identity);
        RotateBlock(c, rot);

        //Checking for collision, deleting clone, returning yay or nay on move
        bool canMove = !DoesCloneCollideOnMove(c);
        Destroy(c);
        return canMove;
    }

    //Checking for rotation
    bool CanRotate (int rot)
    {
        //Incrementing rotation for clone
        if (rotation == 4) { rot = 1; }
        else { rot = rotation + 1; }

        //Spawning clone with new rotation
        GameObject c =  Instantiate(clone, transform.position, Quaternion.identity);
        RotateBlock(c, rot);

        //Checking for collision on rotation
        bool can_rotate = !DoesCloneCollideOnMove(c);
        Destroy(c);
        return can_rotate;
    }

    //Checking for kicking
    bool CanKick (int rot)
    {
        //Incrementing rotation for clone
        if (rotation == 4) { rot = 1; }
        else { rot = rotation + 1; }

        //Spawning clone with new rotation
        GameObject c =  Instantiate(clone, transform.position, Quaternion.identity);
        RotateBlock(c, rot);

        //Checks right, left, up, down, in that order; if no hit, records the location,
        //deletes the clone and ends function; otherwise, moves on to the next one
        //Checking right
        c.transform.Translate(Vector3.right);
        if (!DoesCloneCollideOnMove(c)) 
        { clone_kick_position = c.transform.position; 
          Destroy(c); return true; }
        else { c.transform.Translate(new Vector3(-2, 0f, 0f)); }

        //Checking left
        if (!DoesCloneCollideOnMove(c)) 
        { clone_kick_position = c.transform.position; 
          Destroy(c); return true; }
        else { c.transform.Translate(new Vector3(1, 1, 0)); }

        //Checking up
        if (!DoesCloneCollideOnMove(c)) 
        { clone_kick_position = c.transform.position; 
          Destroy(c); return true; } 
        else { c.transform.Translate(new Vector3(0, -2, 0)); }

        //Checking down
        if (!DoesCloneCollideOnMove(c)) 
        { clone_kick_position = c.transform.position; 
          Destroy(c); return true; }

        //Else, say we can't kick
        Destroy(c);
        return false;
    }

    //Checking for all collisions a movement clone may encounter
    bool DoesCloneCollideOnMove (GameObject c)
    {
        bool b = false;

        //Checking for collision with walls and floor
        foreach(Transform child in c.transform)
        {
            if (child.transform.position.x > 10.5 || 
                child.transform.position.x < 1.5  ||
                child.transform.position.y < 1.5)
            { b = true; }
        }
        //Checking for collision with fallen blocks
        foreach(Transform child in c.transform)
        {
            foreach(Transform fallen_block in fallen_blocks_parent.transform)
            {
                if (child.transform.position == fallen_block.transform.position)
                { b = true; }
            }
        }

        return b;
    }

    //Actually rotates based off the rotation data
    void RotateBlock (GameObject g, int rot)
    {
        //Give Rotation_Data the rotation and block_id, get a vector array in return
        rot_data = Rotation_Data.GiveRotationData(block_id, rot);
            
        //Rotate the block
        for (int i = 0; i < 4; i++) 
        {
            g.transform.GetChild(i).transform.localPosition = rot_data[i];
        }
    }
}
