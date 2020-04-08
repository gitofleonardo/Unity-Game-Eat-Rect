using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour {
    private System.Random rand = new System.Random();
    public GameObject prefab;

    // Use this for initialization
    void Start () {
        generateRandomFood();
	}
    private void generateRandomFood()
    {
        for (int i = 0; i < 20; i++)
        {
            float ranx = rand.Next(-9, 9);
            float ranz = rand.Next(-9, 9);
            float x = 1 * ranx;
            float z = 1 * ranz;
            Vector3 v = prefab.transform.position;
            v.x = x;
            v.z = z;
            v.y = 1;
            prefab.transform.position = v;
            GameObject obj = Instantiate(prefab);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
