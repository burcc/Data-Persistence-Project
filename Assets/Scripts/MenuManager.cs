using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public string playerName;
    public InputField inputField;
    public Text HighScore;
    // Start is called before the first frame update
    void Start()
    {
        WinnerList.Instance.LoadWinnerData();
        HighScore.text = "Best Score: " + WinnerList.Instance.bestPlayer + ": " + WinnerList.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveName()
    {
        playerName = inputField.text;
        WinnerList.Instance.playerName = playerName;
    }
    public void StartMain()
    {
        SceneManager.LoadScene(1);

    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }
}
