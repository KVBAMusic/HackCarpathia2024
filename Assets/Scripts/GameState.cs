public class GameState {
    public int Money;
    public int AirPollution;
    public int GroundPollution;
    public int Score;
    private GameState() {}

    public static GameState state;

    public void Reset() {
        Score = 0;
    }
}