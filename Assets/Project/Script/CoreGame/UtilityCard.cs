using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    public class UtilityCard : Card
    {
        private EquipType equip;
        // Start is called before the first frame update
        protected override void Start()
        {

        }

        // Update is called once per frame
        protected override void Update()
        {

        }

        public EquipType GetEquip()
        {
            return equip;
        }    
    }

    public enum EquipType
    {
        None = 0,
        Weapon = 1,
        Armor = 2,
        Boot =3,
        LeftHand = 4
    }
}
