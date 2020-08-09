using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class jordan : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject text;
    void Start() {
        text.gameObject.SetActive(false);


    }

    public void show()
    {
        text.gameObject.SetActive(true);
        SceneManager.LoadScene("jordan");
    }

    public void hide()
    {
        text.gameObject.SetActive(false);
    }


    public void reset_pos() 
    {
    
    }

}
