using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    private static TurnManager _instance;
    public static TurnManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<TurnManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("TurnManager");
                    _instance = go.AddComponent<TurnManager>();
                }
            }
            return _instance;
        }
    }

    public List<GameObject> playerDeck;

    public List<GameObject> playerHand;
    public List<GameObject> npcHand;

    public GameControl gameControl;

    public TMP_Text dialogueText;

    private bool isNPCTurn;
    private bool isPlayerAllowToDrop;
    public int currentNPCIndex;

    private int indexDialogue;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

        isNPCTurn = true;
        currentNPCIndex = 0;
        ShowNextNPCCard();

        GameObject handGameObject = GameObject.Find("Hand");
        
        // Check if the parent game object is found
        if (handGameObject != null)
        {
            // Find all cards in the "Hand" game object and add them to the playerHand list
            Draggable[] cardsInHand = handGameObject.GetComponentsInChildren<Draggable>();
            foreach (Draggable card in cardsInHand)
            {
                playerHand.Add(card.gameObject);
            }
        }
        else
        {
            Debug.LogError("Parent game object with the name 'Hand' not found.");
        }
    }

    public void Restart()
    {
        isNPCTurn = true;
        currentNPCIndex = 0;
        ShowNextNPCCard();

        gameControl.HideGameOver();
    }

    void Update()
    {
        // Check for end of game condition

        if (isNPCTurn)
        {
            NPCTurn();
        }
        else
        {

            if (currentNPCIndex == npcHand.Count && gameControl.GetHealth() > 0f)
            {
                gameControl.Win();
            }
        }

    }

    public void PlayAgainCardPlayed()
    {
        indexDialogue = currentNPCIndex + 1;

    }
    public int GetIndexedDialogue()
    {
        return indexDialogue;

    }
    public bool IsPlayerAllowToDrop()
    {
        return isPlayerAllowToDrop;
    }

    public bool IsNPCTurn()
    {
        return isNPCTurn;
    }

    void NPCTurn()
    {
        ShowNextNPCCard();
    }

    void ShowNextNPCCard()
    {
        if (npcHand.Count > 0)
        {
            if (currentNPCIndex > 0 && npcHand[currentNPCIndex - 1] != null)
            {
                npcHand[currentNPCIndex - 1].gameObject.SetActive(false);
            }

            if (npcHand[currentNPCIndex] != null)
            {
                npcHand[currentNPCIndex].gameObject.SetActive(true);

                DisplayDialogueForCurrentNPC();

                currentNPCIndex = (currentNPCIndex + 1) % npcHand.Count;

                if (currentNPCIndex == 0)
                {
                    gameControl.Win();
                    return;
                }

                EndTurn();
            }
        }
    }

    void DisplayDialogueForCurrentNPC()
    {
        switch (currentNPCIndex)
        {
            case 0:
                SetDialogueText(DataDialogues.DialogElse0);
                break;
            case 1:
                SetDialogueText(DataDialogues.DialogElse1);
                break;
            case 2:
                SetDialogueText(DataDialogues.DialogElse2);
                break;
            case 3:
                SetDialogueText(DataDialogues.DialogElse3);
                break;
            case 4:
                SetDialogueText(DataDialogues.DialogElse4);
                break;
            case 5:
                SetDialogueText(DataDialogues.DialogElse5);
                break;
            case 6:
                SetDialogueText(DataDialogues.DialogElseGameOver);
                break;
            // Add more cases if needed
            default:
                SetDialogueText(DataDialogues.DefaultDialogContent);
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

    public void EndTurn()
    {
        isNPCTurn = !isNPCTurn;
    }
}