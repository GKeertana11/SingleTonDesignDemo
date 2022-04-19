using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class EthonController : MonoBehaviour
{
    public GameObject[] goalPoints;
    NavMeshAgent agent;
    Vector3 lastpoint;

    // Start is called before the first frame update
    
    void Start()
    {
        goalPoints = GameObject.FindGameObjectsWithTag("Goal");
        agent = GetComponent<NavMeshAgent>();
      
        GoToLocation();
    }

    public void GoToLocation()
    {
        lastpoint = agent.destination;//reached
        agent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       
       if(agent.remainingDistance<1.0f)
        {
            GoToLocation();
        }
    }
}
