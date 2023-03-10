using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class UIController : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreValue;
    [SerializeField] private Image healthBar;
    [SerializeField] private Image crossHair;
    [SerializeField] private OptionsPopup optionsPopup;
    [SerializeField] private SettingsPopup settingsPopup;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.fillAmount = 1;
        healthBar.color = Color.green;
        UpdateScore(score);
        SetGameActive(true);
    }
    
    public void SetGameActive(bool active)
    {
        if(active)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            crossHair.gameObject.SetActive(true);
        } else
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            crossHair.gameObject.SetActive(false);
        }
    }
    public void UpdateScore(int newScore)
    {
        scoreValue.text = newScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !optionsPopup.IsActive() && !settingsPopup.IsActive())
        {
            SetGameActive(false);
            optionsPopup.Open();
        }
    }
}
