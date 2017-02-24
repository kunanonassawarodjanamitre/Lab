using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderMove : MonoBehaviour {

	public Rigidbody rg;
	public float velocity;
	public GameObject CylinderEffectDiePrefab;

	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (velocity,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Ball") {
			Destroy (collision.gameObject);
		}
	}

	void OnDestroy() {
		GameObject dieEffect = Instantiate(CylinderEffectDiePrefab);
		dieEffect.transform.position = this.gameObject.transform.position;
	}
}
