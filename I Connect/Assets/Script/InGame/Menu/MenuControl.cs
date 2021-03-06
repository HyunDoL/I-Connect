﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    [SerializeField]
    private float controlTime = 2f;

    [SerializeField]
    private Transform menuTrans;

    [SerializeField]
    private Transform openTrans;

    [SerializeField]
    private Transform closeTrans;

    private bool isOpen;

    private void Awake()
    {
        isOpen = false;

        AudioManager.Instance.DoMyBestPlay(AudioManager.AudioClipIndex.Quiet_Night_at_the_Shack);
    }

    public void Toggle()
    {
        if (!GameManager.Instance.IsCanTouch)
            return;

        InGameManager.Instance.isClickButton = true;

        if (isOpen)
            Close();

        else
            Open();

        isOpen = !isOpen;
    }

    public void Open()
    {
        StartCoroutine(Tween.TweenTransform.Position(menuTrans, openTrans.position, controlTime));
    }

    public void Close()
    {
        StartCoroutine(Tween.TweenTransform.Position(menuTrans, closeTrans.position, controlTime));
    }
}