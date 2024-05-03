using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckList : MonoBehaviour
{
    public GameObject[] deckList; // Array stores deck list

    public void UpdateDeck()
    {
        // list whats in array in console
        for (int i = 0; i < deckList.Length; i++)
        {
            Debug.Log("Card " + i + ": " + deckList[i].name);
        }
    }
}
