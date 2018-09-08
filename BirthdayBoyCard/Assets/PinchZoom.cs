using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour {

    float maxZoom = 10.0f;
    float minZoom = 2.0f;
    public float perspectiveZoomSpeed = 0.01f;
    public float orhtographicZoomSpeed = 0.01f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 2)
        {
            Touch touchOne = Input.GetTouch(0);
            Touch touchTwo = Input.GetTouch(1);

            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
            Vector2 touchTwoPrevPos = touchTwo.position - touchTwo.deltaPosition;

            float prevTouchDeltaMag = (touchOnePrevPos - touchTwoPrevPos).magnitude;
            float touchDeltaMag = (touchOne.position - touchTwo.position).magnitude;

            float deltaMagDiff = prevTouchDeltaMag - touchDeltaMag;

            if(GetComponent<Camera>().orthographic)
            {
                GetComponent<Camera>().orthographicSize += deltaMagDiff * orhtographicZoomSpeed;

                GetComponent<Camera>().orthographicSize = Mathf.Max(GetComponent<Camera>().orthographicSize, 10.0f);
               // GetComponent<Camera>().orthographicSize = Mathf.Min(GetComponent<Camera>().orthographicSize, 2.0f);
               

            }
            else
            {
                GetComponent<Camera>().fieldOfView += deltaMagDiff * perspectiveZoomSpeed;

                GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 0.1f, 179.9f);
            }
        }
	}
}
