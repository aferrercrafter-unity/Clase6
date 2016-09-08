using UnityEngine;

public class Cubo1 : MonoBehaviour {

	public float cantARotar;
	public float velocidad;

	private bool rotar = false;

	private float cantRotada = 0.0f;

	private float rotacionProxima = 0.0f;

	void Start () {
	
	}
	
	void Update () {
	
		if (rotar)
		{
			if (cantRotada < cantARotar) {
				transform.Rotate (Vector3.up * velocidad * Time.deltaTime);
				cantRotada += velocidad * Time.deltaTime;
			}
			else
			{
				cantRotada = 0f;

				transform.eulerAngles = new Vector3 (transform.eulerAngles.x,
													rotacionProxima,
													transform.eulerAngles.z);

				rotar = false;
			}
		}

	}

	void OnMouseDown () {

		rotar = true;

		rotacionProxima = transform.eulerAngles.y + cantARotar;

	}
	void OnMouseUp () {
	}
	void OnMouseUpAsButton () {
	}
	void OnMouseEnter () {
	}
	void OnMouseExit () {
	}
	void OnMouseOver () {
	}

}
