using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//public class Suits
//{

//}

[CreateAssetMenu(fileName="CardObject", menuName = "Create Card/Creature Card")]
public class CardObject : ScriptableObject
{
    public string Name;
    //public Image CreatureArt
    //public Suits Suit;
    public int Bet;
    public int Rank;
    public int Power;
    public string Description;
    public string CreatureType;
}
