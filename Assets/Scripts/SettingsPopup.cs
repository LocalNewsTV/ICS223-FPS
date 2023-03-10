using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    [SerializeField] private OptionsPopup optionsPopup;
    [SerializeField] private TextMeshProUGUI difficultyLabel;
    [SerializeField] private Slider difficultySlider;
    private void Start()
    {
        difficultySlider.value = PlayerPrefs.GetInt("difficulty", 1);
        UpdateDifficulty(difficultySlider.value);
    }
    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        optionsPopup.Open();
        gameObject.SetActive(false);
        optionsPopup.gameObject.SetActive(true);
    }
    public bool IsActive()
    {
        return gameObject.activeSelf;
    }
    public void OnSettingsCancel()
    {
        difficultySlider.value = PlayerPrefs.GetInt("difficulty", 1);
        UpdateDifficulty(difficultySlider.value);
        Close();
    }
    public void OnSettingsOK()
    {
        PlayerPrefs.SetInt("difficulty", (int)difficultySlider.value);
        Close();
    }
    public void UpdateDifficulty(float difficulty)
    {
        difficultyLabel.text = difficulty.ToString();
    }
    public void OnDifficultyValueChanges(float difficulty)
    {
        UpdateDifficulty(difficulty);
    }
}
