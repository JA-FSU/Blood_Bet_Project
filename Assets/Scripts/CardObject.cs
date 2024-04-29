using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardTypes
{
    House,
    Creature,
    Spell
}

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

public class CardObject : ScriptableObject
{
    public CardTypes CardType;
    public string Name;
    public Sprite CardArt;
    public Suits Suit;
}

[CreateAssetMenu(fileName = "CardObject", menuName = "Create Card/Creature Card")]
public class CreateCreture : CardObject
{
    public int Bet;
    public int Rank;
    public int Power;
    public string CreatureType;
    public HandPower[] handPowers;
}

[CreateAssetMenu(fileName = "CardObject", menuName = "Create Card/House Card")]
public class CreateHouse : CardObject
{
    public int RoundCounters;
    public HandPower[] handPowers;
}

[CreateAssetMenu(fileName = "CardObject", menuName = "Create Card/Spell Card")]
public class CreateSpell : CardObject
{
    public HandPower[] handPowers;
}