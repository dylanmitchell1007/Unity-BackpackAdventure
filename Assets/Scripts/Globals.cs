using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Globals
{
    public class OnLoad : UnityEvent
    {}

    public static OnLoad onLoad = new OnLoad();

}
