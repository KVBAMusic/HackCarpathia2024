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

    public Image airHandleImg;
    public Image waterHandleImg;
    public Image groundHandleImg;

    public TMP_Text airText;
    public TMP_Text waterText;
    public TMP_Text groundText;
    public TMP_Text sumText;
    public TMP_Text moneyText;
    public TMP_Text energyText;

    public Gradient gradient;
    public Gradient textGradient;

    void Update() {

        airText.text = GameState.State.AirPollution.ToString();
        waterText.text = GameState.State.WaterPollution.ToString();
        groundText.text = GameState.State.GroundPollution.ToString();
        sumText.text = (GameState.State.AirPollution + GameState.State.WaterPollution + GameState.State.GroundPollution).ToString();
        moneyText.text = GameState.State.Money.ToString();
        energyText.text = $"{GameState.State.Energy} (-{TileGrid.GetEnergyConsumption()})";

        sumText.color = textGradient.Evaluate((GameState.State.AirPollution + GameState.State.WaterPollution + GameState.State.GroundPollution) / 200f);

        airPollution.value = GameState.State.AirPollution;
        waterPollution.value = GameState.State.WaterPollution;
        groundPollution.value = GameState.State.GroundPollution;

        airImg.color = gradient.Evaluate(GameState.State.AirPollution / 100f);
        waterImg.color = gradient.Evaluate(GameState.State.WaterPollution / 100f);
        groundImg.color = gradient.Evaluate(GameState.State.GroundPollution / 100f);

        airHandleImg.color = gradient.Evaluate(GameState.State.AirPollution / 100f);
        waterHandleImg.color = gradient.Evaluate(GameState.State.WaterPollution / 100f);
        groundHandleImg.color = gradient.Evaluate(GameState.State.GroundPollution / 100f);
    }
}