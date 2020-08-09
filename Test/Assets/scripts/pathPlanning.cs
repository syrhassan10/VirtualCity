using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class pathPlanning : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame

    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    public float speed;
    float dstTravelled;
        
    void Update()
    {
        dstTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(dstTravelled, end);
        //transform.rotation = pathCreator.path.GetRotationAtDistance(dstTravelled, end);
    }

}
