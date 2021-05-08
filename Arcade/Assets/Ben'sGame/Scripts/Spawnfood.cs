using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnfood : MonoBehaviour
{
    // Food Prefab
    public GameObject foodPrefab;

    // Borders
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name.Equals("Snake Head"))
            {
                Debug.Log("You're supposed to spawn");
                Spawn();
            }
    }
    void Spawn()
    {

        float x = 0;
        float y = 0;
        int randx = Random.Range(0,2);
        Debug.Log("spawn started");
        if (randx == 0)
        {
            // x position between Left and right border
            x = (int)Random.Range(borderLeft.position.x,
                                    borderRight.position.x);
        }
        if (randx == 1)
        {
            // x position between Left and right border
            x = ((int)Random.Range((borderLeft.position.x -.5f) ,
                                    borderRight.position.x) + .5f);
        
        }
        int randy = Random.Range(0,2);
        if (randy == 0)
        {
            // x position between Left and right border
            y = (int)Random.Range(borderBottom.position.y,
                                    borderTop.position.y);
        }
        if (randy == 1)
        {
            // x position between Left and right border
            y = ((int)Random.Range((borderBottom.position.y - .5f),
                                    borderTop.position.y) +.5f);
        }
        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector2(x, y),
                    Quaternion.identity);
        Debug.Log("Food Spawned");                   
    }


    void Start()
    {
        Spawn();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
