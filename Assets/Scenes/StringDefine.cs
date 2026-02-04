using System.Collections;
using System.Collections.Generic;
using Bm.Drawer;
using UnityEngine;


[ConstValueContent]
public class GameStringDefine
{
    public const string Game_Begin = "Game_Begin";
    public const string Game_Play = "Game_Play";
    public const string Game_End = "Game_End";
    
    public const int Game_PlayerSpeed = 10;
    public const int Game_PlayerAttack = 100;
    public const int Game_PlayerHp = 800;
}


[ConstValueContent]
public class UIDefine
{
    public const int UI_Game = 0;
    public const int UI_Win = 1;
    public const int UI_Fail = 2;
    
    public const string UI_Title = "UI_Title";
    public const string UI_Button = "UI_Button";
    public const string UI_Slider = "UI_Slider";
}

public partial class HandIds
{
    public const int UI_Game = 0;
    public const int UI_Win = 1;
    public const int UI_Fail = 2;
}