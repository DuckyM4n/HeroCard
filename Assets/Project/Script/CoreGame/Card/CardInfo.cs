using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    [CreateAssetMenu(fileName = "Card", menuName = "Card")]
    public class CardInfo : ScriptableObject
    {
        public string id;
        [SerializeField]
        private string cardName;
        [SerializeField]
        private Sprite image;
        public CardType type;
        public int damage;
        public int defense;
        public string description;
        public List<Card> require = new();
        // Start is called before the first frame update
    }

    public enum CardType
    {
        None = 0,
        Hero = 1,
        Utility = 2,
        Skill = 3,
        Trap = 4
    }
}
