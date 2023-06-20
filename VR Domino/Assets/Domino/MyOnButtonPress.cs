using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MyOnButtonPress : MonoBehaviour
{
    public GameObject DominoSpawner;
    public GameObject SpecialDominoSpawner;

    public InputAction action = null;

    public bool isSDomino = false;

    private void Awake()
    {
        action.started += Pressed;
        action.canceled += Released;
    }
    private void OnDestroy()
    {
        action.started -= Pressed;
        action.canceled -= Released;
    }
    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        if (!isSDomino)     // line domino
        {
            DominoSpawner.SetActive(true);
        }
        else                // special domino
        {
            SpecialDominoSpawner.SetActive(true);
        }
    }

    private void Released(InputAction.CallbackContext context)
    {
        if (!isSDomino)     // line domino
        {
            DominoSpawner.SetActive(false);
        }
        else                // special domino
        {
            SpecialDominoSpawner.GetComponent<PlaceSpecialDomino>().placeSDomino();
            SpecialDominoSpawner.SetActive(false);
        }
    }

    public void updateIsSDomino(bool b)
    {
        isSDomino = b;
    }
}
