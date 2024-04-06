public class GameState {
    public int Energy;
    public int AirPollution;
    public int GroundPollution;
    public int WaterPollution;
    public int Score;
    private GameState() {}

    private static GameState _state;
    public static GameState State {
        get {
            _state ??= new();
            return _state;
        }
    }

    public void Reset() {
        Score = 0;
    }

    public void Advance() {
        float oldEnergy = Energy;
        TileGrid.AdvanceAll();
        if (Energy < 0) {
            GameOver("You ran out of energy.\nResponsible sourcing of energy can lead to a sustainable future.");
            return;
        }
        if (AirPollution > 100 || WaterPollution > 100 || GroundPollution > 100 || AirPollution + WaterPollution + GroundPollution > 200) {
            GameOver("You polluted the environment.\nEnergy sector is responsible for over 60% of greenhouse gas emissions globally. Consider switching to sustainable sources of energy.");
            return;
        }
        if (AirPollution < 0) {
            AirPollution = 0;
        }
        if (WaterPollution < 0) {
            WaterPollution = 0;
        }
        if (GroundPollution < 0) {
            GroundPollution = 0;
        }
    }

    public void GameOver(string message) {

    }

}