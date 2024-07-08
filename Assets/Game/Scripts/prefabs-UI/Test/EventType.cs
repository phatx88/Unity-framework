using NFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventType 
{
    public const string WIN_MATCH = "Win Match";

    //moi su kien EventType nen tao mot class contructor rieng de chua data

    public const string JUMP = "Jump";
    
}

public class WinMatchData : BaseEventData
{
    public string Item;
    public string Xp;
    public string Score;
}

public class JumpData : BaseEventData
{

}
