using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public Vector2 wall_dir = new Vector2(0,0);
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void Move()
    {
        transform.Translate(wall_dir);
    }
}
