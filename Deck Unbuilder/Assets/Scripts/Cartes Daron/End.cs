using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End : MonoBehaviour
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
            case 4:
                SetDialogueText(DaddyDialogues.End1);
                break;
            case 5:
                SetDialogueText(DaddyDialogues.End2);
                break;
            case 6:
                SetDialogueText(DaddyDialogues.End3);
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
