using NFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TestData
{

}

[CreateAssetMenu(menuName = "ScriptableObject/TestSO")]
public class TestSO : GoogleSheetConfigSO<TestData>
{
   
}
