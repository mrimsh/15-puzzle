using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	/// <summary>
	/// Rect объекты, представляющие прямоугольники, для задания размеров-позиций элементов GUI.
	/// </summary>
	private Rect rect_box, rect_startBtn, rect_skinBtn, rect_exitBtn;
	
	/// <summary>
	/// Метод Start выполняется один раз, при создании объекта с компонентом.
	/// Таким образом, если мы не создаем объект процедурно(то есть с помощью Instantiate и т.п.), этот метод 
	/// выполняется при запуске приложения.
	/// Это удобно для некоторой инициализации.
	/// </summary>
	public void Start ()
	{
		// Производим предварительные вычисления
		rect_box = new Rect (Screen.width / 2 - 300, Screen.height / 2 - 175, 600, 350);
		rect_startBtn = new Rect (Screen.width / 2 - 150, Screen.height / 2 - 90, 300, 70);
		rect_skinBtn = new Rect (Screen.width / 2 - 150, Screen.height / 2 - 10, 300, 70);
		rect_exitBtn = new Rect (Screen.width / 2 - 150, Screen.height / 2 + 70, 300, 70);
	}
	
	/// <summary>
	/// Метод OnGUI вызывается автоматически каждый раз, когда нужно перерисовать элементы интерфейса.
	/// Только в этом методе можно вызывать методы класса GUI и GUILayout, позволяющие отрисовывать элементы
	/// интерфейса. Вызов их из других методов вызовет ошибку(конечно, если эти методы не вызываются из самого OnGUI)
	/// Этот метод может вызываться чаще чем один раз в кадр, поэтому крайней НЕ рекомендуется производить
	/// в нем вычисления!
	/// </summary>
	void OnGUI ()
	{
		// Рамка
		GUI.Box (rect_box, "Main menu");
		
		// Кнопка. Возвращает true, при нажатии
		if (GUI.Button (rect_startBtn, "Start Game")) {
			Application.LoadLevel (1);
		}
		if (GUI.Button (rect_skinBtn, "Set Skin")) {
			// TODO: Skin selection dialog
		}
		if (GUI.Button (rect_exitBtn, "Exit")) {
			Application.Quit ();
		}
	}
}
