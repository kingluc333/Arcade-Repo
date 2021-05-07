using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Vector3 roundedMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            transform.Translate(0f, 0.4f, 0f);
            RoundMovement();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Translate(0.4f, 0f, 0f);
            RoundMovement();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            transform.Translate(0f, -0.4f, 0f);
            RoundMovement();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Translate(-0.4f, 0f, 0f);
            RoundMovement();
        }
    }

    void RoundMovement ()
    {
        roundedMovement.x = Mathf.Round(transform.position.x * 1000);
        roundedMovement.y = Mathf.Round(transform.position.y * 1000);
        roundedMovement.x /= 1000;
        roundedMovement.y /= 1000;

        transform.position = roundedMovement;
    }
}
