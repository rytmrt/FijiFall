using UnityEngine;
using System.Collections;

public class Break : MonoBehaviour {

	void OnCollisionEnter(Collision collisionInfo){
		Destroy (this.gameObject);
	}
}
