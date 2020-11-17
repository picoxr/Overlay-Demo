using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PUIInPutModule : StandaloneInputModule
{
    void Awake()
    {
        m_InputOverride = GetComponent<BaseInput>();
    }


    public GameObject hoverObj
    {
        get
        {
            return GetCurrentFocusedGameObject();
        }
    }
}
