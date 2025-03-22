using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIPanelGame : MonoBehaviour,IMenu
{
    public Text LevelConditionView;

    [SerializeField] private Button btnPause;

    [SerializeField] private Button btnRestart;

    private UIMainManager m_mngr;


    private void Awake()
    {
        btnPause.onClick.AddListener(OnClickPause);
        btnRestart.onClick.AddListener(OnClickRestart);
    }

    private void OnClickPause()
    {
        m_mngr.ShowPauseMenu();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void OnClickRestart()
    {
        if(m_mngr.m_gameManager.State == GameManager.eStateGame.GAME_STARTED)
        {
            m_mngr.m_gameManager.ClearLevel();
            if (m_mngr.m_gameManager.currentMode == GameManager.eLevelMode.MOVES)
            {
                m_mngr.m_gameManager.LoadLevel(GameManager.eLevelMode.MOVES);
            }
            else
            {
                m_mngr.m_gameManager.LoadLevel(GameManager.eLevelMode.TIMER);
            }
        }
    }

}
