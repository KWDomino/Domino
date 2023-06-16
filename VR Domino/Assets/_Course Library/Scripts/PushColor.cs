using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ColorChange;

public class PushColor : MonoBehaviour
{
    /// <summary>
    ///   버튼을 누르면 해당 버튼의 색상을 PressPos으로 입력해주는 함수 
    /// </summary>
    public void ColorPusher()
    {
        ColorChange.image = gameObject.GetComponent<Image>();
        PressPos.color_domino = ColorChange.image.color;
        Debug.Log(gameObject.name);
    }
}
