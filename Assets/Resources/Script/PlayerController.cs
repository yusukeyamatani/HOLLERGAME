using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void  Update (){
		Animator motion= GetComponent<Animator>();
		AnimatorStateInfo state = motion.GetCurrentAnimatorStateInfo(0);
		
		if(Input.GetKeyDown("space")){
			motion.SetBool("Run", true);
		}
		
		if(state.IsName("Locomotion.RUN00_F")){
			motion.SetBool(" Run", false);
		}
	}

	void OnTriggerEnter(Collider other) {
		//		print (other.gameObject.tag);
		if (other.gameObject.tag == "Enemy") {
			print("GAMEOVER");
			Destroy(gameObject);
		}
	}
}

