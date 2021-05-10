using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject clone;

    Vector3 roundedMovement;
    Vector2[] rot_data;

    //1 - Red, 2 - Green, 3 - Blue, 4 - Orange, 5 - Purple, 6 - Yellow, 7 - Cyan
    int block_id;
    //1 - 4
    int rotation;

    void Start ()
    {
        //Non-mono, so no start function; have to initialize here
        Rotation_Data.PopulateDictionary();

        SetBlockID();

        rotation = 1;
    }

    void Update ()
    {
        GetInput(); //Listens for user input
        //Fall(); //Initiates checks for falling down
    }

    //Assigns block ID in "Start" based on name
    void SetBlockID ()
    {
        string name = gameObject.name;

        switch (name)
        {
            case "Red": block_id = 1; break;
            case "Green": block_id = 2; break;
            case "Blue": block_id = 3; break;
            case "Orange": block_id = 4; break;
            case "Purple": block_id = 5; break;
            case "Yellow": block_id = 6; break;
            case "Cyan": block_id = 7; break;
        }
    }

    void GetInput ()
    {
        //Rotate
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Check if valid

            //Change rotation index
            if (rotation == 4) { rotation = 1; } else rotation++;

            //Actual rotation
            RotateBlock(gameObject);
        }
        //Move right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Check if valid
            if (CheckValidMovement(1, rotation)) { transform.Translate(Vector3.right); }
        }
        //Move left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Check if valid
            transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Jump to bottom
        }

        //Ability to store pieces as well
    }

    void RotateBlock (GameObject g)
    {
        //Give Rotation_Data the rotation and block_id, get a vector array in return
        rot_data = Rotation_Data.GiveRotationData(block_id, rotation);
            
        //Rotate the block
        for (int i = 0; i < 4; i++) 
        {
            g.transform.GetChild(i).transform.localPosition = rot_data[i];
        }
    }

    bool CheckValidMovement (int move_type, int rotation)
    {
        //Move right
        if (move_type == 1)
        {
            Vector3 v = new Vector3 (transform.position.x + 1, transform.position.y, 0);
            GameObject c =  Instantiate(clone, v, Quaternion.identity);

            RotateBlock(c);

            bool canMove = false;

            canMove = DoesCloneCollide(c);

            Destroy(c);
            return !canMove;
        }
        //Move left
        else if (move_type == 2)
        {

        }
        //Move down
        else if (move_type == 3)
        {

        }
        //Rotate
        else if (move_type == 4)
        {

        }

        return false;
    }

    bool DoesCloneCollide (GameObject c)
    {
        bool b = false;
        foreach(Transform child in c.transform)
        {
            if (child.transform.position.x > 10.5) { b = true; }
        }
        return b;
    }

    // void RoundMovement ()
    // {
    //     roundedMovement.x = Mathf.Round(transform.position.x * 1000);
    //     roundedMovement.y = Mathf.Round(transform.position.y * 1000);
    //     roundedMovement.x /= 1000;
    //     roundedMovement.y /= 1000;

    //     transform.position = roundedMovement;
    // }
}
