using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
	float speed = 0.0F;
	
	const float default_speed = 2.0F;
	const float run_speed = 4.0F;
	bool triggerflag = false;
	bool  idleflag = false;

	private Vector3 move = Vector3.zero;
	GameObject target ;

	
	
	void  Start (){
		target = GameObject.FindWithTag("Player");
		speed = default_speed;
	}
	
	void Update (){

		if (idleflag ==  true){ 
			animation.Play("idle");
			// 2秒待つ
			StartCoroutine ("StartRot");
		}
		if (idleflag==false){
			if (triggerflag == false){ 
				animation.Play("walk02");
			}else{
				animation.Play("run");
			}
			transform.LookAt(target.transform);
			move = Vector3.forward;
			transform.Translate(move * speed * Time.deltaTime);
		}
	}

	private IEnumerator StartRot()
	{	
		yield return new WaitForSeconds(3.0f);
		idleflag = false ;

	}


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			triggerflag = true;
			speed = run_speed;
			idleflag = true;
		}
	}

	void OnTriggerExit(Collider other) {
		//コライダから離れた瞬間実行される関数
		if (other.gameObject.tag == "Player") {
			triggerflag = false;
			idleflag = false;
			speed = default_speed;
		}
	}



}