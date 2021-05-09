using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_food : MonoBehaviour
{
    public GameObject foodPrefab;
    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;




    // Start is called before the first frame update
    void Start()
    {

        
    }
    public void Spawn()
    {
        float x = 0;
        float y = 0;
        int randx = Random.Range(0,2);
        Debug.Log("spawn initiated");
        if (randx == 0)
        {
            x = (int)Random.Range(borderLeft.position.x,
                                    borderRight.position.x);
            Debug.Log(x);
        }
        else
        {
            x = ((int)Random.Range((borderLeft.position.x -.5f),
                                    borderRight.position.x) + .5f);
            Debug.Log(x);
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
        Instantiate(foodPrefab,
                    new Vector2(x, y),
                    Quaternion.identity);
        Debug.Log("Food Spawned");
                           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
