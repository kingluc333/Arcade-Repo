using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
public class Snake : MonoBehaviour
{
    // List of declared variables
    bool end = false;
    bool ate = false;
    Vector2 snake_dir = new Vector2(-0.5f, 0);
    public Start_Spawnfood _Start_Spawnfood;
    public List<Transform> tail = new List<Transform>();
    public GameObject tailPrefab;
    public Text_Script middle_text;
    public Transform wallT;
    public Transform wallB;
    public Transform wallR;
    public Transform wallL;
    bool move = false;
    void Start()
    {
        // after 1 second, Repeats the "Move" function every .11 seconds
        InvokeRepeating("Move", 1, 0.11f);
    }
    void Update()
    {   
        // Checks to see if Gameover has triggered "end" boolian to be true, if not then controls work
        if (!end)
        {
            if(Input.GetKey(KeyCode.RightArrow) && (snake_dir != new Vector2(-0.5f, 0)))
                {
                    snake_dir = new Vector2(0.5f, 0);
                }
            if (Input.GetKey(KeyCode.LeftArrow) && (snake_dir != new Vector2(0.5f, 0)))
                {
                    snake_dir = new Vector2(-0.5f, 0);
                }
            if (Input.GetKey(KeyCode.DownArrow) && (snake_dir != new Vector2(0, 0.5f)))
                {
                    snake_dir = new Vector2(0, -0.5f);
                }
            if (Input.GetKey(KeyCode.UpArrow) && (snake_dir != new Vector2(0, -0.5f)))
                {
                snake_dir = new Vector2(0, 0.5f);
                }
        }
        else
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
    //Function called when there is a trigger on any 2D collider with snake collider
    void OnTriggerEnter2D(Collider2D coll)
    {
        // Checks to see if other collider is the food prefab
        if (coll.name.StartsWith("Food"))
        {
            // If so, ate becomes true and triggers the if statement in the move function,
            // destroys the food, and then spawns a new food
            ate = true;
            Destroy(coll.gameObject);
            _Start_Spawnfood.Spawn();
        }
        // Checks to see if other collider is the Tail prefab or any wall
        if (coll.name.StartsWith("Tail") || coll.name.StartsWith("Wall"))
        {
            // if so, Gameover function is triggered
            Gameover();
        }
    }
    void Move()
    {
        move = true;
        // 'v' is equal to the position of the snake head
        Vector2 v = transform.position;
        // Tests whether or not the snake is about to hit the wall
        if((move) && (snake_dir == new Vector2(.5f,0)) && ((wallR.position.x - transform.position.x) < .5f))
            {
                Gameover();
            }
        if((move) && (snake_dir == new Vector2(-.5f,0)) && ((transform.position.x - wallL.position.x) < .5f))
            {
                Gameover();
            }
        if((move) && (snake_dir == new Vector2(0, .5f)) && ((wallT.position.y - transform.position.y) < .5f))
            {
                Gameover();
            }
        if((move) && (snake_dir == new Vector2(0, -.5f)) && ((transform.position.y - wallB.position.y) < .5f))
            {
                Gameover();
            }
        // then, the snake head is tranformed along a vector
        transform.Translate(snake_dir);
        if(!end)
        {
            // If statement checks if "ate" has been triggered by the collider
            if (ate)
            {   
                // Gameobject g is the cloned tailPrefab at 'v'(snakehead position) with no rotation
                GameObject g = Instantiate(tailPrefab, v, Quaternion.identity);

                // Inserts into the list "tail" the object "g" at position "0"
                tail.Insert(0, g.transform);
                ate = false;
            }
            // Checks whether or not there is more than 1 tail in the list and moves around the tails based on this
            else if (tail.Count > 0)
            {  
                //This whole function just makes sure that each of the tails are added to the list to get the vector,
                // and then removed from the list
                // Sets the position tail in the last position of the list to vector "v" (the snakehead vector)
                tail.Last().position = v;
                // The last tail in the list is added to position 1
                tail.Insert(0, tail.Last());
                // Removes an object from the list at the second to last position
                tail.RemoveAt(tail.Count - 1);
            } 
        }
        else
        {
            // If the end function is called, then all tail elements are transformed along the exact same vector as the head
            foreach(Transform t in tail)
            {
                t.transform.Translate(snake_dir);
            }
        }
    }
    // Game over function sets boolian "end" to true and causes "snake pause" function
    void Gameover()
    {
        end = true;
        // Snake Pause causes the snake to pause, blink a few colors, and then drop off the screen
        StartCoroutine(snake_pause());
        IEnumerator snake_pause()
        {
            snake_dir = new Vector2(0, 0);
            middle_text.middle_text.text = ("GAME OVER");
            yield return new WaitForSeconds(.4f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            foreach(Transform t in tail)
            {
                t.GetComponent<Renderer>().material.color = new Color(255,0,0);
            }
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            foreach(Transform t in tail)
            {
                t.GetComponent<Renderer>().material.color = new Color(255,255,255);
            }
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            foreach(Transform t in tail)
            {
                t.GetComponent<Renderer>().material.color = new Color(255,0,0);
            }
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            foreach(Transform t in tail)
            {
                t.GetComponent<Renderer>().material.color = new Color(255,255,255);
            }
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            foreach(Transform t in tail)
            {
                t.GetComponent<Renderer>().material.color = new Color(255,0,0);
            }
            yield return new WaitForSeconds(1);
            snake_dir = new Vector2(0, -2);

        }
    }
}
