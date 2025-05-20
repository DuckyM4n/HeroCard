using Game.Card;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace Player
{
    public class PlayerCharacter : MonoBehaviour
    {
        [SerializeField]
        public string playerName;
        [SerializeField]
        private List<Card> graveyard;
        private List<Card> handcard;
        private List<Card> disk;
        private Dictionary<CardType, string> field;
        public int drawCardValue;
        public bool isTurn;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        
        public void DiscardCard(Card card)
        {
            graveyard.Add(card);
            var item = field.FirstOrDefault(pair => pair.Value == card.data.id);

            if (!item.Equals(default(KeyValuePair<int, string>)))
            {
                field.Remove(item.Key);
            }
            else
            {
                handcard.Remove(card);
            }
        }
        public void DrawCard()
        {
            if (disk.Count ==0)
                return;
            if (drawCardValue > disk.Count)
            {
                drawCardValue = disk.Count;
            }
            for(int i = 0; i< drawCardValue;i++)
            {
                handcard.Add(disk[i]);
            }    
            Debug.Log(playerName + " drew a card.");
        }
        public void EndTurn()
        {
            isTurn = false;
        }
    }

    public enum FieldDisk
    {
        None =0,
        FrontlineHero =1,
        BacklineSmith =2,
        FrontlineEquip =3,
        BacklineEquip =4,
    }
}
