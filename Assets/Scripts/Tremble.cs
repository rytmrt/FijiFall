using UnityEngine;
using System.Collections;

public class Tremble : MonoBehaviour {


	private int timer = 80;
	private bool tremble_start = false;
	private int change_type = 0;
	private float size = 1.0f;
	private float big_size = 1.05f;
	private float small_size = 0.85f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (tremble_start) {
			if (size <= 0.6f && change_type != 1) {
				change_type = 1;
			} 
			else  if(size >= 1.2f  && change_type != 2){
				change_type = 2;
			}
			switch(change_type)
			{
			case 1:
				size *= big_size;
				break;
			case 2:
				size *= small_size;
				break;
			}

			transform.localScale = new Vector3 (size, size, size);
			timer--;
			if (timer <= 0) {
					tremble_start = false;
					timer = 80;
				transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			}
		}
	}

	void OnCollisionEnter(Collision collisionInfo){
		tremble_start = true;
		change_type = 1;
	}



}
