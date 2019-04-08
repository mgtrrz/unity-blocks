using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour {

	// bar is the 1 in 1-2-3-4
	// beat is all of the numbers in the 1-2-3-4

	public float tempo = 92f;
	public float beatsInMeasure = 4;
	public float bar = 1;
	public int beat = 1;

	public BlockManager blockManager;
	

	public float timer = 0;

	// Use this for initialization
	void Start () {
		Debug.Log(60/tempo);
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;
		if ( timer >= 60/tempo ) {
			// Call Beat()
			blockManager.Beat();
			if ( beat >= beatsInMeasure) {
				bar += 1;
				beat = 1;
			} else {
				beat += 1;
			}
			timer = 0;
		}

	}


}
