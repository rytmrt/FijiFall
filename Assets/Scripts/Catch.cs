using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class Catch : MonoBehaviour {

	private Utility util = Utility.GetInstance();
	private Regex regex = new Regex ("FallingDummy*");

	public MonoBehaviour spawnzero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject obj = collision.gameObject;

		if (regex.IsMatch(obj.name))
		{
			-- util.playerScore;
		}
		else 
		{
			++ util.playerScore;
		}

		Debug.Log(util.playerScore);

		util.DestroyFallObj(obj);
	}

}
