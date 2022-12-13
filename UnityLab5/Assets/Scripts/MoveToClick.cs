using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
     private NavMeshAgent agent;

     void Awake()
     {
          agent = GetComponent<NavMeshAgent>();
     }

     // Update is called once per frame
     void Update()
    {
          if (Input.GetMouseButtonDown(0))
          {
               Camera cameraComponent = GameObject.Find("Main Camera").GetComponent<Camera>();
               Ray ray = cameraComponent.ScreenPointToRay(Input.mousePosition);
               RaycastHit hit;
               if (Physics.Raycast(ray, out hit, 100))
               {
                    agent.SetDestination(hit.point);
               }
          }
    }
}
