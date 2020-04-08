using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmName : MonoBehaviour {
    public GameObject inputObject;
    public InputField name;
	// Use this for initialization
	void Start () {
        name.text = Global.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void setName()
    {
        string nam = name.text;
        if (nam == "")
        {
            nam = "黄承喜";
        }
        Global.name = nam;
    }
    public void SetNameState()
    {
        inputObject.SetActive(!inputObject.activeInHierarchy);
        if (inputObject.activeInHierarchy)
        {
            Global.enableScene = false;
        }
        else
        {
            Global.enableScene = true;
        }
    }
}
