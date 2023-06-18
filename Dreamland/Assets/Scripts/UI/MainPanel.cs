﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    private Button btn_Start;
    private Button btn_Shop;
    private Button btn_Rank;
    private Button btn_Sound;
    private Button btn_Reset;
    private void Awake()
    {
        Init();
    }
    private void OnDestroy()
    {

    }
    private void Show()
    {
        gameObject.SetActive(true);
    }
    /// <summary>
    /// 皮肤更换，这里更换UI皮肤图片
    /// </summary>
    /// <param name="skinIndex"></param>
    private void ChangeSkin(int skinIndex)
    {

    }
    private void Start()
    {

    }
    private void Init()
    {
        btn_Start = transform.Find("btn_Start").GetComponent<Button>();
        btn_Start.onClick.AddListener(OnStartButtonClick);
        btn_Shop = transform.Find("Btns/btn_Shop").GetComponent<Button>();
        btn_Shop.onClick.AddListener(OnShopButtonClick);
        btn_Rank = transform.Find("Btns/btn_Rank").GetComponent<Button>();
        btn_Rank.onClick.AddListener(OnRankButtonClick);
        btn_Sound = transform.Find("Btns/btn_Sound").GetComponent<Button>();
        btn_Sound.onClick.AddListener(OnSoundButtonClick);
        btn_Reset = transform.Find("Btns/btn_Reset").GetComponent<Button>();
        btn_Reset.onClick.AddListener(OnResetButtonClick);
    }
    /// <summary>
    /// 开始按钮点击后调用此方法
    /// </summary>
    private void OnStartButtonClick()
    {
        EventCenter.Broadcast(EventDefine.ShowGamePanel);
        gameObject.SetActive(false);
    }
    /// <summary>
    /// 商店按钮点击
    /// </summary>
    private void OnShopButtonClick()
    {

    }
    /// <summary>
    /// 排行榜按钮点击
    /// </summary>
    private void OnRankButtonClick()
    {

    }
    /// <summary>
    /// 音效按钮点击
    /// </summary>
    private void OnSoundButtonClick()
    {

    }
    private void Sound()
    {

    }
    /// <summary>
    /// 重置按钮点击
    /// </summary>
    private void OnResetButtonClick()
    {

    }
}
