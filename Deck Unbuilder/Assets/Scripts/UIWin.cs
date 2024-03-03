using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWin : MonoBehaviour
{
    [SerializeField] Button _btnExit;

    void Start()
    {
        _btnExit.onClick.AddListener(QuitGame);

    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
