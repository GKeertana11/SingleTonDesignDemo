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
      //  float value = Random.Range(0f, 100f);
       
       if(agent.remainingDistance<1.0f)
        {
            GoToLocation();
        }
        
        foreach (GameObject item in GameManager1.Instance.TrashCans)
        {
           float tempDistance= Vector3.Distance(this.transform.position, item.transform.position);
           // Debug.Log(tempDistance);
            if(tempDistance<5f&& Random.Range(0,50)<5)
            {
                agent.SetDestination(lastpoint);
               // Debug.Log("in if:" + tempDistance);
                Debug.Log("moving away");
            }
            else 
                if(tempDistance<1f)
                {
                GameManager1.Instance.RemoveTrashCan(item);
                }
            }
            
        }
    }

