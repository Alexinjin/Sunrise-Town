using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordBoxController : MonoBehaviour
{
    public Text digit1;
    public Text digit2;
    public Text digit3;
    public Text digit4;
    public Text digit5;
    public Text digit6;
    private List<Text> inputDigit = new List<Text>();// { digit1, digit2, digit3, digit4, digit5, digit6 };
    public GameObject digit;
    private int password = 960718;
    // Start is called before the first frame update
    void Start()
    {
        inputDigit.Add(digit1);
        inputDigit.Add(digit2);
        inputDigit.Add(digit3);
        inputDigit.Add(digit4);
        inputDigit.Add(digit5);
        inputDigit.Add(digit6);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 digitPos = Camera.main.WorldToScreenPoint(this.transform.position);
        digit.transform.position = digitPos;
        
    }

    void OnMouseDown()
    {
        //if (checkPasswordCorrectness(inputDigit))
        //{
        //    Debug.Log("Locked Successuflly you bitch");
        //    return;
        //}
        for (int i = 0; i < 6; ++i)
        {
            int x = int.Parse(inputDigit[i].text)+1;
            if (x > 9)
            {
                x = 0;
            }
            inputDigit[i].text = x.ToString();
            Debug.Log(inputDigit[i].text);
        }

        
    }

    bool checkPasswordCorrectness(List<Text> inputDigit) {
        return true;
    }
}
