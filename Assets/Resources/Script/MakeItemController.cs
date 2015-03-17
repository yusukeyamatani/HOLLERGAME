using UnityEngine;
using System.Collections;

public class MakeItemController : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//
//	}
	
//	// Update is called once per frame
//	void Update () {
//	
//	}


	public void MakeItem(){
		// プレハブを取得
		GameObject itemPrefab = (GameObject)Resources.Load ("Prefab/item");
		// プレハブからインスタンスを生成
		Instantiate (itemPrefab, gameObject.transform.position, Quaternion.identity);

	}
}
