using UnityEngine;
using System.Collections;

public class Bigger : MonoBehaviour {

	
	
	private int timer = 80;
	private bool tremble_start = false;
	private int change_type = 0;
	private float size = 1.0f;
	private float big_size = 1.5f;
	private float small_size = 0.85f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (tremble_start && timer > 0)
		{
			timer--;
		}
		if (timer <= 0) 
		{
			size *= 0.9f;
			transform.localScale = new Vector3 (size, size, size);

			if(size <= 1.0f)
			{
				tremble_start = false;
				timer = 80;
				transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			}
		}
	}
	
	void OnCollisionEnter(Collision collisionInfo){
		transform.localScale = new Vector3 (big_size, big_size, big_size);
		tremble_start = true;
	}
	

}
