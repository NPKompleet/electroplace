using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {
	bool collided;

	// Use this for initialization
	void Start () {
		collided = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!collided) {
			this.gameObject.transform.Translate (Vector3.right * Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider other){
		collided = true;
		this.gameObject.transform.position = other.gameObject.transform.position;
	}
}
