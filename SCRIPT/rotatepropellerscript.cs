using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatepropellerscript : MonoBehaviour {


	public float bladespeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//this.transform.Rotate (Vector3.forward * bladespeed);
		this.transform.Rotate (Vector3.up * bladespeed);
		
	}
}
