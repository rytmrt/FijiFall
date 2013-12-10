using System;
using UnityEngine;

public class Utility
{
	private System.Random rand = new System.Random();
	static Utility instance;

	private Utility ()
	{
	}

	public static Utility GetInstance()
	{
		if (instance == null) instance = new Utility();
		return instance;
	}

	public void Reset (GameObject obj)
	{
		obj.transform.localPosition = Vector3.zero;
		obj.rigidbody.velocity = Vector3.zero;
		obj.rigidbody.angularVelocity = Vector3.zero;

		obj.renderer.enabled = true;

		Vector3 npos = new Vector3(0,0,0);
		int angle_deg = rand.Next(180) + 180;
		float angle = angle_deg * Mathf.Deg2Rad;

		npos.x = (Mathf.Cos (angle) * 100);
		npos.y = (Mathf.Sin (angle) * 100);

		Debug.Log(npos);

		obj.transform.rigidbody.AddForce(npos);
	}
}
