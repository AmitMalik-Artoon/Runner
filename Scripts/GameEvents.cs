using System;

internal class GameEvents:Singleton<GameEvents>
{
    public Action OnObstaclePassed;
    public Action OnGameEnd;
}
