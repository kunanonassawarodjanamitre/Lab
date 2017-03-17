using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		CloseDialog ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public  void CloseDialog(){
		this.gameObject.SetActive(false);
	}

	public  void OpenDialog(){
		this.gameObject.SetActive (true);
	}
}
