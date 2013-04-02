using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {
	
	private Rect rect_menuBtn;
	
	void Start () {
		rect_menuBtn = new Rect(Screen.width - 85, 15, 70, 30);
	}

	void OnGUI() {
		if (GUI.Button(rect_menuBtn, "Menu")) {
			Application.LoadLevel(0);
		}
	}
}
