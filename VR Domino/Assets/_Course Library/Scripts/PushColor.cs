using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ColorChange;

public class PushColor : MonoBehaviour
{
    /// <summary>
    ///   ��ư�� ������ �ش� ��ư�� ������ PressPos���� �Է����ִ� �Լ� 
    /// </summary>
    public void ColorPusher()
    {
        ColorChange.image = gameObject.GetComponent<Image>();
        PressPos.color_domino = ColorChange.image.color;
        Debug.Log(gameObject.name);
    }
}
