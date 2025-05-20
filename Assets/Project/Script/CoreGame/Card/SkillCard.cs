using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class SkillCard : Card
    {
        protected override void Start()
        {

        }

        // Update is called once per frame
        protected override void Update()
        {

        }
    }

    public enum EffectType
    {
        None = 0,
        Attack = 1,
        Defense = 2,
        Buff = 3
    }
}    
