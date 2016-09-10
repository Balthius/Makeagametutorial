using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour
{
	public float speed = 1.0f;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		//moves object left or right with modifiers of directional input, speed and time rather than frames
		transform.position += Vector3.right * Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
	}
}
