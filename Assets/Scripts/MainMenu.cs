using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public TMP_Text title;
    public Button playBtn, settingsBtn, quitBtn;

    void CrossFadeAlphaButton(Button button, float initAlpha, float alpha, float duration, bool ignoreTimeScale) {
        TMP_Text btnText = button.transform.GetChild(0).GetComponent<TMP_Text>();
        button.targetGraphic.CrossFadeAlpha(initAlpha, 0, true);
        btnText.CrossFadeAlpha(initAlpha, 0, true);
        button.targetGraphic.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
        btnText.CrossFadeAlpha(alpha, duration, ignoreTimeScale);
    }

    void Start() {
        title.CrossFadeAlpha(0, 0, false);
        title.CrossFadeAlpha(1, 1.5f, false);
        CrossFadeAlphaButton(playBtn, 0, 1, 1.5f, false);
        CrossFadeAlphaButton(settingsBtn, 0, 1, 1.5f, false);
        CrossFadeAlphaButton(quitBtn, 0, 1, 1.5f, false);
    }
    public void Play() {
        playBtn.interactable = false;
        settingsBtn.interactable = false;
        quitBtn.interactable = false;
        title.CrossFadeAlpha(0, 1.5f, false);
        CrossFadeAlphaButton(playBtn, 1, 0, 1.5f, false);
        CrossFadeAlphaButton(settingsBtn, 1, 0, 1.5f, false);
        CrossFadeAlphaButton(quitBtn, 1, 0, 1.5f, false);
        Invoke("SwitchScene", 3);
    }

    private void SwitchScene() {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Quit() {
        Application.Quit();
    }
}
