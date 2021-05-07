using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    // Current Movement Direction
    // (by default it moves to the right)
    Vector2 dir = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        // Move the snake every 300ms
        InvokeRepeating("Move", 0.4f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Move()
    {
        // Do Movement Stuff...
        transform.Translate(dir);
    }
}
