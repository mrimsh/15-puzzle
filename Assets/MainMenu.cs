using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI() {
		GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 175, 600, 350), "Main menu");
		if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 90, 300, 70), "Start Game")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 10, 300, 70), "Set Skin")) {
			
		}
		if (GUI.Button(new Rect(Screen.width / 2 - 150, Screen.height / 2 + 70, 300, 70), "Exit")) {
			Application.Quit();
		}
	}
}
