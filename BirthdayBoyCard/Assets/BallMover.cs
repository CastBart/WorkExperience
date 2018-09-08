using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {
    Rigidbody rb;
    private bool isFlat = true;
    private float speed = 5.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tilt = Input.acceleration;

        if(isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }
        rb.AddForce(tilt * speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Present")
        {
            Destroy(other.gameObject);
        }
    }
}
