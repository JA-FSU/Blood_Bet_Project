using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiscardPile : MonoBehaviour
{
    public GameObject[] discardPile;

    public TextMeshProUGUI graveyardText;

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
        graveyardText.text = "Graveyard:\n";

        for (int i = 0; i < discardPile.Length; i++)
        {
            graveyardText.text += discardPile[i].name + "\n";
        }

        for (int i = 0; i < discardPile.Length; i++)
        {
            if (discardPile[i] != null)
            {
                Debug.Log("Card " + i + ": " + discardPile[i].name);
            }
        }
    }
}
