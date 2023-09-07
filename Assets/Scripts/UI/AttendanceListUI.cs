using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendanceListUI : MonoBehaviour
{
    public GameObject attendancePanel; 
    public Text attendanceText; 
    public Button refreshButton; // 목록을 새로고침할 버튼
    public Button closeButton; // UI를 닫을 버튼

    
    private List<string> attendeeNames = new List<string>();

    private bool isUIVisible = false;

    private void Start()
    {
        // UI 초기 상태 설정
        attendancePanel.SetActive(false);
        attendanceText.gameObject.SetActive(false);

        // 버튼 클릭 이벤트에 대한 리스너 추가
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