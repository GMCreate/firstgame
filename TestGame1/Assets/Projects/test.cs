using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    private float time_;
    // Use this for initialization
    void Start () {
        time_ = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
        time_ -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Q)) transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        if (Input.GetKey(KeyCode.E)) transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        if (Input.GetKey(KeyCode.W)) transform.position += transform.forward;
        if (Input.GetKey(KeyCode.S)) transform.position -= transform.forward;
        if (Input.GetKey(KeyCode.D)) transform.position += transform.right;
        if (Input.GetKey(KeyCode.A)) transform.position -= transform.right;
    }
}
