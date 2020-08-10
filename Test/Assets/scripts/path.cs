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
    

    // Update is called once per frame
    void Update()
    {
       dstTravelled += speed * Time.deltaTime; 
       transform.position = path_c.path.GetPointAtDistance(dstTravelled, end);
       Quaternion target = Quaternion.Euler(180,0,-90);
       Quaternion currentRotation= path_c.path.GetRotationAtDistance(dstTravelled, end);
       transform.rotation = currentRotation * target;
       Debug.Log(path_c.path.GetRotationAtDistance(dstTravelled, end).eulerAngles);
    }
}
