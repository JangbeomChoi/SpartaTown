using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendanceListUI : MonoBehaviour
{
    public GameObject attendancePanel; 
    public Text attendanceText; 
    public Button refreshButton; // ����� ���ΰ�ħ�� ��ư
    public Button closeButton; // UI�� ���� ��ư

    
    private List<string> attendeeNames = new List<string>();

    private bool isUIVisible = false;

    private void Start()
    {
        // UI �ʱ� ���� ����
        attendancePanel.SetActive(false);
        attendanceText.gameObject.SetActive(false);

        // ��ư Ŭ�� �̺�Ʈ�� ���� ������ �߰�
        refreshButton.onClick.AddListener(RefreshAttendanceList);
        closeButton.onClick.AddListener(ToggleUIVisibility);

        string playerName = PlayerPrefs.GetString("Name");

        if (!string.IsNullOrEmpty(playerName))
        {
            attendeeNames.Add(playerName);
        }

        

        RefreshAttendanceList();
    }


    private void Update()
    {
       
    }

    private void ToggleUIVisibility()
    {
        
        isUIVisible = !isUIVisible;
        attendancePanel.SetActive(isUIVisible);
        attendanceText.gameObject.SetActive(isUIVisible);
    }

    private void RefreshAttendanceList()
    {

        string attendanceList = string.Join("\n", attendeeNames);
        attendanceText.text = attendanceList;

        attendanceText.gameObject.SetActive(true);
    }
}