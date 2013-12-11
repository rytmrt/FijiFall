using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {

	private int counter = 2;

	public int break_count = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (break_count != 0) {
			if (break_count == counter) {
					Destroy (this.gameObject);
			}
		}

	}
	

	void OnCollisionEnter(Collision collisionInfo){
		counter--;
	}

}
