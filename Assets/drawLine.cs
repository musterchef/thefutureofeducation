using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour {
	private GameObject origin;
	private GameObject destination;

/// <summary>
/// Awake is called when the script instance is being loaded.
/// </summary>
void Awake()
	{
		origin = this.gameObject;
		destination = GameObject.Find("PrimaryEducation");
	}

	// Use this for initialization
	void Start () {
		this.GetComponent<LineRenderer>().SetPosition(0, origin.transform.position);
		this.GetComponent<LineRenderer>().SetPosition(1, destination.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
