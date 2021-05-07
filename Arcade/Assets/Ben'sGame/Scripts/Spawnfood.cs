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

    void Spawn()
    {
        // x position between Left and right border
        int x = (int)Random.Range(borderLeft.position.x *2,
                                  borderRight.position.x * 2);

        // y position between top and bottom border
        int y = (int)Random.Range(borderBottom.position.y * 2,
                                  borderTop.position.y * 2);

        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector2(x / 2, y / 2),
                    Quaternion.identity);                          
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
