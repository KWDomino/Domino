using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthChange : MonoBehaviour
{
    public Button btnUp;
    public Button btnDown;

    private Text textLen;

    
    void Start()
    {
        btnUp = btnUp.GetComponent<Button>();
        btnDown = btnDown.GetComponent<Button>();
        textLen = gameObject.GetComponent<Text>();

        btnUp.onClick.AddListener(ClickUp);
        btnDown.onClick.AddListener(ClickDown);
    }

    void ClickUp()
    {
        int len = int.Parse(textLen.text);
        len++;
        gameObject.GetComponent<TextMesh>().text = len.ToString();
    }

    void ClickDown()
    {
        int len = int.Parse(textLen.text);
        len--;
        gameObject.GetComponent<TextMesh>().text = len.ToString();
    }
}
