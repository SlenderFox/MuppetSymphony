﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpash : MonoBehaviour
{
    public GameObject m_goSplashScreen;
    public GameObject m_goBackground;
    public GameObject m_goMenuPanel;

    private void Awake()
    {
        Invoke("HideSplash", 2.0f);
    }

    public void HideSplash()
    {
        m_goSplashScreen.SetActive(false);
        m_goBackground.SetActive(false);
        m_goMenuPanel.SetActive(true);
    }
}
