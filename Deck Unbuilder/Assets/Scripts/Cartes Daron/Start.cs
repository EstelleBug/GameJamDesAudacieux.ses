using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Start : MonoBehaviour
{
    public TurnManager turnmanager;
    public TMP_Text dialogueText;

    public void Update()
    {
            DisplayDialogueForCurrentPC();
    }

    void DisplayDialogueForCurrentPC()
    {
        switch (turnmanager.currentNPCIndex)
        {
            case 0:
                SetDialogueText(DaddyDialogues.Truth01);
                break;
            case 1:
                SetDialogueText(DaddyDialogues.Truth0);
                break;
        }
    }
    void SetDialogueText(string text)
    {
        if (dialogueText != null)
        {
            dialogueText.text = text;
        }
        else
        {
            Debug.LogError("DialogueText component not assigned.");
        }
    }
}
