using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Snake : MonoBehaviour
{
    bool end = false;
    Vector2 snake_dir = new Vector2(-0.5f, 0);

    public Spawnfood spawn_food;

    // Start is called before the first frame update
    void Start()
    {
        // Move the snake every 300ms
        InvokeRepeating("Move", 0.13f, 0.13f);
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
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name.StartsWith("Food"))
        {
            ate = true;
            Destroy(coll.gameObject);
            spawn_food.Spawn();
        }
        if (coll.name.StartsWith("Tail") || coll.name.StartsWith("Wall"))
        {
            Gameover();
        }
    }
    void Gameover()
    {
        IEnumerator snake_pause()
        {
            snake_dir = new Vector2(0, 0);
            yield return new WaitForSeconds(.4f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            yield return new WaitForSeconds(.1f);
            Debug.Log("finished second wait");
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            yield return new WaitForSeconds(3);
            snake_dir = new Vector2(0, -1);
        }
        Debug.Log("game over");
        (end) = true;
        StartCoroutine(snake_pause());
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
