   using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class control2 : MonoBehaviour
{
    public float speed = 3.0F;
    public bool moveForward;
    private CharacterController controller;
    public Transform vrHead;

    //public GameObject door;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 jump_vector = Vector3.zero;


    private Vector3 last_pos;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
        vrHead = Camera.main.transform;
    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire2"))

        {


            moveForward = !moveForward;

        }



        if (moveForward)
        {
            Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }

        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            jump_vector.y = jumpSpeed;
        }
        jump_vector.y -= gravity * Time.deltaTime;
        controller.Move(jump_vector * Time.deltaTime);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "onepunchman")
        {
           //door.gameObject.SetAvtive(false);
            SceneManager.LoadScene("jordan");
        }
        
    }


}