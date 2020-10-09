using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalkScript : MonoBehaviour
{
	public Transform Player;
	public double MoveSpeed = 0.5;
	public int MinDist = 5;
	public bool collided = false;
	
	UnityEngine.AI.NavMeshAgent myNavMeshAgent;
  
	void Start () 
	{
		myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
 
	void Update () 
	{
		transform.LookAt(Player);
		
		
		Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 2.0f);
			foreach (var hitCollider in hitColliders)
			{
				if(hitCollider.gameObject.tag == "Player" && collided == false) {
					collided = true;
					GetComponent<AudioSource>().Play();
				} else {
					collided = false;
					if(Vector3.Distance(transform.position, Player.position) >= MinDist){
						myNavMeshAgent.destination = Player.position;
					}
				}
			}
	}
}
