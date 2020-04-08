using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void reload()
    {
        Global.enableScene = false;
        SceneManager.LoadSceneAsync("main");
        //#if UNITY_EDITOR
            //UnityEditor.SceneManagement.EditorSceneManager.LoadScene("main");
        //#endif
    }
}
