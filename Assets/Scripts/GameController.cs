using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftButtom;
    public GameObject RightButtom;
    public GameObject MenuBar;
    public GameObject key;
    public GameObject foundKey;
    public GameObject passwordBox;
    public GameObject LargepasswordBox;
    private Vector3 mousePosition;
    private bool foundK = false;
    private bool keyAnimation = false;
    static float scaleSpeed = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        KeyController(mousePosition);
        PasswordBoxController(mousePosition);
    }
    // items  pick and menu bar control
    void OnMouseOver()
    {
        //Debug.Log(mousePosition.y);
        if (mousePosition.y < -4.5) {
            MenuBar.SetActive(true);
        }
        if (mousePosition.x < -5.5)
        {
            LeftButtom.SetActive(true);
        }
        if (mousePosition.x > 5.5)
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

    void KeyController( Vector2 mousePosition) {
        //Key item pick and animation coltroller
        if (Input.GetMouseButtonDown(0))
        {
            if (foundK == false)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag("Key"))
                {
                    foundKey.SetActive(true);
                    MenuBar.SetActive(true);
                    key.SetActive(false);
                    foundK = true;
                }
            }
            else
            {
                keyAnimation = true;
            }
        }
        else if (foundK && keyAnimation)
        {
            scaleSpeed += 2.5f * Time.deltaTime;
            float newScale = Mathf.Lerp(0.8f, 0f, scaleSpeed);
            foundKey.transform.localScale = new Vector3(newScale, newScale, newScale);
            foundKey.transform.position = new Vector3(foundKey.transform.position.x, foundKey.transform.position.y - 0.25f, foundKey.transform.position.z);
            if (newScale == 0f)
            {
                foundKey.SetActive(false);
                MenuBar.SetActive(false);
                scaleSpeed = 0.0f;
            }
        }

    }
    void PasswordBoxController(Vector2 mousePosition)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(new Vector2(mousePosition.x, mousePosition.y), Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("PasswordBox"))
            {
                LargepasswordBox.SetActive(true);
                passwordBox.SetActive(false);
            }

        }
    }
}
