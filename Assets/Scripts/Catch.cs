using UnityEngine;
using System.Collections;

public class Catch : MonoBehaviour {

	private Utility util = Utility.GetInstance();

	public MonoBehaviour spawnzero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision)
	{
		++ util.playerScore;
		Debug.Log(util.playerScore);

		GameObject obj = collision.gameObject;
		util.DestroyFallObj(obj);
	}

}
