using UnityEngine;
using PathCreation;
using System.Collections;

public class follow : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    public float speed;
    float dstTravelled;
    public Animator anim;
    private bool running = true;
    float timer;
    private void Start()
    {
        anim = this.GetComponent<Animator>();
        

    }
    void Update()
    {
        if (running)
        {
            speed = 20.0f;
            anim.SetInteger("state", 1);
            speed = 20.0f;
        }
        else
        {
            speed = 0.0f;
            anim.SetInteger("state", 0);
            StartCoroutine(timew());
         
        }
        
        dstTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end)+ new Vector3(0,60,0);
      
        Quaternion rotate = pathCreator.path.GetRotationAtDistance(dstTravelled, end);
        Quaternion fix = Quaternion.Euler(0, 0, 90);
        transform.rotation = rotate*fix;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "chkpnt1")
        {
            running = false;
            
        }
    }
    IEnumerator timew()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        running = true;
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}