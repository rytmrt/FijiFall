using UnityEngine;
using System.Collections;

public class Tiemer : MonoBehaviour {

	public float endTime = 90.0f;

	public float startTime = 0.0f;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;

		if (t >= endTime)
		{
			Application.LoadLevel("Result");
		}
	}
}
