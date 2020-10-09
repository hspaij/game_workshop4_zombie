using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
	public float pickupRadius = 2.0f;
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
			
			Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, pickupRadius);
			foreach (var hitCollider in hitColliders)
			{
				if(hitCollider.gameObject.tag == "key" || hitCollider.gameObject.tag == "controller") {
					print("Trying to pick up");
					print(hitCollider.gameObject.tag);
					hitCollider.gameObject.GetComponent<PickupObject>().pickedUp = true;
				} else if(hitCollider.gameObject.tag == "door") {
					print("Toggling door");
					hitCollider.gameObject.GetComponent<InteractDoor>().toggleDoor();
				}
			}
		}
    }
}
