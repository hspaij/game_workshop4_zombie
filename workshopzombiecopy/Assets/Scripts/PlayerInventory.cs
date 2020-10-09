using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public bool hasKey = false;
	public GameObject currKey;
	
    // Update is called once per frame
    public void removeKey()
    {
        this.hasKey = false;
		currKey.SetActive(false);
    }
}
