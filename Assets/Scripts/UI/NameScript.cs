using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    public InputField inputName;
    public Text errorMessage;
    public void Save()
    {
        string playerName = inputName.text;

        if(playerName.Length >= 2 && playerName.Length <= 10) 
        { 
            PlayerPrefs.SetString("Name", inputName.text);
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            errorMessage.text = "이름은 2~10 글자여야 합니다.";
        }
        
    }
}
