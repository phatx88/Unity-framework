using NFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EventType;

public class ScoreManager : MonoBehaviour
{
    public void OnEnable()
    {
        EventManager.Register(EventType.WIN_MATCH, AddScore);  //neu co register thi phai viet them ham huy dang ky de khong bi loi null
    }

    private void OnDisable()
    {
        EventManager.Unregister(EventType.WIN_MATCH, AddScore);
    }

    private void AddScore(BaseEventData baseEventData)
    {
        var data = baseEventData as WinMatchData;
        Debug.Log("Da Add Score : +" + data.Score);
    }
}
