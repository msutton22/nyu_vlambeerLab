using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			Pathmaker.globalTileCount = 0;
			//gameObject.SetActive(true);
			//int scene = SceneManager.GetActiveScene().buildIndex;
			//SceneManager.LoadScene(1);
			SceneManager.LoadScene(0);
			
		}
	}
}
