using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour, IPart {

	Collider collider;
	Rigidbody rigidbody;

	void Awake() { 
		collider = GetComponent<Collider>();  
		rigidbody = GetComponent<Rigidbody>(); }

	void Start() { }

	void Update() { }

	public void Construct() { } 
}
