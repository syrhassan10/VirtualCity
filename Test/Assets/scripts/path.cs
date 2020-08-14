using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class path : MonoBehaviour
{
    // Start is called before the first frame update
    public PathCreator path_c;
    public EndOfPathInstruction end;
    public float speed;
    float dstTravelled;
    private Vector3 fix = new Vector3(0,10,0);
    

    // Update is called once per frame
    void Update()
    {
       dstTravelled += speed * Time.deltaTime; 
       transform.position = path_c.path.GetPointAtDistance(dstTravelled, end)+fix;
       Quaternion target = Quaternion.Euler(0,90,-90);
       Quaternion currentRotation= path_c.path.GetRotationAtDistance(dstTravelled, end);
       //transform.rotation = path_c.path.GetRotationAtDistance(dstTravelled, end);

       transform.rotation = currentRotation * target;
       Debug.Log(path_c.path.GetRotationAtDistance(dstTravelled, end).eulerAngles);
    }
}
