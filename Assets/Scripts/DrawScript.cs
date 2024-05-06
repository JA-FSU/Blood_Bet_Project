using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawScript : MonoBehaviour
{
    public DeckList deckList;
    public int drawAmount;
    private Shuffle shuffledDeck;

    public List<GameObject> currentHand;
    public GameObject[] currentDeck;
    public List<GameObject> currentDeckList;

    public TextMeshProUGUI handText;

    // Start is called before the first frame update
    void Start()
    {
        currentDeck = deckList.deckList;
        shuffledDeck = GameObject.Find("shuffletest").GetComponent<Shuffle>();

        for (int i = 0; i < currentDeck.Length; i++)
        {
            currentDeckList.Add(currentDeck[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDeck.Length >= 5)
        {
            drawAmount = 5;
        }
        else
        {
            drawAmount = (int)currentDeckList.Count;
        }
    }

    public void DrawHand()
    {
        if (currentDeckList.Count > 0)
        {
            for (int i = drawAmount; i > 0; i--)
            {
                currentHand.Add(currentDeckList[0]);
                currentDeckList.RemoveAt(0);
            }

            UpdateHandText();
        }
    }

    public void DrawCard()
    {
        if (currentDeckList.Count > 0)
        {
            currentHand.Add(currentDeckList[0]);
            currentDeckList.RemoveAt(0);

            UpdateHandText();
        }
    }

    public void UpdateShuffledDeck()
    {
        currentDeck = shuffledDeck.deck;
        currentDeckList.Clear();
        for (int i = 0; i < currentDeck.Length; i++)
        {
            currentDeckList.Add(currentDeck[i]);
        }
    }

    private void UpdateHandText()
    {
        handText.text = "Hand:\n";

        for (int i = 0; i < currentHand.Count; i++)
        {
            handText.text += currentHand[i].name+"\n";
        }
    }
}
