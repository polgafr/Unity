using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CamaraFollow : MonoBehaviour {

    public Transform player;
    public float yOffset;


    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void LateUpdate () {

//      transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(player.position.x, player.position.y + yOffset, transform.position.z);

    }
}
