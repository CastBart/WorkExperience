using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTextScript : MonoBehaviour {
    public float speed;
    public float maxRotation;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0.0f,180+ (maxRotation * Mathf.Sin(Time.time * speed)), 0f);
    }

}
