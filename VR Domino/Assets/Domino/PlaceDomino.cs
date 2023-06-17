using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDomino : MonoBehaviour
{
    public GameObject dominoPrefab;         // prefab to instantiate
    public float dominoSpawnRate = 0.2f;    // distance between dominos

    private Vector3 previousPos;            // position of previously placed domino
    private Vector3 currentPos;             // position of right hand controller

    private GameObject previousDomino;      // previous Domino GameObject
    private Vector3 previousDominoTarget;   // previous Domino is looking at this direction (normalized)

    private bool isFirst = true;

    void Start()
    {
        currentPos = GameObject.Find("RightHand Controller").transform.position;
        currentPos.y = 0.5f;

        GameObject domino = Instantiate(dominoPrefab, currentPos, transform.rotation);
        previousPos = currentPos;
        previousDomino = domino;
    }

    void Update()
    {
        currentPos = GameObject.Find("RightHand Controller").transform.position;

        float   distance = getDistance(previousPos, currentPos);    // distance between previous domino and controller

        if (distance >= dominoSpawnRate)
        {
            currentPos.y = 0.5f;

            GameObject domino = Instantiate(dominoPrefab, currentPos, transform.rotation);
            domino.transform.LookAt(previousPos);

            Vector3 currDominoTarget = currentPos - previousPos;
            currDominoTarget.Normalize();

            if (isFirst)
            {
                currentPos.y = 0.2f;

                previousDomino.transform.LookAt(currentPos);
                isFirst = false;
            }
            else
            {
                currentPos.y = 0.0f;

                Vector3 prevDominoTarget = midpoint(previousDominoTarget, currDominoTarget);
                previousDomino.transform.LookAt(currentPos + prevDominoTarget);
            }

            currentPos.y = 0.5f;
            previousDominoTarget = currDominoTarget;
            previousPos = currentPos;
            previousDomino = domino;
        }
    }

    float getDistance(Vector3 previous, Vector3 current)
    {
        float dx = previous.x - current.x;
        float dz = previous.z - current.z;

        return Mathf.Sqrt(dx * dx + dz * dz);
    }

    Vector3 midpoint(Vector3 previous, Vector3 next) { return (previous + next) / 2; }
}
