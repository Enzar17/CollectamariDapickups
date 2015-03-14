﻿using UnityEngine;
using System.Collections;

public class CapsuleSpawner : MonoBehaviour {

	public GameObject pickupObject;

	private float timeElapsed = 0F;
	private float spawnTime = 0.5F;


	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed > spawnTime) {
			GameObject spawnedPickup = (GameObject)Instantiate(pickupObject);
			spawnedPickup.transform.position = new Vector3(Random.Range(-25, 25), 1, Random.Range(-25, 25));
			timeElapsed -= spawnTime;
		}
	}
}
