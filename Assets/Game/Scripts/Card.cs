using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{

    [Header("Card Data")]
    [SerializeField] private CardDataSO cardData;

    [Header("Content UI")]
    [SerializeField] private Text Name;
    [SerializeField] private Text Stars;
    [SerializeField] private Image Image;
    [SerializeField] private Text Description;
    [SerializeField] private Text Atk_HP;

    private void Start()
    {
        InitData();
    }
    private void InitData()
    {
        Name.text = cardData.Name;
        Stars.text = new string('*', cardData.Stars);
        Image.sprite = cardData.Sprite;
        Description.text = cardData.Description;
        Atk_HP.text = "Atk:" + cardData.Atk + "/HP:" + cardData.HP; 

    }
}


