using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStateUI : MonoBehaviour {
    public Slider airPollution;
    public Slider waterPollution;
    public Slider groundPollution;

    public Image airImg;
    public Image waterImg;
    public Image groundImg;

    public TMP_Text airText;
    public TMP_Text waterText;
    public TMP_Text groundText;
    public TMP_Text sumText;

    public Gradient gradient;
    public Gradient textGradient;

    void Update() {

        airText.text = GameState.State.AirPollution.ToString();
        waterText.text = GameState.State.WaterPollution.ToString();
        groundText.text = GameState.State.GroundPollution.ToString();
        sumText.text = (GameState.State.AirPollution + GameState.State.WaterPollution + GameState.State.GroundPollution).ToString();

        airText.color = textGradient.Evaluate(GameState.State.AirPollution / 100f);
        waterText.color = textGradient.Evaluate(GameState.State.WaterPollution / 100f);
        groundText.color = textGradient.Evaluate(GameState.State.GroundPollution / 100f);
        sumText.color = textGradient.Evaluate((GameState.State.AirPollution + GameState.State.WaterPollution + GameState.State.GroundPollution) / 200f);

        airPollution.value = GameState.State.AirPollution;
        waterPollution.value = GameState.State.WaterPollution;
        groundPollution.value = GameState.State.GroundPollution;

        airImg.color = gradient.Evaluate(GameState.State.AirPollution / 100f);
        waterImg.color = gradient.Evaluate(GameState.State.WaterPollution / 100f);
        groundImg.color = gradient.Evaluate(GameState.State.GroundPollution / 100f);
    }
}