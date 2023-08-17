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

    private void ChangeState(GameState newState)
    {
        currentGameState = newState;

        if (currentGameState == GameState.Play) return;
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
