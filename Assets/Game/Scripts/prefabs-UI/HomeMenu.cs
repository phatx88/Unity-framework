using Newtonsoft.Json;
using NFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Newtonsoft.Json;

public class HomeMenu : BaseUIView
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _soundButton;
    [SerializeField] private Button _saveButton;
    [SerializeField] private Button _winButton;
    //[SerializeField] private string _name;
    //[SerializeField] private string _JsonText;
    //[SerializeField] private Text _txtName;
    //[SerializeField] private Text _txtGender;
    //[SerializeField] private Text _txtAge;

    private Action _onOpen, _onClose;
    public override void OnOpen()
    {
        base.OnOpen();
        //Debug.Log("Vo home menu Open");
        _onOpen?.Invoke();
        ParseJson();
    }

    public override void OnClose()
    {
        base.OnClose();
        //Debug.Log("Vo home menu Close");
        _onClose?.Invoke();
    }

    public void Init(Action onOpen = null, Action onClose = null)
    {
        Debug.Log("Vo home menu Init");
        _onClose = onClose;
        _onOpen = onOpen;
    }
    private void Start()
    {
        _startButton.onClick.AddListener(OnStartButtonClick);
        _soundButton.onClick.AddListener(OnSoundButtonClick);
        _saveButton.onClick.AddListener(OnSaveButtonClick);
        _winButton.onClick.AddListener(OnWinButtonClick);

        //Start Music
        SoundManager.I.PlayMusicResource(Define.SoundName.MUSIC_BACKGROUND, true);
    }
    private void OnWinButtonClick()
    {
        //WinMatchData data = new WinMatchData();
        //data.Item = "Sword";
        //data.Xp = "15000Xp";
        //data.Score = "20";
        WinMatchData data = new WinMatchData()
        {
            Item = "Sword",
            Xp = "15000XP",
            Score = "20"
        };
        EventManager.TriggerEvent(EventType.WIN_MATCH, data);
        EventManager.TriggerEvent(EventType.JUMP, new JumpData());
    }
    private void OnStartButtonClick()
    {
        UIManager.I.Close(Define.UIName.HOME_MENU);
        UIManager.I.Open(Define.UIName.GAME_PLAY);
    }
    private void OnSoundButtonClick()
    {
        SoundManager.I.PlaySFXResource(Define.SoundName.ETFX_EXPLOSION_GAS);
        VibrationManager.I.Haptic(VibrationManager.EHapticType.RigidImpact);
    }
    private void OnSaveButtonClick()
    {
       // ShopManager.I.SetName(_name);
    }

    private void ParseJson()
    {
        //InfoUser infoUser = JsonConvert.DeserializeObject<InfoUser>(_JsonText);
        //_txtName.text = infoUser.name;
        //_txtGender.text = infoUser.gender;
        //_txtAge.text = infoUser.age.ToString();
    }

}

public class InfoUser
{
    public string name;
    public string gender;
    public int age;
}

