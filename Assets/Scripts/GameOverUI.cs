using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class GameOverUI : MonoBehaviour {
    public Image bg;
    public TMP_Text gameOverText;
    public TMP_Text messageText;
    public Button restartButton;
    public Button menuButton;
    public GameObject mainUI;
    public AudioSource gameOverSfx;

    public static Action<string> OnGameOver;

    void Awake() {
        OnGameOver += ShowGameOverScreen;
        ResetScreens();
    }

    void ResetScreens() {
        bg.CrossFadeAlpha(0, 0, true);
        gameOverText.CrossFadeAlpha(0, 0, true);
        messageText.CrossFadeAlpha(0, 0, true);
        MainMenu.CrossFadeAlphaButton(restartButton, 1, 0, 0, true);
        MainMenu.CrossFadeAlphaButton(menuButton, 1, 0, 0, true);

        bg.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        messageText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
    }

    void OnDisable() {
        OnGameOver -= ShowGameOverScreen;
    }

    public void ShowGameOverScreen(string msg) {
        bg.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        messageText.gameObject.SetActive(true);
        mainUI.SetActive(false);
        messageText.text = msg;
        gameOverSfx.Play();

        bg.CrossFadeAlpha(1, 1.5f, true);
        gameOverText.CrossFadeAlpha(1, 1.5f, true);
        messageText.CrossFadeAlpha(1, 1.5f, true);

        Invoke("ShowGameOverScreen2", 1);
    }

    private void ShowGameOverScreen2() {
        restartButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        MainMenu.CrossFadeAlphaButton(restartButton, 0, 1, 1.5f, true);
        MainMenu.CrossFadeAlphaButton(menuButton, 0, 1, 1.5f, true);
    }

    public void RestartGame() {
        TileGrid.ClearAll();
        GameState.State.Reset();
        ResetScreens();
        mainUI.SetActive(true);
    }

    public void BackToMenu() {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}