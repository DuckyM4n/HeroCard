using Game.Card;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        public static GameManager Get() { Get(); return instance; }
        public PlayerCharacter player1;
        public PlayerCharacter player2;
        private PlayerCharacter currentPlayer;
        public Transform handZone;
        public GameObject cardButtonPrefab;
        // Start is called before the first frame update
        private void Awake()
        {
            instance = this;
        }
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
        public void OnCardClicked(Card card)
        {
            if (currentPlayer.PlayCard(card))
            {
                UpdateHandUI();
            }
        }
        void UpdateHandUI()
        {
            foreach (Transform child in handZone)
                Destroy(child.gameObject);

            foreach (var card in currentPlayer.handcard)
            {
                GameObject btn = Instantiate(cardButtonPrefab, handZone);
                btn.GetComponent<CardButtonUI>().Init(card);
            }
        }
        public void EndTurn()
        {
            currentPlayer.EndTurn();
            StartTurn(currentPlayer == player1 ? player2 : player1);
        }
    }
}
