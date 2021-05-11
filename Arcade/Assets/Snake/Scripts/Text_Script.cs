using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    public TextMeshProUGUI middle_text;
    public Snake snake;
    void Start()
    {
        StartCoroutine(Ready_Go());
        IEnumerator Ready_Go()
        {
            middle_text.text = ("READY");
            yield return new WaitForSeconds(.5f);
            middle_text.text = ("GO!");
            yield return new WaitForSeconds(.5f);
            middle_text.text = ("");
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ("Score: " + snake.tail.Count);
    }
}
