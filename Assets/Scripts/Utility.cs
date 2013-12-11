using System;
using UnityEngine;

public class Utility
{

	private static Utility instance;
	private System.Random rand = new System.Random();
	private string[] prefabPath = {
		"FallingSquirrel",
		"FallingDummy"
	};

	public int numSpawnObj = 0;
	public int playerScore = 0;

	private Utility ()
	{
	}

	public static Utility GetInstance()
	{
		if (instance == null) instance = new Utility();
		return instance;
	}

	public void DestroyFallObj (GameObject obj)
	{
		--numSpawnObj;
		UnityEngine.Object.Destroy(obj);
	}

	public void SpawnFallObj (Transform parent)
	{
		++numSpawnObj;

		int index = rand.Next(2);
		UnityEngine.Object obj = UnityEngine.Object.Instantiate(Resources.Load(prefabPath[index]));
		((GameObject)obj).transform.parent = parent;

		((GameObject)obj).transform.localPosition = Vector3.zero;

		Vector3 npos = new Vector3(0,0,0);
		int angle_deg = rand.Next(180) + 180;
		float angle = angle_deg * Mathf.Deg2Rad;

		npos.x = (Mathf.Cos (angle) * 100);
		npos.y = (Mathf.Sin (angle) * 100);

		((GameObject)obj).transform.rigidbody.AddForce(npos);
	}
}
