using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	public float PaddleSpeed = 1f;
	private Vector3 playerPos = new Vector3(0f, -9f, 0f);

	void Update()
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * PaddleSpeed);
		playerPos = new Vector3(Mathf.Clamp(xPos, -8.5f, 8.5f), -9f, 0f);
		transform.position = playerPos;
	}
}
