using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class display : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject text;
    public GameObject player;
 
    public bool isClicked;
    public string objectName;


    void Start() {
        text.gameObject.SetActive(false);
        

    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider.gameObject.name == objectName)
                {
                    isClicked = !isClicked;

                    text.gameObject.SetActive(isClicked);
                }


            }

        }

    }

 

    


}
