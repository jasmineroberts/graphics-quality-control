using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMenuScriptOnly : MonoBehaviour {
	public GameObject qualitySettingUI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Activate_Quality_Menu_In_Game_Button_Clicked()
	{
		
		qualitySettingUI.SetActive (true);
	}
	public void De_Activate_Quality_Menu_In_Game_Button_Clicked()
	{

		qualitySettingUI.SetActive (false);
	}
}
