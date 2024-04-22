using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Suits
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum Hand
{
    Pair,
    Straight,
    FullHouse
}

[System.Serializable]
public class HandPower
{
    public Hand Hand;
    public string HandDescription;
}

[CreateAssetMenu(fileName="CardObject", menuName = "Create Card/Creature Card")]
public class CardObject : ScriptableObject
{
    public string Name;
    public Sprite CreatureArt;
    public Suits Suit;
    public int Bet;
    public int Rank;
    public int Power;
    public string CreatureType;
    public HandPower[] handPowers;
}