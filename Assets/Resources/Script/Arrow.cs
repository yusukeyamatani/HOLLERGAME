using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject [] items = GameObject.FindGameObjectsWithTag("Item");

		if (items.Length == 0) {
//			print ("#######################CLEAR");
		} else {
//			print (items[0].transform.position);
//			print (gameObject.transform.rotation);
			transform.LookAt(items[0].transform.position);

		} 
	
	}
} 
  