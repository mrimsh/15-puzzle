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
	void Swap(Tile t)
	{
		int tempNumber = t.number;
		Material tempMaterial = t.renderer.material;
		
		t.number = this.number;
		this.number = tempNumber;
		t.renderer.material = this.renderer.material;
		this.renderer.material = tempMaterial;
	}
	bool Move()
	{
		if(left != null && left.number == 0)
		{
			Swap(left);
			return true;
		} else if(right != null && right.number == 0)
		{
			Swap(right);
			return true;
		} else if(top != null && top.number == 0)
		{
			Swap(top);
			return true;
		} else if(bottom != null && bottom.number == 0)
		{
			Swap(bottom);
			return true;
		} else return false;
		
	}
	void OnMouseDown ()
	{
		if(Move ())
		{
			Debug.Log (number);
		}
	}
}
