using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    public class HeroCard : Card
    {
        public CardInfo nextLevel;
        public CardType counterType;
        public CardInfo counterEquip;
        private List<Card> equipment;
        private Card weapon;
        private Card armor;
        private Card boot;
        private Card leftHand;
        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        protected override void Update()
        {

        }

        public override void AttackCard(HeroCard target)
        {
            int attackPoint = attackDamage;
            if (target.type == counterType)
                attackPoint = attackPoint * 85 / 100;
            else if (type == target.counterType)
                attackPoint = attackPoint * 115 / 100;
            if (attackPoint >= target.defense)
                target.DestroyCard();
            else
                target.TakeDamage(attackPoint);
        }

        public void TakeDamage(int damage)
        {
            defense -= damage;
        }
        public void Equip(UtilityCard equip)
        {
            switch(equip.GetEquip())
            {
                case EquipType.Weapon:
                    ChangeEquip(equip, weapon);
                    break;

                case EquipType.Armor:
                    ChangeEquip(equip, armor);
                    break;

                case EquipType.Boot:
                    ChangeEquip(equip, boot);
                    break;
                case EquipType.LeftHand:
                    ChangeEquip(equip, leftHand);
                    break;
                default:
                    Debug.Log("Unknown");
                    break;
            }
            attackDamage += equip.attackDamage;
            defense += equip.defense;
        }

        public void ChangeEquip(Card equip, Card pos)
        {
            if(pos == null)
            {
                equipment.Add(equip);
                pos = equip;
                return;
            }    
            int index = equipment.IndexOf(pos);
            equipment[index] = equip;
            attackDamage -= pos.attackDamage;
            defense -= pos.defense;
            pos = equip;
        }
    }
    
    public enum HeroType
    {
        None = 0,
        Knight = 1,
        Berserker = 2,
        Archer = 3,
        Assansin = 4,
        Mage = 5
    }
}
