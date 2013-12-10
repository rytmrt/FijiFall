using UnityEngine;
using System.Collections;

public class Catch : MonoBehaviour {

	private int point = 0;
	private Utility util = Utility.GetInstance();

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

		util.Reset(obj);
	}

}
