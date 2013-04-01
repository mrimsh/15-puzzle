using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	public static int Health = 100;
    static float x = 0;
    static float y = 0;
    static float z = 0;
    static Vector3 position = new Vector3(x, y, z);
    static Vector3 dx = new Vector3(1, 0, 0);
    static Vector3 dy = new Vector3(0, 1, 0);
    static Vector3 dz = new Vector3(0, 0, 1);
    static Vector3 MousePos = new Vector3();
    public GameObject prefab;
    // Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		
		
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0.0f, 0.0f, 17.1f));
            GameObject go =(GameObject) Instantiate(prefab);
            go.transform.position = screenPoint;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && position.x > -20)
        {
            position -= dx;
        }
        if (Input.GetKey(KeyCode.RightArrow) && position.x < 20)
        {
            position += dx;
        }
        if (Input.GetKey(KeyCode.UpArrow) && position.y < 20)
        {
            position += dy;
        }
        if (Input.GetKey(KeyCode.DownArrow) && position.y > -20)
        {
            position -= dy;
        }
        
		}
}
