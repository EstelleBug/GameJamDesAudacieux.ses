using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] Button _btnRestart;
    public GameOverScreen GameOverScreen;

    void Start()
    {
        _btnRestart.onClick.AddListener(RestartGame);

    }

    private void RestartGame()
    {
        GameOverScreen.HideGameOver();
        //Add card changed to deck
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
