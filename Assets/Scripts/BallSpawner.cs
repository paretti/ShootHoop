using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 5.0f;

		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GameObject instance = Instantiate(ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.left * speed;
		}

		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GameObject instance = Instantiate(ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.right * speed;
		}

		else if (Input.GetButtonDown("Fire1"))
		{
			GameObject instance = Instantiate(ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * speed;
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			GameObject instance = Instantiate(ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.back * speed;
		}
	}
}
