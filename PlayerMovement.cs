using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float speed = 6.0F;
	private Vector3 moveDirection = Vector3.zero;
	private float minX = -11.0F;
	private float maxX = 11.0F;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < minX)
		{
			transform.position = new Vector3(-11, -8, 0);
		}
		if (transform.position.x > maxX)
		{
			transform.position = new Vector3(11, -8, 0);
		}

		if(Input.GetKey(KeyCode.A)){
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}

		//System.Diagnostics.Debug.WriteLine ("POSITION X:" + positon.x);
	
		Debug.Log("POSITION X:" + Screen.width);
	}
}
