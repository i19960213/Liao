using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level_Ctrl : MonoBehaviour {
	public GameObject BGMControl;
	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
		SceneManager.LoadScene("MainMenu");


	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)) //條件需要抓場景名
		{BGMControl.SendMessage ("ChangeMusic", 6);}
	}
	void ConToStage( int Index ){
		if (Index == 1) {
			SceneManager.LoadScene ("Level1StageTE-1");
		}
	}
}
