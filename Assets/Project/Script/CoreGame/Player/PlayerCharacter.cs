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
        public List<Card> graveyard;
        public List<Card> handcard;
        public List<Card> disk;
        public List<Card> field;
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
        public bool PlayCard(Card card)
        {
            if(handcard.Contains(card))
            {
                handcard.Remove(card);
                field.Add(card);
                return true;
            }
            return false;
        }    
        public void DiscardCard(Card card)
        {
            graveyard.Add(card);
            if (field.Contains(card))
            {
                field.Remove(card);
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
