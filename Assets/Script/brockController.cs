using UnityEngine;
using UnityEngine.UI;
public class brockController : MonoBehaviour
{
	public float speed = 20; // 動く速さ
	public Text counttext;
	public Text wintext;
	public int jumpcount;

	private Rigidbody rb; // Rididbody
	 int count ;
	void Start()
	{
		// Rigidbody を取得
		rb = GetComponent<Rigidbody>();
		count = 0;
		wintext.text = "";
		jumpcount = 0;
	}

	void Update()
	{
		// カーソルキーの入力を取得
		var moveHorizontal = Input.GetAxis("Horizontal");
		var moveVertical = Input.GetAxis("Vertical");

		// カーソルキーの入力に合わせて移動方向を設定
		var movement = new Vector3(moveVertical, 0, -moveHorizontal);

		// Ridigbody に力を与えて玉を動かす
		rb.AddForce(movement * speed);
		if (Input.GetKeyDown ("space") == true && jumpcount < 2) {
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, speed, 0);
			jumpcount += 1;
		}
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "PickUp") {
			Destroy (col.gameObject);
			count=count + 1;
			Debug.Log ("kaunto");
			counttext.text = "Count:" + count.ToString();
			if (count >= 8) {
				wintext.text="YouWin!";
			}

		}
			if (col.gameObject.tag == "Ground") 
			{
				wintext.text="GameOver!";
			}
		if (col.gameObject.tag == "Wall") 
		{
			jumpcount = 0;
		}


	}
}