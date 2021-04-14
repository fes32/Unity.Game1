using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _infoButton;
    [SerializeField] private InfoPanel _infoPanel;

    private int _gameSceneIndex=1;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _infoButton.onClick.AddListener(OnInfoButtonClick);
        _infoPanel.Closed += OnInfoPanelClosed;
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
        _infoButton.onClick.RemoveListener(OnInfoButtonClick);
        _infoPanel.Closed -= OnInfoPanelClosed;
    }

    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene(_gameSceneIndex);
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }

    private void OnInfoButtonClick()
    {
        _infoPanel.Activate();
        ButtonsOff();
    }

    private void OnInfoPanelClosed()
    {
        ButtonsOn();
    }

    private void ButtonsOff()
    {
        _playButton.gameObject.SetActive(false);
        _exitButton.gameObject.SetActive(false);
        _infoButton.gameObject.SetActive(false);
    }

    private void ButtonsOn()
    {
        _playButton.gameObject.SetActive(true);
        _exitButton.gameObject.SetActive(true);
        _infoButton.gameObject.SetActive(true);
    }
}