using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dough_anim : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animeComp;
    void Start()
    {
        animeComp = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animeComp.SetInteger("state", 1);
        }




        if (Input.GetKeyUp(KeyCode.W))
        {
            animeComp.SetInteger("state", 0);
        }

          if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animeComp.SetInteger("state", 2);
        }




        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animeComp.SetInteger("state", 1);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animeComp.SetInteger("state", 3);
        }




        if (Input.GetKeyUp(KeyCode.F))
        {
            animeComp.SetInteger("state", 0);
        }
    }
}
