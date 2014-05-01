﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Land.Enums
{
    public enum SpriteTypeEnum
    {
        Space = 0,
        StoneWall = 10,
        BrickWall = 20,
        StairsLeft = 30,
        StairsRight = 31,
        Biomass1 = 41,
        Biomass2 = 42,
        Biomass3 = 43,
        Biomass4 = 44,
        Floor = 5,
        Chest = 6,
        ExitDoorLeft = 71,
        ExitDoorRight =72,

        Delimiter = 500,
        ScoreLabel = 510,
        RangeLabel = 520,
        AttemptsLabel = 530,
        StageLabel = 540,
        Splash = 1000,
        YourRangeLabel = 1010,
        HeroIdle = 2000,
        HeroIdleLeft = 2001,
        HeroIdleRight = 2002,
        HeroStairsLeft = 2010,
        HeroStairsRight = 2012,
        HeroMoveLeft1 = 2030,
        HeroMoveLeft2 = 2031,
        HeroMoveLeft3 = 2032,
        HeroMoveLeft4 = 2033,
        HeroMoveRight1 = 2034,
        HeroMoveRight2 = 2035,
        HeroMoveRight3 = 2036,
        HeroMoveRight4 = 2037,
        HeroInBiomass1 = 2040,
        HeroInBiomass2 = 2041,
        HeroInBiomass3 = 2042,
        HeroPrepareShotLeft = 2050,
        HeroPrepareShotRight = 2051,
        HeroShotLeft = 2052,
        HeroShotRight = 2053,
        Bullet = 3000,
        WallLive1 = 4000,
        WallLive2 = 4001,
        WallLive3 = 4002,
        DevilStairsLeft = 5000,
        DevilStairsRight = 5001,
        DevilMoveLeft1 = 5010,
        DevilMoveLeft2 = 5011,
        DevilMoveLeft3 = 5012,
        DevilMoveLeft4 = 5013,
        DevilMoveLeft5 = 5014,
        DevilMoveRight1 = 5020,
        DevilMoveRight2 = 5021,
        DevilMoveRight3 = 5022,
        DevilMoveRight4 = 5023,
        DevilMoveRight5 = 5024,
    }
}
