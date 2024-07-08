using NFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : SingletonMono<MainManager>
{
   
    private void Start()
    {
        //UIManager.I.Open(Define.UINamme.HOME_MENU); // ko ep kieu
        UIManager.I.Open<HomeMenu>(Define.UIName.HOME_MENU).Init(OnOpenHomeMenu, OnCloseHomeMenu); // ep kieu
        InitSaveData();
    }

    private void OnOpenHomeMenu()
    {
        Debug.Log("Vo OnOpenHomeMenu");
    }
    private void OnCloseHomeMenu()
    {
        Debug.Log("Vo OnCloseHomeMenu");
    }
    private void InitSaveData()
    {
        //SaveManager.I.RegisterSaveData(SoundManager.I);
        SaveManager.I.RegisterSaveData(VibrationManager.I);
        SaveManager.I.RegisterSaveData(UserDataManager.I);
        SaveManager.I.Load();
    }
}
