using UnityEngine;
using System.Collections;

[System.Serializable]

public class GameSkin {
    public Material A1;
    public Material A2;
    public Material A3;
    public Material A4;
    public Material B1;
    public Material B2;
    public Material B3;
    public Material B4;
    public Material C1;
    public Material C2;
    public Material C3;
    public Material C4;
    public Material D1;
    public Material D2;
    public Material D3;
    public Material D4;
    public Material bg;

    public Material GetMaterial(string materialName)
    {
        switch (materialName)
        {
            case "A1": return A1;
            case "A2": return A2;
            case "A3": return A3;
            case "A4": return A4;
            case "B1": return B1;
            case "B2": return B2;
            case "B3": return B3;
            case "B4": return B4;
            case "C1": return C1;
            case "C2": return C2;
            case "C3": return C3;
            case "C4": return C4;
            case "D1": return D1;
            case "D2": return D2;
            case "D3": return D3;
            case "D4": return D4;
            case "bg": return bg;
            default: return null;
        }
   }
	// Use this for initialization
	void Start () {
            
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
