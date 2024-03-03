using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public List<Card> playerDeck;
    public List<Card> npcDeck;

    private List<Card> playerHand;
    private List<Card> npcHand;

    private bool isNPCTurn;

    void Start()
    {
        playerHand = new List<Card>();
        npcHand = new List<Card>();

        // Draw initial hands
        //DrawInitialHand(playerHand, playerDeck);
        //DrawInitialHand(npcHand, npcDeck);

        // Start with NPC's turn
        isNPCTurn = true;
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
            PlayerTurn();
        }
    }

    void PlayerTurn()
    {
        // Implement player's turn logic here

        // EPlayer drops a card
    }

    void NPCTurn()
    {
        // Implement NPC's turn logic here

        // NPC shows card + 1
    }

    void PlayCard(List<Card> hand, List<Card> deck)
    {
        if (hand.Count > 0)
        {
            // Play the first card in hand (you can modify this logic based on your game rules)
            Card cardToPlay = hand[0];

            // Perform actions based on the played card

            // Move the card to a discard pile or remove it from play
            // (you'll need to implement these functions based on your game design)

            // End the turn
            EndTurn();
        }
    }

    void EndTurn()
    {
        isNPCTurn = !isNPCTurn;
    }

    /*void DrawInitialHand(List<Card> hand, List<Card> deck)
    {
        int initialHandSize = 3;

        for (int i = 0; i < initialHandSize; i++)
        {
            DrawCard(hand, deck);
        }
    }*/
}
