using UnityEngine;

public class sphereController : MonoBehaviour
{
	public float speed = 10;

	private void Start()
	{
		var force = ( transform.forward + transform.right ) * speed;
		GetComponent<Rigidbody>().AddForce( force, ForceMode.VelocityChange );
	}
}