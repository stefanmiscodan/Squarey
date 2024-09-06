using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporting2 : MonoBehaviour {
	public GameObject thePlayer;
	public Transform teleportTarget;

	void OnTriggerEnter2D (Collider2D other) {
		thePlayer.transform.position = teleportTarget.transform.position;
	}


}
