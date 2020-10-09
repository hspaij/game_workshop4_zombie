using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
	public float pickupRadius = 1.0f;
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
			
			Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, pickupRadius);
					GameObject player = GameObject.FindWithTag("Player");
			foreach (var hitCollider in hitColliders)
			{
				if(hitCollider.gameObject.tag == "key" && player.GetComponent<PlayerInventory>().hasKey == false) {
					player.GetComponent<PlayerInventory>().hasKey = true;
					player.GetComponent<PlayerInventory>().currKey = hitCollider.gameObject;
					
					print(hitCollider.gameObject.tag);
					hitCollider.gameObject.GetComponent<PickupObject>().pickedUp = true;
				} else if (hitCollider.gameObject.tag == "controller") {
					print(hitCollider.gameObject.tag);
					hitCollider.gameObject.GetComponent<PickupObject>().pickedUp = true;
				} else if(hitCollider.gameObject.tag == "door") {
					print("Toggling door");
					hitCollider.gameObject.GetComponent<InteractDoor>().toggleDoor();
				}	else if(hitCollider.gameObject.tag == "closeddoor") {
					print("Toggling locked door");
					hitCollider.gameObject.GetComponent<InteractClosedDoor>().toggleDoor();
				}
			}
		}
    }
}
