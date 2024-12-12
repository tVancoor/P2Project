using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class PlayerControler : MonoBehaviour
{
	public Camera cam;
	public NavMeshAgent agent;
	
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
    }
}
