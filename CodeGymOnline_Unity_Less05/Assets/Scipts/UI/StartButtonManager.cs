using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonManager : MonoBehaviour
{
    [SerializeField] private Button startButton;

    private void Start()
    {
        LoadStartButton();
        StartButtonOnClick();
    }
    void LoadStartButton()
    {
        if (startButton != null) return;
        startButton = GetComponent<Button>();
    }

    void StartButtonOnClick()
    {
        startButton.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(0);
       
    }

    
}
