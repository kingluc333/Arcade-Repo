using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score_text;
    public Snake snake;
    void Start()
    {

        Debug.Log(snake.tail.Count);
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = ("Score: " + snake.tail.Count);
    }
}
