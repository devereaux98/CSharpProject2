public class GameState
{
    public enum GameStates {Start, Play, Walk, Fight, Help, End}
    public GameStates currentGameState = GameStates.Start;
}