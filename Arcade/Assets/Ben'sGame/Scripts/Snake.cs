using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Snake : MonoBehaviour
{
    bool end = false;
    Vector2 snake_dir = new Vector2(-0.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        // Move the snake every 300ms
        InvokeRepeating("Move", 0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {   
        if (!end)
        {
            if(Input.GetKey(KeyCode.RightArrow) && (snake_dir != new Vector2(-0.5f, 0)))
                snake_dir = new Vector2(0.5f, 0);
            else if (Input.GetKey(KeyCode.LeftArrow) && snake_dir != new Vector2(0.5f, 0))
                snake_dir = new Vector2(-0.5f, 0);
            else if (Input.GetKey(KeyCode.DownArrow) && snake_dir != new Vector2(0, -0.5f))
                snake_dir = new Vector2(0, -0.5f);
            else if (Input.GetKey(KeyCode.UpArrow) && snake_dir != new Vector2(0, 0.5f))
                snake_dir = new Vector2(0, 0.5f);
        }
    }
    
    List<Transform> tail = new List<Transform>();

    // Snake tail prefab
    public GameObject tailPrefab;
    bool ate = false;
    void Gameover()
            {
                (end) = true;
                Debug.Log("Game Over");
                snake_dir = new Vector2(0, -1);
            }
    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.name.StartsWith("Food"))
        {
            ate = true;
            Destroy(coll.gameObject);
        }
        if (coll.name.StartsWith("Tail"))
        {
            Debug.Log("Mistakes were made");
            Gameover();
        }
    }
    void Move()
    {
        Vector2 v = transform.position;

        // Move head into new direction (now there is a gap)
        // Do Movement Stuff...
        transform.Translate(snake_dir);

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
}
