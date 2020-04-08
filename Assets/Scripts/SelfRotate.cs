using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour {
    private float speed;
    private System.Random ran = new System.Random();
	// Use this for initialization
	void Start () {
        speed = ran.Next(1,2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 1*speed, 0));
	}
}
