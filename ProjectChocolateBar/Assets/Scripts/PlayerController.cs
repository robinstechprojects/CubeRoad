using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 6.0f;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 180.0f;

        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);

    }
}
