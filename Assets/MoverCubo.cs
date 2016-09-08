using UnityEngine;

public class MoverCubo : MonoBehaviour {

	void Update ()
	{
		transform.Translate (1 * Time.deltaTime, 0, 0);
	}
}
