using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class click : MonoBehaviour

{
    public GameObject text;
    private bool isClicked;
    void OnMouseDown()
    {
      
        UnityEngine.Debug.Log(name + " was clicked");
        isClicked = !isClicked;
        text.gameObject.SetActive(isClicked);
            

    }
}
