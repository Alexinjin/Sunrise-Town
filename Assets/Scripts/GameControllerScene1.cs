using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScene1 : MonoBehaviour
{
    public GameObject LeftButtom;
    public GameObject RightButtom;
    public GameObject MenuBar;
   
    Vector3 mousePosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    // items  pick and menu bar control
    void OnMouseOver()
    {
        //Debug.Log(mousePosition.y);
        if (mousePosition.y < -5)
        {
            MenuBar.SetActive(true);
        }
        if (mousePosition.x < -7)
        {
            LeftButtom.SetActive(true);
        }
        if (mousePosition.x > 7)
        {
            RightButtom.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        LeftButtom.SetActive(false);
        RightButtom.SetActive(false);
        MenuBar.SetActive(false);
    }
}
