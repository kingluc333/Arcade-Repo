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

    bool end = false;

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

        if (end)
            Debug.Log("HI");
    }
    
    List<Transform> tail = new List<Transform>();

    // Snake tail prefab
    public GameObject tailPrefab;
    bool ate = false;

    void OnTriggerEnter2D(Collider2D coll)
        {
        if (coll.name.StartsWith("Food"))
        {
            ate = true;
            Destroy(coll.gameObject);
        }
        else if (coll.name.StartsWith("Wall"))
        {
            (end) = true;
        }
        else if (coll.name.StartsWith("Head"))
        {
            (end) = true;
        }
    }
    void Move()
    {
        Vector2 v = transform.position;

        // Move head into new direction (now there is a gap)
        // Do Movement Stuff...
        transform.Translate(dir);

        if (ate)
        {
            GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
            tail.Insert(0, g.transform);

            ate = false;
        }

        // Does tail exist?
        if (tail.Count> 0)
        {
            tail.Last().position = v;
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count-1);
        }
    }
        // Keep track of Trail

}
