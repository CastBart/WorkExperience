using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBallScript : MonoBehaviour {

    public Transform ball;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ball.position + offset;
	}
}
