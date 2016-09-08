using UnityEngine;

public class Cubo : MonoBehaviour {

	void Update () {
		
		if (Input.anyKey) {
			transform.Translate (Vector3.right * 0.01f);
		}

	}

	void OnCollisionEnter (Collision col) {
		print ("Colision");
	}

	void OnTriggerEnter (Collider col)
	{
		print ("Trigger");
	}

}
