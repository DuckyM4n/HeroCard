using Game.Card;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class GameManager : MonoBehaviour
    {
        public PlayerCharacter player1;
        public PlayerCharacter player2;
        private PlayerCharacter currentPlayer;
        // Start is called before the first frame update
        void Start()
        {
            player1 = new PlayerCharacter { playerName = "Player 1" };
            player2 = new PlayerCharacter { playerName = "Player 2" };

            StartTurn(player1);
        }
        void StartTurn(PlayerCharacter player)
        {
            currentPlayer = player;
            currentPlayer.isTurn = true;

            Debug.Log("It's " + currentPlayer.playerName + "'s turn!");
            currentPlayer.DrawCard();
        }

        public void EndTurn()
        {
            currentPlayer.EndTurn();
            StartTurn(currentPlayer == player1 ? player2 : player1);
        }
    }
}
