using UnityEngine;
using System.Collections;
using System;

public class Spawn : MonoBehaviour {

	private Utility util = Utility.GetInstance();
	private System.Random rand = new System.Random();

	private int[] bounas = new int[] {
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
		1, 1, 1, 2, 2, 2, 3, 10, 10, 10,
	};

	private float starttime = 0;


	public int secondwave = 45;

	// Use this for initialization
	void Start () {
		starttime = Time.time;

		StartCoroutine(SpawnObj(1));
	}
	
	// Update is called once per frame
	void Update () {

		if (util.numSpawnObj == 0)
		{
			int spnum = 0;

			int bnum = rand.Next(100);
			float t = Time.time - starttime;
			if (secondwave < t)
			{
				spnum = bounas[bnum] + 2;
			}
			else {
				spnum = bounas[bnum];
			}

			StartCoroutine(SpawnObj(spnum));
		}
	}

	IEnumerator SpawnObj(int num)
	{
		for (int i = 0; i < num; ++i)
		{
			util.SpawnFallObj(this.transform);

			for (int j = 0; j < 8; ++j) yield return 0;

		}
	}
}
