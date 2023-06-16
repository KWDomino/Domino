using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnAndOff : MonoBehaviour
{
    /// <summary>
    ///   UI ��ȯ�Ҷ� ��ư���� ���� Ű�°� �����ϵ��� ����
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