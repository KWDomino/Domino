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
    }
    
    void TaskOnClick()
    {
        state = Target.activeSelf;

        Target.SetActive(!state);
        state = !state;
    }
}