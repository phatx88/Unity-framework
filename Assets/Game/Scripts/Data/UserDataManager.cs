using RotaryHeart.Lib.SerializableDictionary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NFramework;
using System;

public class UserDataManager : SingletonMono<UserDataManager>, ISaveable
{
    [SerializeField] private SaveData _saveData;

    public SaveData data => _saveData;

    public void SaveBooster(EnumDefine.BoosterType nameBooster, int amount)
    {
        _saveData.Boosters[nameBooster] = amount;
        DataChanged = true; // ra tin hieu de save 
    }

    public bool CheckLevelGreaterthan15()
    {
        return _saveData.level >= 15;
    }

    #region Isaveable

    [Serializable]
    public class SaveData
    {
        public string name;
        public int level;
        public SerializableDictionaryBase<EnumDefine.BoosterType, int> Boosters = new SerializableDictionaryBase<EnumDefine.BoosterType, int>();
    }
    public string SaveKey => "UserDataManager"; //dat key name UserDatamanager

    public bool DataChanged { get; set; }

    public object GetData() => _saveData;

    public void OnAllDataLoaded()
    {
        //Load xong va thuc hien gi do
    }

    public void SetData(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            SerializableDictionaryBase<EnumDefine.BoosterType, int> BoostersTemp = new SerializableDictionaryBase<EnumDefine.BoosterType, int>();
            BoostersTemp.Add(EnumDefine.BoosterType.Time, 10);
            BoostersTemp.Add(EnumDefine.BoosterType.Freeze, 10);
            BoostersTemp.Add(EnumDefine.BoosterType.Explosion, 10);
            BoostersTemp.Add(EnumDefine.BoosterType.Earthquake, 10);
            _saveData = new SaveData()
            {
                name = "Phat",
                level = 5,
                Boosters = BoostersTemp,
                
            };
        }
        else
        {
            _saveData = JsonUtility.FromJson<SaveData>(data);
        }
    }
    #endregion


}
