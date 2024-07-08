using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CardDataSO")]
public class CardDataSO : ScriptableObject
{

    public new string Name;
    public int Stars;
    public Sprite Sprite;
    public string Description;
    public int Atk;
    public int HP;
}


