using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameSkin[] skins;
    public static int skinId = 1;
	public Tile space;
	int randomQuality = 1000;

    void OnLevelWasLoaded()
    {

        skinId = PlayerPrefs.GetInt("skinId");

        for (char c = 'A'; c < 'E'; c++)
        {
            for (int i = 1; i <= 4; i++)
            {
                string name = c.ToString();
                name += i;
                GameObject g = GameObject.Find(name);
                Material m = skins[skinId].GetMaterial(name);
                g.renderer.material = m;
            }
        }
        GameObject bg = GameObject.Find("_BG");
        bg.renderer.material = skins[skinId].GetMaterial("bg");
        
    }
	// Use this for initialization
	void Start () {
		for (int i = 0; i < randomQuality; i++) {
			Tile[] s = new Tile[4];
			int n = -1;
			if (space.right != null) {
				n++;
				s[n] = space.right;
			}
			if (space.left != null) {
				n++;
				s[n] = space.left;
			}
			if (space.top != null) {
				n++;
				s[n] = space.top;
			}
			if (space.bottom != null) {
				n++;
				s[n] = space.bottom;
			}
			Tile goal = s[Random.Range(0, n + 1)];
			space.Swap(goal);
			space = goal;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
