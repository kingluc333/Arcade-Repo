using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Spawnfood : MonoBehaviour
{
    public GameObject foodPrefab;
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;
    public GameObject tail_object;

    public void Spawn()
    {
        float x = 0;
        float y = 0;
        int randx = Random.Range(0,2);
        if (randx == 0)
        {
            do
            {
            x = (int)Random.Range(borderLeft.position.x,
                                    borderRight.position.x);
            }
            while(tail_object.transform.position.x == x);
        }
        else
        {
            do
            {
            x = ((int)Random.Range((borderLeft.position.x -.5f),
                                    borderRight.position.x) + .5f);
            }
            while(tail_object.transform.position.x == x);
        }
        int randy = Random.Range(0,2);
        if (randy == 0)
        {
            do
            {
            y = (int)Random.Range(borderBottom.position.y,
                                    borderTop.position.y);
            }
            while(tail_object.transform.position.y == y);
        }
        else
        {
            do
            {
            y = ((int)Random.Range((borderBottom.position.y - .5f),
                                    borderTop.position.y) +.5f);
            }
            while(tail_object.transform.position.y == y);
        }
        Instantiate(foodPrefab,
                    new Vector2(x, y),
                    Quaternion.identity);
        Debug.Log("food spawned");
                           
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
