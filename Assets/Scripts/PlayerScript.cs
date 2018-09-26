using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	
	float speed = 10f;//Playerの移動スピード

	void Start () {
		
	}

	void Update () {
		Move ();//Playerを移動させる関数
	}
		
    //当たり判定
	void onCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			SceneManager.LoadScene ("GameOverScene")
		}
	

	//Playerを移動させる関数
	void Move()
	{
		if(Input.GetKey("up") == true){
			this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("down") == true){
			this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("right") == true){
			this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}

		if(Input.GetKey("left") == true){
			this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);//"this"てのはアタッチしてるオブジェクト自身のこと
		}
	}
}
