using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NFramework;
using UnityEngine.UI;
using Unity.VisualScripting;
public class GamePlay : BaseUIView
{
    [SerializeField] private Text Name;
    [SerializeField] private Text Level;
    [SerializeField] private Button btnTime;
    [SerializeField] private Button btnFreeze;
    [SerializeField] private Button btnExplosion;
    [SerializeField] private Button btnEarthQuake;
    [SerializeField] private Text amountTimeText;   
    [SerializeField] private Text amountFreezeText;   
    [SerializeField] private Text amountExplosionText;   
    [SerializeField] private Text amountEarthQuakeText;

    private int amountTime;
    private int amountFreeze;
    private int amountExplosion;
    private int amountEarthQuake;

    public override void OnOpen()
    {
        base.OnOpen();

        InitData();

        btnTime.onClick.AddListener(UseBoosterTime);
    }

    private void UseBoosterTime()
    {

        amountTime--;
        amountTimeText.text = amountTime.ToString();

        UserDataManager.I.SaveBooster(EnumDefine.BoosterType.Time, amountTime);

    }

    private void InitData()
    {
        Name.text = UserDataManager.I.data.name; 
        Level.text = UserDataManager.I.data.level.ToString();

        amountTime = UserDataManager.I.data.Boosters[EnumDefine.BoosterType.Time];
        amountTimeText.text = amountTime.ToString();

        amountFreeze = UserDataManager.I.data.Boosters[EnumDefine.BoosterType.Freeze];
        amountFreezeText.text = amountFreeze.ToString();

        amountExplosion = UserDataManager.I.data.Boosters[EnumDefine.BoosterType.Explosion];
        amountExplosionText.text = amountExplosion.ToString();

        amountEarthQuake = UserDataManager.I.data.Boosters[EnumDefine.BoosterType.Earthquake];
        amountEarthQuakeText.text = amountEarthQuake.ToString();
    }
}
