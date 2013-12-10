using UnityEngine;
using System.Collections;

public class Catch : MonoBehaviour {

	private int point = 0;
	private System.Random rand = new System.Random();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision)
	{
		++ point;
		Debug.Log(""+point);

		GameObject obj = collision.gameObject;
		obj.renderer.enabled = false;

		Reset(obj);
	}

	private void Reset (GameObject obj)
	{
		Vector3 npos = new Vector3(0,0,0);
		npos.x = (rand.Next(240) - 140.0f) / 10.0f;

		obj.transform.localPosition = npos;
		obj.rigidbody.velocity = Vector3.zero;
		obj.rigidbody.angularVelocity = Vector3.zero;

		obj.renderer.enabled = true;
	}
}
