using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class Card : MonoBehaviour
    {
        public CardInfo data;
        [HideInInspector]
        public int attackDamage;
        [HideInInspector]
        public int defense;
        [HideInInspector]
        public CardType type;
        // Start is called before the first frame update
        protected virtual void Start()
        {
            attackDamage = data.damage;
            defense = data.defense;
            type = data.type;
        }

        // Update is called once per frame
        protected virtual void Update()
        {

        }
        public virtual void DoEffect(Card target)
        {

        }

        public virtual void DestroyCard()
        {
            Destroy(this);
        }
    }
}
