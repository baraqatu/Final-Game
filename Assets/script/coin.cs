﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	public int score = 0;
	private AudioSource getCoin;
	

	// Use this for initialization
	void Start () {
		getCoin = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player"){
			Destroy (gameObject);
			score++;
			playgetCoinSound();
			Debug.Log("Score: " + score);
		}
	}
	public void playgetCoinSound(){
		getCoin.Play();
	}
}
