using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    /// <summary>
    ///   입력받은 image의 색상을 현재 object에 색상으로 입력
    /// </summary>
    
    // You can reference this in the inspector by dragging a gameobject which has this component to it.
    public static Image image;

    public void ColorChanger()
    {
        gameObject.GetComponent<Image>().color = image.color;
        Debug.Log(gameObject.name);
    }
}
