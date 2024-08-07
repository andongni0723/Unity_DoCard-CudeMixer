public enum SkillButtonType
{
    Empty,
    Move,
    Attack,
    Skill
}

public enum SkillUseCondition
{
    Power,
    Count
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
    FightEndState,
}