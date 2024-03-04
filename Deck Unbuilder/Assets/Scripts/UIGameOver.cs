using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] Button _btnRestart;
    public GameOverScreen GameOverScreen;
    public GameControl gameControl;

    void Start()
    {
        _btnRestart.onClick.AddListener(RestartGame);

    }

    private void RestartGame()
    {
        gameControl.RestartGame();
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
