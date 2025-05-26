using Game.Card;
using Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardButtonUI : MonoBehaviour
{
    public Image cardImage;
    public TextMeshProUGUI cardName;
    private CardInfo card;

    public void Init(Card cardData)
    {
        card = cardData.data;
        cardImage.sprite = card.image;
        cardName.text = card.cardName;
    }

    public void OnClick(Card cardData)
    {
        GameManager.Get().OnCardClicked(cardData);
    }
}
