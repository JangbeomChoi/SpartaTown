using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{
    public Text nameText; 

    private Transform target; 

    private void Start()
    {
       
        string playerName = PlayerPrefs.GetString("Name");

        nameText.text = playerName;
     
    }

    
}