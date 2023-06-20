using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindDomino : MonoBehaviour
{
    void Update()
    {
        GameObject pusher = GameObject.Find("Pusher").gameObject;
        if(pusher != null)
        {
            Debug.Log("domino found!");
            Rigidbody rigidbody = pusher.GetComponent<Rigidbody>();
            rigidbody.velocity = pusher.transform.forward;
            Destroy(pusher, 0.1f);
            Destroy(this);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
