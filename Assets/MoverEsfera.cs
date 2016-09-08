using UnityEngine;
using System.Collections;

public class MoverEsfera : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.anyKey) {

			rb.AddForce (Vector3.forward * 10);

		}

	}
	/*
	void OnCollisionEnter(Collision colData)
	{
		print ("COLISIONO");
	}

	void OnTriggerEnter(Collider col)
	{
		print ("ENTRO EN TRIGGER " + col.gameObject.name);
	}

	void OnTriggerStay(Collider col)
	{
		print ("STAY EN TRIGGER");
	}

	void OnTriggerExit(Collider col)
	{
		print ("SALIO DEL TRIGGER");
	}*/
}
