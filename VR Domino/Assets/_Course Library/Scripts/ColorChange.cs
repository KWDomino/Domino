using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    /// <summary>
    ///   �Է¹��� image�� ������ ���� object�� �������� �Է�
    /// </summary>
    
    // You can reference this in the inspector by dragging a gameobject which has this component to it.
    public static Image image;

    public void ColorChanger()
    {
        gameObject.GetComponent<Image>().color = image.color;
        Debug.Log(gameObject.name);
    }
}
