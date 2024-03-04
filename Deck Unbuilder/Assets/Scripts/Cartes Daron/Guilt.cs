using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Guilt : MonoBehaviour
{
    public TurnManager turnmanager;
    public TMP_Text dialogueText;


    private void Update()
    {
        DisplayDialogueForCurrentPC();
    }
    // Update is called once per frame
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
                SetDialogueText(DaddyDialogues.Guilt1);
                break;
            case 3:
                SetDialogueText(DaddyDialogues.Guilt2);
                break;
            case 4:
                SetDialogueText(DaddyDialogues.Guilt3);
                break;
            case 5:
                SetDialogueText(DaddyDialogues.Guilt4);
                break;
            case 6:
                SetDialogueText(DaddyDialogues.Guilt5);
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
