using UnityEngine;

public class blockController : MonoBehaviour
{
	private void OnCollisionEnter ( Collision collision )
	{
		Destroy( gameObject );
	}
}
