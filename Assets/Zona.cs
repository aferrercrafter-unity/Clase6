using UnityEngine;

public class Zona : MonoBehaviour {

	void OnTriggerStay(Collider col)
	{
		if (col.name == "Sphere") {

			Rigidbody rb = col.gameObject.GetComponent<Rigidbody> ();

			rb.AddForce (Vector3.up * 20);

		}
	}

}
