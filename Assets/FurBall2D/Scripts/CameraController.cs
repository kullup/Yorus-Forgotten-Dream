using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public Transform Player;
	public float m_speed = 0.1f;
	public float zoom = 0.7f;
	Camera mycam;

	public void Start()
	{
		mycam = GetComponent<Camera> ();
	}

	public void Update()
	{

		mycam.orthographicSize = (Screen.height / 100f) / zoom;

		if (Player) 
		{
			transform.position -= new Vector3(0, 4, 0);
			transform.position = Vector3.Lerp(transform.position, Player.position, m_speed) + new Vector3(0, 0, -12);
			transform.position += new Vector3(0, 4, 0);
		}


	}
}
