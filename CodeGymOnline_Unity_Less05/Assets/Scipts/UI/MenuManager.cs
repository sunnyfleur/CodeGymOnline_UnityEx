using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : Singleton<MenuManager>   
{
    public void SceneChanging(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
