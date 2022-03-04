using UnityEngine;
using UnityEngine.AI;

public class COMPLETE_PlayerController : MonoBehaviour
{
    [SerializeField]private Camera cam;

    [SerializeField]private NavMeshAgent agent;

 
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

         if (agent.isOnOffMeshLink)
         {
           /*   agent.CompleteOffMeshLimit(transform.position.x, transform.position.y, 10f); 

            /* transform.position =  new Vector3(transform.position.x, transform.position.y, 10f);  */
 
        }  
       

    }
}