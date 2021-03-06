﻿using UnityEngine;
using System.Collections;

public class SpikeScript : MonoBehaviour {


	private Player player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}

	// When player hits obstacle, deal damage
	void OnTriggerEnter2D(Collider2D col) {
		if(col.CompareTag("Player")){
			player.Damage (1);
		}
		
	}
}
