using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPopup : MonoBehaviour
{
    [SerializeField] private UIController uiCont;
    [SerializeField] private SettingsPopup settingsPopup;
    public void Open() {
        gameObject.SetActive(true);
    }
    public void Close() {
        gameObject.SetActive(false);
    }
    public bool IsActive() {
        return gameObject.activeSelf;
    }
    public void OnSettingsButton() {
        Debug.Log("Settings Clicked!");
        settingsPopup.gameObject.SetActive(true);
        Close();
    }
    public void OnExitGameButton() {
        Debug.Log("Exit game");
        Application.Quit();
    }
    public void OnReturnToGameButton() {
        Debug.Log("return to game");
        uiCont.SetGameActive(true);
        Close();
    }
}
