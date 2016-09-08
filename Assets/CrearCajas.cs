using UnityEngine;

public class CrearCajas : MonoBehaviour {

	public GameObject prefabCaja;

	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate (prefabCaja,
						new Vector3 (Random.Range(-10,10),
									10,
									Random.Range(-10,10)),
						Quaternion.identity);
		}

	}
}
