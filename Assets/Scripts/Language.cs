using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Language : MonoBehaviour
{
    [Header("Menu")]
    public GameObject gameName;
    public GameObject start;
    public GameObject options;
    public GameObject quit;

    [Header("Options")]
    public GameObject resolution;
    public GameObject graphics;

    public GameObject qualityLow;
    public GameObject qualityMedium;
    public GameObject qualityHigh;
    
    public GameObject fullscreen;
    public GameObject language;
    public GameObject volume;
    public GameObject backMainMenu;

    [Header("Game")]
    public GameObject continueBtn;
    public GameObject backMenuBtn;

    public Dropdown lDropdown;
    public Dropdown mDropdown;

    public void Start()
    {
        lDropdown.onValueChanged.AddListener(delegate
        {
            Change(lDropdown);
        });
    }

    private void English()
    {
        continueBtn.GetComponent<TextMeshProUGUI>().text = "Continue";
        backMenuBtn.GetComponent<TextMeshProUGUI>().text = "Back to Main Menu";
        gameName.GetComponent<TextMeshProUGUI>().text = "PongUZ";
        start.GetComponent<TextMeshProUGUI>().text = "Start Game";
        options.GetComponent<TextMeshProUGUI>().text = "Options";
        quit.GetComponent<TextMeshProUGUI>().text = "Quit";
        resolution.GetComponent<TextMeshProUGUI>().text = "Resolution:";
        graphics.GetComponent<TextMeshProUGUI>().text = "Graphics:";
        fullscreen.GetComponent<TextMeshProUGUI>().text = "Fullscreen:";
        language.GetComponent<TextMeshProUGUI>().text = "Language:";
        volume.GetComponent<TextMeshProUGUI>().text = "Volume:";
        backMainMenu.GetComponent<TextMeshProUGUI>().text = "Back to main menu";
        mDropdown.options[0].text = "VERY LOW";
        mDropdown.options[1].text = "LOW";
        mDropdown.options[2].text = "MEDIUM";
        mDropdown.options[3].text = "HIGH";
        mDropdown.options[4].text = "VERY HIGH";
        mDropdown.options[5].text = "ULTRA";
        mDropdown.RefreshShownValue();
    }

    private void Polski()
    {
        continueBtn.GetComponent<TextMeshProUGUI>().text = "Kontynuuj";
        backMenuBtn.GetComponent<TextMeshProUGUI>().text = "Wróć do głownego menu";
        gameName.GetComponent<TextMeshProUGUI>().text = "PongUZ";
        start.GetComponent<TextMeshProUGUI>().text = "Rozpocznij grę";
        options.GetComponent<TextMeshProUGUI>().text = "Opcje";
        quit.GetComponent<TextMeshProUGUI>().text = "Wyjdź";
        resolution.GetComponent<TextMeshProUGUI>().text = "Rozdzielczość:";
        graphics.GetComponent<TextMeshProUGUI>().text = "Grafika:";
        fullscreen.GetComponent<TextMeshProUGUI>().text = "Pełny ekran:";
        language.GetComponent<TextMeshProUGUI>().text = "Język:";
        volume.GetComponent<TextMeshProUGUI>().text = "Głośność:";
        backMainMenu.GetComponent<TextMeshProUGUI>().text = "Wróć do głownego menu";
        mDropdown.options[0].text = "BARDZO NISKIE";
        mDropdown.options[1].text = "NISKIE";
        mDropdown.options[2].text = "ŚREDNIE";
        mDropdown.options[3].text = "WYSOKIE";
        mDropdown.options[4].text = "BARDZO WYSOKIE";
        mDropdown.options[5].text = "ULTRA";
        mDropdown.RefreshShownValue();
    }

    public void Change(Dropdown sender)
    {
        Debug.Log(sender.value);
        if(sender.value == 0) English();
        else if(sender.value == 1) Polski();
    }
}
