using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    mainMenu,
    isGame,
    pause,
    gameOver
}
public class Less03 : MonoBehaviour
{
    private GameState currentState;
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.mainMenu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckGameState()
    {
        if (currentState == GameState.mainMenu) { }

        else if(currentState == GameState.pause) { }
        else if(currentState == GameState.gameOver) { }
        else if(currentState == GameState.mainMenu) { }

    }
}
