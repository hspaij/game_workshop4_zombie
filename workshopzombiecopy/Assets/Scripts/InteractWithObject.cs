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
			print("Trying to pick up");
			
			Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, pickupRadius);
			foreach (var hitCollider in hitColliders)
			{
				if(hitCollider.gameObject.tag != "Player" && hitCollider.gameObject.tag != "Untagged") {
					print(hitCollider.gameObject.tag);
				}
			}
		}
    }
}
