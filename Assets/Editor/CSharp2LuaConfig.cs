using System.Collections.Generic;
using System;
using UnityEngine;
using XLua;
using FairyGUI;

[LuaCallCSharp]
[ReflectionUse]
public static class FairyGUIEventListenerExtension
{
    public static void Add0(this EventListener o, EventCallback0 callback)
    {
        o.Add(callback);
    }

    public static void Add1(this EventListener o, EventCallback1 callback)
    {
        o.Add(callback);
    }
}

/// <summary>  
/// Fariry导出XLua接口  
/// </summary>  
public static class FairyGUIToXLuaConfig
{
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
        (typeof(EventContext)),
        (typeof(EventDispatcher)),
        (typeof(EventListener)),
        (typeof(InputEvent)),
        (typeof(DisplayObject)),
        (typeof(Container)),
        (typeof(Stage)),
        (typeof(Controller)),
        (typeof(GObject)),
        (typeof(GGraph)),
        (typeof(GGroup)),
        (typeof(GImage)),
        (typeof(GLoader)),
        (typeof(PlayState)),
        (typeof(GMovieClip)),
        (typeof(TextFormat)),
        (typeof(GTextField)),
        (typeof(GRichTextField)),
        (typeof(GTextInput)),
        (typeof(GComponent)),
        (typeof(GList)),
        (typeof(GRoot)),
        (typeof(GLabel)),
        (typeof(GButton)),
        (typeof(GComboBox)),
        (typeof(GProgressBar)),
        (typeof(GSlider)),
        (typeof(PopupMenu)),
        (typeof(ScrollPane)),
        (typeof(Transition)),
        (typeof(UIPackage)),
        (typeof(Window)),
        (typeof(GObjectPool)),
        (typeof(Relations)),
        (typeof(RelationType)),
        (typeof(Timers)),
        (typeof(LuaUIHelper)),
        (typeof(GLuaComponent)),
        (typeof(GLuaLabel)),
        (typeof(GLuaButton)),
        (typeof(GLuaProgressBar)),
        (typeof(GLuaSlider)),
        (typeof(GLuaComboBox)),
        (typeof(LuaWindow)),
        (typeof(TweenUtils)),
        (typeof(TimerCallback)),
    };

    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>()
    {
        (typeof(EventCallback0)),
        (typeof(EventCallback1)),
        (typeof(System.Action)),
        (typeof(TimerCallback)),
    };
}