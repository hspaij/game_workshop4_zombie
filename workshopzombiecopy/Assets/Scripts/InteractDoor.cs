using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDoor : MonoBehaviour
{
	private bool open = false;
	private Vector3 position = new Vector3();
	private Quaternion rotation = new Quaternion();
	
	void Start() {
		position = gameObject.transform.position;
		rotation = gameObject.transform.rotation;
	}
	
    public void toggleDoor()
    {
		print(position);
		print(rotation);
        if(!open) {
			gameObject.transform.position = new Vector3(gameObject.transform.position.x + (gameObject.transform.localScale.z/2), gameObject.transform.position.y, gameObject.transform.position.z - (gameObject.transform.localScale.z/2));
			gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, gameObject.transform.rotation.y + 90, gameObject.transform.rotation.z, gameObject.transform.rotation.w);
			
			open = true;
		} else {
			gameObject.transform.position = position;
			gameObject.transform.rotation = rotation;
			open = false;
		}
    }
}
