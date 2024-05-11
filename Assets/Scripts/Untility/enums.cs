public enum SkillButtonType
{
    Empty,
    Move,
    Attack,
    Skill
}

public enum Team
{
    Red, Blue
}

public enum Direction
{
    Up, Down, Left, Right
}

public enum GameState
{
    LoadPlayerInGame,
    ActionState,
    FightState,
    FightEnd,
}