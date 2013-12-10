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
		Vector3 npos = new Vector3(0,0,0);
		npos.x = (rand.Next(240) - 140.0f) / 10.0f;

		obj.transform.localPosition = npos;
		obj.rigidbody.velocity = Vector3.zero;
		obj.rigidbody.angularVelocity = Vector3.zero;

		obj.renderer.enabled = true;
	}
}
