using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {

	public AudioSource sound01;

	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		sound01 = GetComponent<AudioSource>();
		sound01.PlayOneShot(sound01.clip);
	}

	void Update () {
		//指定のキーが押されたら音声ファイル再生

		
	}
}