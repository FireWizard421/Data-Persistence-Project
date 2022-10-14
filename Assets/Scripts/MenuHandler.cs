using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void StartNew()
    {
        SceneManager.LoadScene(1);
        MainHandler.Instance.LoadScore();
    }

    public void Exit()
    {
        MainHandler.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SetName()
    {
        MainHandler.Instance.currentPlayerName = text.text;
    }

}
