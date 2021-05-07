using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    // Current Movement Direction
    // (by default it moves to the right)
    Vector2 dir = new Vector2(-0.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        // Move the snake every 300ms
        InvokeRepeating("Move", 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
            dir = new Vector2(0.5f, 0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = new Vector2(-0.5f, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = new Vector2(0, -0.5f);
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = new Vector2(0, 0.5f);
    }
    void Move()
    {
        // Do Movement Stuff...
        transform.Translate(dir);
    }
}
