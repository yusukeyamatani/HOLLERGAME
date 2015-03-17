using UnityEngine;
using System.Collections;

public class TreasureControl : MonoBehaviour{
    
	void HitWithPlayer() {
		StageController stageController = GameObject.Find("StageManager").GetComponent<StageController>();
		stageController.ItemNumSubtraction(gameObject);
		Destroy(gameObject);
	}
	

	void OnTriggerEnter(Collider other) {
//		print (other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			HitWithPlayer();
		}
	}
}