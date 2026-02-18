using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
	public GameObject BrickParticle = null;

	void OnCollisionEnter(Collision other)
	{
		if (BrickParticle != null)
			Instantiate(BrickParticle, transform.position, Quaternion.identity);

		GameManager.Instance.Bricks--;
		Destroy(gameObject);
	}
}
