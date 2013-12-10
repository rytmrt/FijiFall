using UnityEngine;
using System.Collections;

public class FallingObj: MonoBehaviour {

	private Utility util = Utility.GetInstance();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (this.gameObject.transform.position.y <= -8.5f)
		{
			util.Reset(this.gameObject);
		}
	}
}
