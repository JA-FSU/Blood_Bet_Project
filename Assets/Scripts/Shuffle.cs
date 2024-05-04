using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    public DeckList deckList;
    public DrawScript drawScript;
    public GameObject[] deck;

    public void ShuffleDeck()
    {
        //decklist array from the DeckList script
        deck = drawScript.currentDeck;

        // Fisher-Yates algorithm 
        System.Random rng = new System.Random();
        int n = deck.Length;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            GameObject value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }

        // update the  decklist
        deckList.UpdateDeck();
        drawScript.UpdateShuffledDeck();
    }
}