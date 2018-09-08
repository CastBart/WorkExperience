using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePresnetScript : MonoBehaviour {
    Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime*speed, Space.World);
	}
}
