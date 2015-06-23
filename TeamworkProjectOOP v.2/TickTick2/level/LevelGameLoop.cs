﻿using Microsoft.Xna.Framework;

partial class Level : GameObjectList
{
    public override void HandleInput(InputHelper inputHelper)
    {
        base.HandleInput(inputHelper);
        if (!quitButton.Pressed)
            return;
        this.Reset();
        GameEnvironment.GameStateManager.SwitchTo("levelMenu");
    }
}
