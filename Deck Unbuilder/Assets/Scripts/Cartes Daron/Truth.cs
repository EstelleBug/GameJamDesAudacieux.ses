using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Truth : MonoBehaviour
{
    public TurnManager turnmanager;
    public TMP_Text dialogueText;


    private void Update()
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
            case 2:
                SetDialogueText(DaddyDialogues.Truth1);
                break;
            case 3:
                SetDialogueText(DaddyDialogues.Truth2);
                break;
            case 4:
                SetDialogueText(DaddyDialogues.Truth3);
                break;
            case 5:
                SetDialogueText(DaddyDialogues.Truth4);
                break;
            case 6:
                SetDialogueText(DaddyDialogues.Truth5);
                break;
            // Add more cases if needed
            default:
                SetDialogueText(DataDialogues.DefaultDialogContent);
                break;
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
}
