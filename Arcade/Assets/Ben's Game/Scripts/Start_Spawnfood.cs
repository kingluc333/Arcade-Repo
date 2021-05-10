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
    public Snake snake;
    bool food_Hits_Tail = false;

    public void Spawn()
    {
        float x = 0;
        float y = 0;
        int randx = Random.Range(0,2);
            do
            {
                if (randx == 0)
                {
                    x = (int)Random.Range(borderLeft.position.x,
                                            borderRight.position.x);
                }
                else
                {
                    x = ((int)Random.Range((borderLeft.position.x -.5f),
                                            borderRight.position.x) + .5f);
                }
                int randy = Random.Range(0,2);
                if (randy == 0)
                {
                    y = (int)Random.Range(borderBottom.position.y,
                                            borderTop.position.y);
                }
                else
                {
                    y = ((int)Random.Range((borderBottom.position.y - .5f),
                                            borderTop.position.y) +.5f);
                }
                food_Hits_Tail = false;
                foreach (Transform t in snake.tail)
                {
                    if(t.transform.position == new Vector3(x,y,0))
                    {
                        food_Hits_Tail = true;
                    }
                }
            }
            while(food_Hits_Tail);
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
