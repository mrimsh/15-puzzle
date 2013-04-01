using UnityEngine;
using System.Collections;

public class ToMainMenu : MonoBehaviour {

	void OnGUI() {
		if (GUI.Button(new Rect(Screen.width - 85, 15, 70, 30), "Menu")) {
			Application.LoadLevel(0);
		}
	}
}
