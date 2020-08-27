using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public GameObject[] destinations;
    public float RemainingDistanceError;
    public float WaitTimeAtDestination;
    private int index = 0;
    private float counter = 0;




    void Start()
    {
     
        agent.SetDestination(destinations[0].transform.position);
        StartCoroutine(StartPatrol());
    }
    IEnumerator StartPatrol()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            
            if (agent.remainingDistance <= RemainingDistanceError && agent.remainingDistance!=Mathf.Infinity)
            {
                counter = counter + 0.01f;
                if (counter <= WaitTimeAtDestination)
                {
                    agent.ResetPath();
                    

                }
                else
                {

                    ChangeNavMeshPath();
                    counter = 0;
                }

            }
   
        }

     }


    float GetVelocity()
    {
        return agent.speed;
    }
    float GetAngularVelocity()
    {
        return agent.angularSpeed;
    }
    void ChangeNavMeshPath()
    {

            incrementIndex();
            agent.SetDestination(destinations[index].transform.position);
  
        

    }

    void incrementIndex()
    {

        if (index == destinations.Length - 1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
    }
}




