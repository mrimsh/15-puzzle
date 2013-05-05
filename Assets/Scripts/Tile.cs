using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
	/// <summary>
	/// Ссылка на правую плитку. Null, если там ничего нет.
	/// </summary>
	public Tile right;
	/// <summary>
	/// Ссылка на левую плитку. Null, если там ничего нет.
	/// </summary>
	public Tile left;
	/// <summary>
	/// Ссылка на верхнюю плитку. Null, если там ничего нет.
	/// </summary>
	public Tile top;
	/// <summary>
	/// Ссылка на нижнюю плитку. Null, если там ничего нет.
	/// </summary>
	public Tile bottom;
	/// <summary>
	/// Цифра в текущей плитке.
	/// </summary>
	public int number;
	
	/// <summary>
	/// Метод автоматически вызывается в случае нажатия мышью по Collider этого объекта.
	/// </summary>
	void OnMouseDown ()
	{
		// Пытается переместить плитку на свободное место и сохраняет результат в переменную
		bool isMoved = Move ();
		
		// Реакция на успешное или неуспешное перемещение 
		if (isMoved) {
			Debug.Log ("Tile " + number + " has moved.");
		} else {
			Debug.Log ("Tile " + number + " can not move!");
		}
	}
	
	/// <summary>
	/// Пытается переместить текущую плитку на соседнюю свободную. Если находит пустую плитку,
	/// то меняется с ней местом и возвращает true. Иначе ничего не происходит и возвращает false.
	/// </summary>
	private bool Move ()
	{
		// если слева не null(не граница), то проверяем номер плитки. Если она = 0(то есть пустышка),
		// то меняемся с ней местами и возвращаем true.
		if (left != null && left.number == 0) {
			Swap (left);
			return true;
		} else if (right != null && right.number == 0) {
			Swap (right);
			return true;
		} else if (top != null && top.number == 0) {
			Swap (top);
			return true;
		} else if (bottom != null && bottom.number == 0) {
			Swap (bottom);
			return true;
		} else {
			// если ни один из случаев не подошел, то возвращаем false сигнализирующий о неудаче
			return false;
		}
	}
	
	/// <summary>
	/// Меняет местами эту плитку с плиткой переданной в параметре.
	/// </summary>
	/// <param name='t'>
	/// Плитка, которую нужно поменять местами с этой.
	/// </param>
	private void Swap (Tile t)
	{
		// сохраняем номер и изображение плитки для замены в переменные (буферы)
		int tempNumber = t.number;
		Material tempMaterial = t.renderer.material;
		
		// выставляем заменяемой плитке, значения текущей плитки
		t.number = this.number;
		t.renderer.material = this.renderer.material;
		// выставляем текущей плитке значения сохраненные в буфере(так как у заменяемой плитки значения уже затерлись)
		this.number = tempNumber;
		this.renderer.material = tempMaterial;
	}

}
