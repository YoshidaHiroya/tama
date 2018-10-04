using UnityEngine;

public class sphereController : MonoBehaviour
{
	public float speed = 5;

	private void Start()
	{
		var force = ( transform.forward + transform.right ) * speed;
		GetComponent<Rigidbody>().AddForce( force, ForceMode.Acceleration );

	}
	private void Update(){
				}

}