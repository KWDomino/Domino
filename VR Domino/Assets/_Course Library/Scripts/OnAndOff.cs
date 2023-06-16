using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnAndOff : MonoBehaviour
{
    /// <summary>
    ///   UI 전환할때 버튼으로 끄고 키는거 가능하도록 설정
    /// </summary>
    private bool state;

    public GameObject Target;
    public Button button;
    
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        state = Target.activeSelf;

    }
    
    void TaskOnClick()
    {
        state = Target.activeSelf;

        if (state == true)
        {
            Target.SetActive(false);      
            state = false;
        }

        else
        {
            Target.SetActive(true);
            state = true;
        }
    }
}