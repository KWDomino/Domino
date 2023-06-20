using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSpecialDomino : MonoBehaviour
{
    public GameObject dominoConnector1_t;   // prefab to instantiate : transparent version
    public GameObject dominoConnector2_t;
    public GameObject dominoConnector3_t;
    public GameObject dominoArray_t;

    public GameObject dominoConnector1;     // prefab to instantiate
    public GameObject dominoConnector2;
    public GameObject dominoConnector3;
    public GameObject dominoArray;

    public float spawnHeight = 0.21f;        // height where domino spawns

    public int specialDominoNum = 1;
    private Vector3 currentPos;             // position of right hand controller
    private Vector3 previousPos;            // position where object was
    private GameObject domino;

    void OnEnable()
    {
        currentPos = GameObject.Find("RightHand Controller").transform.position;

        currentPos.y = spawnHeight;
        Quaternion q = Quaternion.LookRotation(currentPos);
        switch (specialDominoNum)
        {
            case 1:
                domino = Instantiate(dominoConnector1_t, currentPos, q);
                break;
            case 2:
                domino = Instantiate(dominoConnector2_t, currentPos, q);
                break;
            case 3:
                domino = Instantiate(dominoConnector3_t, currentPos, q);
                break;
            case 4:
                domino = Instantiate(dominoArray_t, currentPos, q);
                break;
        }

        previousPos = currentPos;
    }

    void Update()
    {
        currentPos = GameObject.Find("RightHand Controller").transform.position;
        currentPos.y = spawnHeight;

        if (!previousPos.Equals(currentPos))
        {
            domino.transform.LookAt(currentPos);
            domino.transform.position = currentPos;
        }

        previousPos = currentPos;
    }

    
    public void placeSDomino()
    {
        Vector3 pos = domino.transform.position;
        pos.y = spawnHeight;
        Quaternion q = domino.transform.rotation;

        Destroy(domino);

        switch (specialDominoNum)
        {
            case 1:
                domino = Instantiate(dominoConnector1, currentPos, q);
                break;
            case 2:
                domino = Instantiate(dominoConnector2, currentPos, q);
                break;
            case 3:
                domino = Instantiate(dominoConnector3, currentPos, q);
                break;
            case 4:
                domino = Instantiate(dominoArray, currentPos, q);
                break;
        }
    }

    public void updateDominoNum(int i)
    {
        specialDominoNum = i;
    }
}
