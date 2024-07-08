using NFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EventType;

public class UserProfile : MonoBehaviour
{
    public void OnEnable()
    {
        EventManager.Register(EventType.WIN_MATCH, UpdateLevel);  //neu co register thi phai viet them ham huy dang ky de khong bi loi null
    }

    private void OnDisable()
    {
        EventManager.Unregister(EventType.WIN_MATCH, UpdateLevel);
    }

    private void UpdateLevel(BaseEventData baseEventData)
    {
        var data = baseEventData as WinMatchData;
        Debug.Log("Da update Level : +" + data.Xp);
    }

}
