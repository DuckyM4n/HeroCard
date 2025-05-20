using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Card
{
    public class TrapCard : Card
    {

    }

    public enum TrapType
    {
        None = 0,
        PlayerEffect = 1,
        EnemyEffect = 2,
        AllBoardEffect =3
    }
}
