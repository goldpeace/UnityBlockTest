using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	Vector3 firstForce = new Vector3(1000,1000,0);
	int initialBlockCnt = 0;
	int destroyBlockCnt = 0;
	Vector3 initializePosition;

	// Use this for initialization
	void Start () {
		initialBlockCnt = GameObject.FindGameObjectsWithTag("Block").Length;
		initializePosition = rigidbody.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButtonUp("Jump") && rigidbody.velocity == new Vector3(0, 0, 0)){
			// ボールに初速を加える
			rigidbody.AddForce (firstForce);
		}
	}

	void Initialize() {
		print ("initialize");
		rigidbody.velocity = new Vector3(0, 0, 0);
		rigidbody.transform.localPosition = initializePosition; 
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Block")
		{
			Destroy(col.gameObject);

			destroyBlockCnt++;
		
		
			SceneScript.score += 100;


			if( initialBlockCnt == destroyBlockCnt ) {
				// クリア処理
				SceneScript.score += SceneScript.life*1000;
			}
		}

		// 壁にあたると加速
		rigidbody.velocity = rigidbody.velocity.normalized * 20;
		// 横・縦しないように
		if (Mathf.Abs(rigidbody.velocity.y) < 5.0f) {		
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y * 5.0f);
		}
		if (Mathf.Abs(rigidbody.velocity.x) < 5.0f) {
			rigidbody.velocity = new Vector3(rigidbody.velocity.x * 5.0f, rigidbody.velocity.y);
		}
	}
}
