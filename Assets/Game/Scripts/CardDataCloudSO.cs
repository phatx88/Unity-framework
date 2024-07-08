using NFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CardDataCloud
{
    public int CardId;
    public new string Name;
    public int Stars;
    public string Image;
    public string Description;
    public int Atk;
    public int HP;
}

[CreateAssetMenu(menuName = "ScriptableObject/CardDataCloudSO")]
public class CardDataCloudSO : GoogleSheetConfigSO<CardDataCloud>
{
    private Dictionary<int, CardDataCloud> cardDictionary;
    public Dictionary<int, CardDataCloud> Cards => cardDictionary;

    public void Init()
    {
        cardDictionary = new Dictionary<int, CardDataCloud>();

        foreach (var data in _datas)
        {
            cardDictionary[data.CardId] = data;
        }
    }

    public CardDataCloud GetCardData(int CardId) => cardDictionary[CardId];

#if UNITY_EDITOR
    protected override void OnSynced(List<CardDataCloud> googleSheetData)
    {
        base.OnSynced(googleSheetData);
    }
#endif
}
