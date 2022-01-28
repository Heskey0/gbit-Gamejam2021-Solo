using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using QFramework.Example;
using UnityEngine;

public class Setup : MonoBehaviour
{
    private void Awake()
    {
        ResKit.Init();
        UIKit.OpenPanel<SetupPanel>();
    }
}
