using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{


    public string playerName;
    public Text inputName;
    public Text displayHighScore;

    // Start is called before the first frame update
    void Start()
    {
        displayHighScore.text = "High Score: " + (GameMan.Instance.highScore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetName()
    {
        playerName = inputName.text; 
        GameMan.Instance.nameOfPlayer = playerName;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);

    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); //original code to quite Unity player
#endif
    }
}
