using UnityEngine;
using System.Collections;
using System;

public class Spawn : MonoBehaviour {

	private Utility util = Utility.GetInstance();
	private System.Random rand = new System.Random();

	private int[] waves = {
		50,
		100,
		150,
	};

	public int SPAWN_MAX = 2;

	// Use this for initialization
	void Start () {
		SpawnObj(1);
	}
	
	// Update is called once per frame
	void Update () {
		if (util.numSpawnObj == 0)
		{
			SpawnObj(1);
		}
	}

	void SpawnObj(int num)
	{
		int spawn = rand.Next(num) + 1;

		for (int i = 0; i < spawn; ++i)
		{
			util.SpawnFallObj(this.transform);
		}
	}
}
