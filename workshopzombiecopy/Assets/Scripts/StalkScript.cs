using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkScript : MonoBehaviour
{
	public Transform Player;
	public double MoveSpeed = 0.5;
	public int MinDist = 5;
	 
	UnityEngine.AI.NavMeshAgent myNavMeshAgent;
  
	void Start () 
	{
		myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
 
	void Update () 
	{
		transform.LookAt(Player);
		
		if(Vector3.Distance(transform.position, Player.position) >= MinDist){
			myNavMeshAgent.destination = Player.position;
		}
	}
}
