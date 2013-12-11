using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 6.0F;
	public float minX = -11.1F;
	public float maxX = 11.1F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;

		if (currentPosition.x < minX){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		if (currentPosition.x > maxX) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
				}

		if(Input.GetKey(KeyCode.A)){
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}


	}
}
