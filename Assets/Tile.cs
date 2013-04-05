using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {


	void Start () {
	
	}
	
	public int Numb;
	
	 void OnMouseDown() {
		Debug.Log (Numb);
		}
	
	public Tile right;
	public Tile left;
	public Tile top;
	public Tile bottom;
	
	void Update () {
		
	
	
	}
}
