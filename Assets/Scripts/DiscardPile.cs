using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    public GameObject[] discardPile; 

    public void AddToDiscardPile(GameObject card)
    {
        
        for (int i = 0; i < discardPile.Length; i++)
        {
            if (discardPile[i] == null)
            {
                discardPile[i] = card;
                break;
            }
        }

        
        UpdateDiscard();
    }

    public void UpdateDiscard()
    {
        
        for (int i = 0; i < discardPile.Length; i++)
        {
            if (discardPile[i] != null)
            {
                Debug.Log("Card " + i + ": " + discardPile[i].name);
            }
        }
    }
}
