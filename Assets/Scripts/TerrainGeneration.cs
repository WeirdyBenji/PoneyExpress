using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour {

    public GameObject currentGround;
    public GameObject nextGround;
    int frameRate = 0;
    private int pos = -20;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if ((frameRate % 20) == 0)
            MoveGround();
    }

    void MoveGround() {
        pos++;
        Instantiate(currentGround, new Vector3(pos * 1.0F, 0, 0), Quaternion.identity);
        //Instantiate(nextGround, new Vector3(pos * 1.0F, -1, 0), Quaternion.identity);
        //if (Random(0, 8) == 2)
            Instantiate(nextGround, new Vector3(pos * 1.0F, -1, 0), Quaternion.identity);
    }
}
