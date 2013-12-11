using UnityEngine;
using System.Collections;

public class Break_2 : MonoBehaviour {

	private int counter = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (counter <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision collisionInfo){
		counter--;
	}

}
