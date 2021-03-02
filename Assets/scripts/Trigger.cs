using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public manager gmanager;
    void onTriggerenter()
    {
        gmanager.Completelevel();
    }
}
