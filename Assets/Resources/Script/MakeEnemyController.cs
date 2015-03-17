using UnityEngine;
using System.Collections;

public class MakeEnemyController : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

	public void MakeEnemy(){
		// プレハブを取得
		GameObject enemyPrefab = (GameObject)Resources.Load ("Prefab/enemy");
		// プレハブからインスタンスを生成
		Instantiate (enemyPrefab, gameObject.transform.position, Quaternion.identity);
		
	}
}
