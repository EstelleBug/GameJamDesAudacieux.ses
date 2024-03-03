using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] Button _btnPlay;
    [SerializeField] Button _btnExit;

    void Start()
    {
        _btnPlay.onClick.AddListener(StartNewGame);
        _btnExit.onClick.AddListener(QuitGame);

    }

    private void StartNewGame()
    {
        ScenesManager.instance.LoadNewGame();
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
