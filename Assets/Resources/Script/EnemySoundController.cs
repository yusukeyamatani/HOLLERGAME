// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class EnemySoundController : MonoBehaviour {
	
	//プロパティ
	public float playInterval =  0.5f;  //連続で足音が再生されるまでに必要な間隔(秒)
	
	private float nextPlayTime = 0;   //次に足音を再生できる時間(連続再生を防止する)
	
	//地面(素材)ごとの音声(オーディオクリップ)
	public AudioClip[] otherClips;    //その他
	
	//コンポーネントの参照
	private AudioSource audioSource;
	
	//スクリプトの導入時に一度だけ呼ばれる
	void  Awake (){
		//コンポーネントの参照を代入
		audioSource = GetComponent<AudioSource>();
	}
	
	//毎フレーム呼ばれる
	//動いていたら足音を鳴らす
	void  Update (){
		//一定の間隔を置いたら再生
		if( Time.time >= nextPlayTime )
		{
			//キャラクターが地面に接触していて、止まっていない場合に足音を鳴らす。
			nextPlayTime = Time.time + 10;    //足音が鳴り続けないように、一定の間隔を置くための時間を更新
			OnFootStrike(); //足音を鳴らす
		}	
	}
	
	//足音を鳴らす
	void  OnFootStrike (){
		float volume = Mathf.Clamp01(2000);  //音量をキャラクターの速度から0~1の間で算出する
		AudioClip clip = GetAudioClip();  //再生するオーディオクリップを取得
		
		audioSource.PlayOneShot(clip, volume );    //再生
	}
	
	//Playerの地面に応じたオーディオクリップの取得
	AudioClip GetAudioClip (){
		AudioClip clip;
//		string tag = null;    //地面のタグ
//		
//		RaycastHit hit;
//		if( Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), -Vector3.up, hit) )   //足もとに衝突検知のためのレイ(光線)を飛ばす
//		{
//			tag = hit.collider.tag; //衝突した地面のタグを代入
//			
//		}
		
		//タグによってオーディオクリップを代入する	
//		if( tag == "Wood" ) //地面のタグが木なら
//		{
//			clip = woodClips[Random.Range(0, woodClips.length)];    //プロパティからランダム(無作為)に一つ取得する
//		}
//		else if( tag == "Dirt") //地面のタグが土なら
//		{
//			clip = dirtClips[Random.Range(0, dirtClips.length)];    //プロパティからランダム(無作為)に一つ取得する
//		}
//		else    //その他
//		{
//			clip = otherClips[Random.Range(0, otherClips.length)];  //プロパティからランダム(無作為)に一つ取得する
//		}
		clip = audioSource.clip;
//		clip = otherClips[Random.Range(0, otherClips.length)];  //プロパティからランダム(無作為)に一つ取得する
		
		return clip;
	}
}