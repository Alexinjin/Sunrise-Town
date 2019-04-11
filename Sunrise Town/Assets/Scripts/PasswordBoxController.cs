using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordBoxController : MonoBehaviour
{
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite zero;
    public GameObject digit1;
    private List<Sprite> inputDigit = new List<Sprite>();
    private int password = 960718;
    private bool found = false;
    public int count = 9;
    public int digit;
    // Start is called before the first frame update
    void Start()
    {
        inputDigit.Add(one);
        inputDigit.Add(two);
        inputDigit.Add(three);
        inputDigit.Add(four);
        inputDigit.Add(five);
        inputDigit.Add(six);
        inputDigit.Add(seven);
        inputDigit.Add(eight);
        inputDigit.Add(nine);
        inputDigit.Add(zero);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 9)
        {
            digit = 0;
        }
        else
        {
            digit = count + 1;
        }

    }


    void OnMouseDown()
    {
        if (this.CompareTag("Digit1"))
        {
            count++;
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-3.36f, -4.16f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-3.86f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-3.25f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-3.23f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-3.7f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(-3.47f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(-3.66f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-3.5f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(-3.6f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-3.3f, -3.7f, 1f);
            }
        }
        else if (this.CompareTag("Digit2"))
        {
            count++;
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-1.86f, -3.97f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-2.3f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-1.7f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-1.7f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-2.1f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(-1.95f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(-2.2f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-2f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(-2f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-1.7f, -3.7f, 1f);
            }
        }
        else if (this.CompareTag("Digit3"))
        {
            count++;
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-0.3f, -3.97f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-0.8f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-0.22f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-0.1f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-0.55f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(-0.47f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(-0.7f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(-0.5f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(-0.5f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(-0.17f, -3.7f, 1f);
            }
        }
        else if (this.CompareTag("Digit4"))
        {
            count++;
            Debug.Log('s');
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(1.26f, -3.97f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(0.7f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(1.26f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(1.5f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(1f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(1.01f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(0.8f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(1f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(1f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(1.35f, -3.7f, 1f);
            }
        }
        else if (this.CompareTag("Digit5"))
        {
            count++;
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(2.82f, -3.97f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(2.2f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(2.74f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(3f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(2.55f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(2.49f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(2.3f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(2.5f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(2.5f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(2.87f, -3.7f, 1f);
            }
        }
        else if (this.CompareTag("Digit6"))
        {
            count++;
            if (count > 9)
            {
                count = 0;
            }
            digit1.GetComponent<SpriteRenderer>().sprite = inputDigit[count];
            if (count == 0)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(4.38f, -3.97f, 1f);
            }
            else if (count == 1)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(3.7f, -2.53f, 1f);
            }
            else if (count == 2)
            {
                digit1.transform.localScale = new Vector3(0.8f, 0.7f, 1f);
                digit1.transform.position = new Vector3(4.22f, -3.93f, 1f);
            }
            else if (count == 3)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(4.4f, -2.73f, 1f);
            }
            else if (count == 4)
            {
                digit1.transform.localScale = new Vector3(0.6f, 0.6f, 1f);
                digit1.transform.position = new Vector3(4.1f, -3f, 1f);
            }
            else if (count == 5)
            {
                digit1.transform.localScale = new Vector3(0.45f, 0.4f, 1f);
                digit1.transform.position = new Vector3(4f, -3.38f, 1f);
            }
            else if (count == 6)
            {
                digit1.transform.localScale = new Vector3(0.5f, 0.45f, 1f);
                digit1.transform.position = new Vector3(3.8f, -3.1f, 1f);
            }
            else if (count == 7)
            {
                digit1.transform.localScale = new Vector3(0.55f, 0.6f, 1f);
                digit1.transform.position = new Vector3(4f, -3f, 1f);
            }
            else if (count == 8)
            {
                digit1.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                digit1.transform.position = new Vector3(4f, -2.65f, 1f);
            }
            else if (count == 9)
            {
                digit1.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
                digit1.transform.position = new Vector3(4.39f, -3.7f, 1f);
            }
        }

    }

}
