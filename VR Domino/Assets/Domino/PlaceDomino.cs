using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDomino : MonoBehaviour
{
    public GameObject dominoPrefab;
    public float dominoSpawnRate = 10.0f;

    private Transform target;
    private float time;

    void Start()
    {
        target = GameObject.Find("RightHand Controller").transform;
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= dominoSpawnRate)
        {
            GameObject domino = Instantiate(dominoPrefab, transform.position, transform.rotation);
            domino.transform.LookAt(target);
        }
    }
}
