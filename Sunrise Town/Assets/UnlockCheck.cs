using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCheck : MonoBehaviour
{
    public GameObject digit1;
    public GameObject digit2;
    public GameObject digit3;
    public GameObject digit4;
    public GameObject digit5;
    public GameObject digit6;
    private int d1;
    private int d2;
    private int d3;
    private int d4;
    private int d5;
    private int d6;
    private string Password = "030406";
    private bool unlock = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Locker") && unlock == false)
            {
                if (CheckPassword())
                {
                    gameObject.SetActive(false);
                }
            }

        }

    }
    bool CheckPassword()
    {
        List<int> digitList = new List<int>();
        digitList.Add(digit1.GetComponent<PasswordBoxController>().digit);
        digitList.Add(digit2.GetComponent<PasswordBoxController>().digit);
        digitList.Add(digit3.GetComponent<PasswordBoxController>().digit);
        digitList.Add(digit4.GetComponent<PasswordBoxController>().digit);
        digitList.Add(digit5.GetComponent<PasswordBoxController>().digit);
        digitList.Add(digit6.GetComponent<PasswordBoxController>().digit);
        for (int i = 0; i < 6; ++i)
        {
            if(digitList[i].ToString() != Password[i].ToString())
            {

                return false;
            }
        }
        Debug.Log('w');
        unlock = true;
        return true;
    }
}
