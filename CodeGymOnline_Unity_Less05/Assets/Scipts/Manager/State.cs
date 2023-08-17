using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Play,
    GameOver
}
public class State : Singleton<State>
{
    public GameState currentGameState = GameState.Play;

    private void Update()
    {
        CheckState();
    }
    private void CheckState()
    {
        if (currentGameState == GameState.GameOver)
        {
            HandleGameOver();
            currentGameState = GameState.Play;            
        }
        if (currentGameState == GameState.Play) return;
    }
    public void ChangeState(GameState newState)
    {
        currentGameState = newState;
    }
    private void HandlePlaying()
    {

    }
    private void HandleGameOver()
    {
        ResetScene();
    }

    public void ResetScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }



}
