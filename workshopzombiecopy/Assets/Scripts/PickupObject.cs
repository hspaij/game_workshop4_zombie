using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
	
    public bool pickedUp = false;
	

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
		if(this.pickedUp == true) {
			transform.position = new Vector3(
			player.transform.position.x+1, 
			player.transform.position.y,
			player.transform.position.z+1);
		}
    }
}
