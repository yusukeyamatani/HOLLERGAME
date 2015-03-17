using UnityEngine;
using System.Collections;

public class Enemy_TEST_AI : MonoBehaviour {


	GameObject player;
	public float speed =  0.05F;
	public float gravity = 50.0F;
	Vector3 moveDirection = Vector3.zero;
	CharacterController controller ;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//アニメーションで走らせます
		animation.Play("walk02");
		player = GameObject.FindWithTag("Player");
		//mobの位置と自分の位置の差分をとって距離をはかり、0でなければ
//		print (Vector3.Distance (gameObject.transform.position, player.transform.position));
//		if (Vector3.Distance(gameObject.transform.position, player.transform.position) != 0) {
			//自分の位置をtargetDirectionに入れて
			Vector3 targetDirection = player.transform.position;
			//敵が浮かない様に縦座標は0に固定します
			targetDirection.y = 0;
			//敵の向きを自分に向かせます
//			gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDirection - transform.position), Time.time * 0.1f);
		    gameObject.transform.LookAt(player.transform.position);
			//敵のスピードと重力か次の位置を計算して移動させます
		    moveDirection += gameObject.transform.forward * 1;
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime * speed);
		}
//	}
}
