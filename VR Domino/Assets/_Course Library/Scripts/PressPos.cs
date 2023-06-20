using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PressPos : MonoBehaviour
{
    /// <summary>
    ///   손 위치에 따라서 ray가 가리키는 위치의 물체를 받아와,
    ///   (layerMask가 같다면) 해당 물체의 색을 변경해주는 함수
    /// </summary>
    
    public InputActionReference hand_position = null;
    public InputActionReference hand_rotation = null;
    public InputActionReference colorButton = null;
    public LayerMask layerMask;
    public static Color color_domino;

    private Ray hand_ray;
    private RaycastHit hand_rayhit;


    // Start is called before the first frame update
    void Start()
    {
    }

    public static double DegreeToRadian(float degree)
    {
        return degree / 180.0 * Math.PI;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = hand_position.action.ReadValue<Vector3>();
        Quaternion rotation = hand_rotation.action.ReadValue<Quaternion>();

        UpdateRay(position, rotation);
    }

    private void UpdateRay(Vector3 position, Quaternion direction)
    {
        GameObject camOffset = GameObject.Find("Camera Offset");
        Vector3 cam_pos = camOffset.transform.position;
        Vector3 direct = new Vector3(0, 0, 1);

        position += cam_pos;
        direct = direction * direct;


        hand_ray = new Ray();
        hand_ray.origin = position;
        hand_ray.direction = direct;

        Debug.DrawRay(position, direct * 10, Color.yellow);

        if (Physics.Raycast(hand_ray, out hand_rayhit, 10, layerMask))
        {
            if (hand_rayhit.collider != null)
            {
                float value = colorButton.action.ReadValue<float>();

                if (value >= 0.5)
                {
                    hand_rayhit.transform.GetComponent<MeshRenderer>().material.color = color_domino;
                }

            }
        }
    }
}
