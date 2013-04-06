using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
	public Tile right;
	public Tile left;
	public Tile top;
	public Tile bottom;
	
	public int number;

	void Start ()
	{
	}
	
	void Update ()
	{
	}
	
	void OnMouseDown ()
	{
		Debug.Log (number);
	}
}
