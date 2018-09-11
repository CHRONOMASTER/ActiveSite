using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAttach : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision collision)
	{
		foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
	}

	// Update is called once per frame
	void Update () {
		
	}
}
