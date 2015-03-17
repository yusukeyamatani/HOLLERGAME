using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class StageController : MonoBehaviour{
    
    public int numOfItems = 0;
	int itemMaxNum  = 10 ;

	void Awake(){
		MakeRandomItem ();
		MakeRandomEnemy ();
		
	}

	void Start () {
		GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
		numOfItems = items.Length;
	}
    
    void OnGUI(){
		GUI.Label (new Rect (0, 0, 100, 60), " Items :" + numOfItems);
    }

	public void ItemNumSubtraction(GameObject Item) {
		numOfItems--;

	}

	void MakeRandomItem() {
		GameObject[] makeItemManagers = GameObject.FindGameObjectsWithTag("makeItem");

		//↓シャッフル
		makeItemManagers = makeItemManagers.OrderBy(i => Guid.NewGuid()).ToArray();

		if(makeItemManagers.Length < 10){
			itemMaxNum = makeItemManagers.Length;
		}

		for (int i = 0; i < itemMaxNum; i++) {
			MakeItemController makeItemController = makeItemManagers[i].GetComponent<MakeItemController>();
			makeItemController.MakeItem();
		}

	}
	void MakeRandomEnemy() {
		GameObject[] makeItemManagers = GameObject.FindGameObjectsWithTag("makeEnemy");
		
		//↓シャッフル
		makeItemManagers = makeItemManagers.OrderBy(i => Guid.NewGuid()).ToArray();

		MakeEnemyController  makeEnemyController = makeItemManagers[0].GetComponent<MakeEnemyController>();
		makeEnemyController.MakeEnemy();
//		MakeEnemyController  makeEnemyController2 = makeItemManagers[1].GetComponent<MakeEnemyController>();
//		makeEnemyController2.MakeEnemy();

	}
}