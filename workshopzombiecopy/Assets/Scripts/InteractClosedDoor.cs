using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractClosedDoor : MonoBehaviour
{
	private bool open = false;
	private Vector3 position = new Vector3();
	private Quaternion rotation = new Quaternion();
	private bool locked = true;
	
	void Start() {
		position = gameObject.transform.position;
		rotation = gameObject.transform.rotation;
	}
	
    public void toggleDoor()
    {
		print("attempted toggle");
		unlockDoor();
		if(!locked) {
			if(!open) {
				gameObject.transform.position = new Vector3(gameObject.transform.position.x + (gameObject.transform.localScale.z/2), gameObject.transform.position.y, gameObject.transform.position.z - (gameObject.transform.localScale.z/2));
				gameObject.transform.rotation = new Quaternion(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y + 90, gameObject.transform.localRotation.z, gameObject.transform.localRotation.w);
				
				open = true;
			} else {
				gameObject.transform.position = position;
				gameObject.transform.rotation = rotation;
				open = false;
			}
		} else {
			//Play sound or something;
		}
    }
	
	public void unlockDoor() {
        GameObject player = GameObject.FindWithTag("Player");
		
		if(player.GetComponent<PlayerInventory>().hasKey) {
			player.GetComponent<PlayerInventory>().removeKey();
			this.locked = false;
		} else {
			//play sound or something
		}
	}
}
