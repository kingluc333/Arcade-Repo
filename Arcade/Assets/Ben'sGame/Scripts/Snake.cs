using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Snake : MonoBehaviour
{
    bool end = false;
    Vector2 snake_dir = new Vector2(-0.5f, 0);
    public Start_Spawnfood _Start_Spawnfood;   
    void Start()
    {
        InvokeRepeating("Move", 1, 0.11f);
    }
    void Update()
    {   
        
        if (!end)
        {
            if(Input.GetKey(KeyCode.RightArrow) & (snake_dir != new Vector2(-0.5f, 0)))
                snake_dir = new Vector2(0.5f, 0);
            if (Input.GetKey(KeyCode.LeftArrow) & snake_dir != new Vector2(0.5f, 0))
                snake_dir = new Vector2(-0.5f, 0);
            if (Input.GetKey(KeyCode.DownArrow) & snake_dir != new Vector2(0, 0.5f))
                snake_dir = new Vector2(0, -0.5f);
            if (Input.GetKey(KeyCode.UpArrow) & snake_dir != new Vector2(0, -0.5f))
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
            Debug.Log("Hit food");
            ate = true;
            Destroy(coll.gameObject);
            _Start_Spawnfood.Spawn();
        }
        if (coll.name.StartsWith("Tail") || coll.name.StartsWith("Wall"))
        {
            Debug.Log("Hit tail or wall");
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
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,255,255);
            yield return new WaitForSeconds(.1f);
            gameObject.GetComponent<Renderer>().material.color = new Color(255,0,0);
            yield return new WaitForSeconds(3);
            snake_dir = new Vector2(0, -2);
        }
        Debug.Log("game over");
        (end) = true;
        StartCoroutine(snake_pause());
    }
    void Move()
    {
        // Move head into new direction (now there is a gap)
        // Do Movement Stuff...
        Vector2 v = transform.position;
        transform.Translate(snake_dir);
        if (ate)
        {
            Debug.Log("Food ate");
            GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);

            tail.Insert(0, g.transform);

            ate = false;
        }
        // Does tail exist?
        else if (tail.Count > 0)
        {
            tail.Last().position = v;
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }    
    }
}
