using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private bool isNPCTurn;
    private bool isPlayerAllowToDrop;
    private int currentNPCIndex;

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

    void Update()
    {
        // Check for end of game condition

        if (isNPCTurn)
        {
            NPCTurn();
        }
        else 
        {
            if( playerHand.Count == 2)
            {
                isPlayerAllowToDrop = true;
            }
            isPlayerAllowToDrop = false;
        }

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
            if (currentNPCIndex > 0)
            {
                npcHand[currentNPCIndex - 1].gameObject.SetActive(false);
            }

            npcHand[currentNPCIndex].gameObject.SetActive(true);

            currentNPCIndex = (currentNPCIndex + 1) % npcHand.Count;

            EndTurn();
        }
    }

    public void EndTurn()
    {
        isNPCTurn = !isNPCTurn;
    }
}