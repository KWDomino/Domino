using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    public abstract void primaryButton();
    public abstract void secondaryButton();
}

public class NormalDominoState : GameState
{
    public override void primaryButton()
    {
        throw new System.NotImplementedException();
    }

    public override void secondaryButton()
    {
        throw new System.NotImplementedException();
    }
}

public class SpecialDominoState : GameState
{
    public override void primaryButton()
    {
        throw new System.NotImplementedException();
    }

    public override void secondaryButton()
    {
        throw new System.NotImplementedException();
    }
}

public class ColorDominoState : GameState
{
    public override void primaryButton()
    {
        throw new System.NotImplementedException();
    }

    public override void secondaryButton()
    {
        throw new System.NotImplementedException();
    }
}

public class GameCotroller : MonoBehaviour
{
    void Update()
    {
        
    }
}
