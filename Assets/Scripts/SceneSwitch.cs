using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int sceneLevel;
    private Vector3 mousePosition;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ScenesSwitch(mousePosition);
    }

    void ScenesSwitch(Vector2 mousePosition)
    {
        if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("Arrow"))
        {
            
            if (sceneLevel == 0)
            {
                SceneManager.LoadScene(1);
            }
            else if (sceneLevel == 1)
            {
                SceneManager.LoadScene(0);
            }
        }
        
        
    }
}
