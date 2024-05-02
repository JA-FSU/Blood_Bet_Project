using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shuffle : MonoBehaviour
{
    public DeckList deckList; // Reference the DeckList script where the array of GameObjects is stored

   

    public void ShuffleDeck()
    {
        // Get the deck array of GameObjects from the DeckList script
        GameObject[] deck = deckList.deckList;

        // Shuffle the deck using Fisher-Yates algorithm
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

        
    }

}