using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class LSInput
{

    /// <summary>
    /// Contains all the data for a keyboard.
    /// </summary>
    [System.Serializable]
    public class Keyboard
    {
        public bool active;

        public bool getAnyKey() { return UnityEngine.Input.anyKey; }
        public bool getAnyKeyDown() { return UnityEngine.Input.anyKeyDown; }

        public bool getEscape() { return UnityEngine.Input.GetKey(KeyCode.Escape); }
        public bool getEscapeDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Escape); }
        public bool getEscapeUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Escape); }

        public bool getBackquote() { return UnityEngine.Input.GetKey(KeyCode.BackQuote); }
        public bool getBackquoteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.BackQuote); }
        public bool getBackquoteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.BackQuote); }

        public bool getAlpha1() { return UnityEngine.Input.GetKey(KeyCode.Alpha1); }
        public bool getAlpha1Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha1); }
        public bool getAlpha1Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha1); }

        public bool getAlpha2() { return UnityEngine.Input.GetKey(KeyCode.Alpha2); }
        public bool getAlpha2Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha2); }
        public bool getAlpha2Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha2); }

        public bool getAlpha3() { return UnityEngine.Input.GetKey(KeyCode.Alpha3); }
        public bool getAlpha3Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha3); }
        public bool getAlpha3Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha3); }

        public bool getAlpha4() { return UnityEngine.Input.GetKey(KeyCode.Alpha4); }
        public bool getAlpha4Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha4); }
        public bool getAlpha4Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha4); }

        public bool getAlpha5() { return UnityEngine.Input.GetKey(KeyCode.Alpha5); }
        public bool getAlpha5Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha5); }
        public bool getAlpha5Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha5); }

        public bool getAlpha6() { return UnityEngine.Input.GetKey(KeyCode.Alpha6); }
        public bool getAlpha6Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha6); }
        public bool getAlpha6Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha6); }

        public bool getAlpha7() { return UnityEngine.Input.GetKey(KeyCode.Alpha7); }
        public bool getAlpha7Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha7); }
        public bool getAlpha7Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha7); }

        public bool getAlpha8() { return UnityEngine.Input.GetKey(KeyCode.Alpha8); }
        public bool getAlpha8Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha8); }
        public bool getAlpha8Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha8); }

        public bool getAlpha9() { return UnityEngine.Input.GetKey(KeyCode.Alpha9); }
        public bool getAlpha9Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha9); }
        public bool getAlpha9Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha9); }

        public bool getAlpha0() { return UnityEngine.Input.GetKey(KeyCode.Alpha0); }
        public bool getAlpha0Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha0); }
        public bool getAlpha0Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha0); }

        public bool getMinus() { return UnityEngine.Input.GetKey(KeyCode.Minus); }
        public bool getMinusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Minus); }
        public bool getMinusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Minus); }

        public bool getEquals() { return UnityEngine.Input.GetKey(KeyCode.Equals); }
        public bool getEqualsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Equals); }
        public bool getEqualsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Equals); }

        public bool getBackspace() { return UnityEngine.Input.GetKey(KeyCode.Backspace); }
        public bool getBackspaceDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Backspace); }
        public bool getBackspaceUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Backspace); }

        //

        public bool getTab() { return UnityEngine.Input.GetKey(KeyCode.Tab); }
        public bool getTabDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Tab); }
        public bool getTabUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Tab); }

        public bool getQ() { return UnityEngine.Input.GetKey(KeyCode.Q); }
        public bool getQDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Q); }
        public bool getQUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Q); }

        public bool getW() { return UnityEngine.Input.GetKey(KeyCode.W); }
        public bool getWDown() { return UnityEngine.Input.GetKeyDown(KeyCode.W); }
        public bool getWUp() { return UnityEngine.Input.GetKeyUp(KeyCode.W); }

        public bool getE() { return UnityEngine.Input.GetKey(KeyCode.E); }
        public bool getEDown() { return UnityEngine.Input.GetKeyDown(KeyCode.E); }
        public bool getEUp() { return UnityEngine.Input.GetKeyUp(KeyCode.E); }

        public bool getR() { return UnityEngine.Input.GetKey(KeyCode.R); }
        public bool getRDown() { return UnityEngine.Input.GetKeyDown(KeyCode.R); }
        public bool getRUp() { return UnityEngine.Input.GetKeyUp(KeyCode.R); }

        public bool getT() { return UnityEngine.Input.GetKey(KeyCode.T); }
        public bool getTDown() { return UnityEngine.Input.GetKeyDown(KeyCode.T); }
        public bool getTUp() { return UnityEngine.Input.GetKeyUp(KeyCode.T); }

        public bool getY() { return UnityEngine.Input.GetKey(KeyCode.Y); }
        public bool getYDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Y); }
        public bool getYUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Y); }

        public bool getU() { return UnityEngine.Input.GetKey(KeyCode.U); }
        public bool getUDown() { return UnityEngine.Input.GetKeyDown(KeyCode.U); }
        public bool getUUp() { return UnityEngine.Input.GetKeyUp(KeyCode.U); }

        public bool getI() { return UnityEngine.Input.GetKey(KeyCode.I); }
        public bool getIDown() { return UnityEngine.Input.GetKeyDown(KeyCode.I); }
        public bool getIUp() { return UnityEngine.Input.GetKeyUp(KeyCode.I); }

        public bool getO() { return UnityEngine.Input.GetKey(KeyCode.O); }
        public bool getODown() { return UnityEngine.Input.GetKeyDown(KeyCode.O); }
        public bool getOUp() { return UnityEngine.Input.GetKeyUp(KeyCode.O); }

        public bool getP() { return UnityEngine.Input.GetKey(KeyCode.P); }
        public bool getPDown() { return UnityEngine.Input.GetKeyDown(KeyCode.P); }
        public bool getPUp() { return UnityEngine.Input.GetKeyUp(KeyCode.P); }

        public bool getLeftBracket() { return UnityEngine.Input.GetKey(KeyCode.LeftBracket); }
        public bool getLeftBracketDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftBracket); }
        public bool getLeftBracketUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftBracket); }

        public bool getRightBracket() { return UnityEngine.Input.GetKey(KeyCode.RightBracket); }
        public bool getRightBracketDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightBracket); }
        public bool getRightBracketUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightBracket); }

        public bool getBackslash() { return UnityEngine.Input.GetKey(KeyCode.Backslash); }
        public bool getBackslashDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Backslash); }
        public bool getBackslashUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Backslash); }

        //

        public bool getCapsLock() { return UnityEngine.Input.GetKey(KeyCode.CapsLock); }
        public bool getCapsLockDown() { return UnityEngine.Input.GetKeyDown(KeyCode.CapsLock); }
        public bool getCapsLockUp() { return UnityEngine.Input.GetKeyUp(KeyCode.CapsLock); }

        public bool getA() { return UnityEngine.Input.GetKey(KeyCode.A); }
        public bool getADown() { return UnityEngine.Input.GetKeyDown(KeyCode.A); }
        public bool getAUp() { return UnityEngine.Input.GetKeyUp(KeyCode.A); }

        public bool getS() { return UnityEngine.Input.GetKey(KeyCode.S); }
        public bool getSDown() { return UnityEngine.Input.GetKeyDown(KeyCode.S); }
        public bool getSUp() { return UnityEngine.Input.GetKeyUp(KeyCode.S); }

        public bool getD() { return UnityEngine.Input.GetKey(KeyCode.D); }
        public bool getDDown() { return UnityEngine.Input.GetKeyDown(KeyCode.D); }
        public bool getDUp() { return UnityEngine.Input.GetKeyUp(KeyCode.D); }

        public bool getF() { return UnityEngine.Input.GetKey(KeyCode.F); }
        public bool getFDown() { return UnityEngine.Input.GetKeyDown(KeyCode.F); }
        public bool getFUp() { return UnityEngine.Input.GetKeyUp(KeyCode.F); }

        public bool getG() { return UnityEngine.Input.GetKey(KeyCode.G); }
        public bool getGDown() { return UnityEngine.Input.GetKeyDown(KeyCode.G); }
        public bool getGUp() { return UnityEngine.Input.GetKeyUp(KeyCode.G); }

        public bool getH() { return UnityEngine.Input.GetKey(KeyCode.H); }
        public bool getHDown() { return UnityEngine.Input.GetKeyDown(KeyCode.H); }
        public bool getHUp() { return UnityEngine.Input.GetKeyUp(KeyCode.H); }

        public bool getJ() { return UnityEngine.Input.GetKey(KeyCode.J); }
        public bool getJDown() { return UnityEngine.Input.GetKeyDown(KeyCode.J); }
        public bool getJUp() { return UnityEngine.Input.GetKeyUp(KeyCode.J); }

        public bool getK() { return UnityEngine.Input.GetKey(KeyCode.K); }
        public bool getKDown() { return UnityEngine.Input.GetKeyDown(KeyCode.K); }
        public bool getKUp() { return UnityEngine.Input.GetKeyUp(KeyCode.K); }

        public bool getL() { return UnityEngine.Input.GetKey(KeyCode.L); }
        public bool getLDown() { return UnityEngine.Input.GetKeyDown(KeyCode.L); }
        public bool getLUp() { return UnityEngine.Input.GetKeyUp(KeyCode.L); }

        public bool getSemicolon() { return UnityEngine.Input.GetKey(KeyCode.Semicolon); }
        public bool getSemicolonDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Semicolon); }
        public bool getSemicolonUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Semicolon); }

        public bool getQuote() { return UnityEngine.Input.GetKey(KeyCode.Quote); }
        public bool getQuoteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Quote); }
        public bool getQuoteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Quote); }

        public bool getReturn() { return UnityEngine.Input.GetKey(KeyCode.Return); }
        public bool getReturnDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Return); }
        public bool getReturnUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Return); }

        //

        public bool getLeftShift() { return UnityEngine.Input.GetKey(KeyCode.LeftShift); }
        public bool getLeftShiftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftShift); }
        public bool getLeftShiftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftShift); }

        public bool getZ() { return UnityEngine.Input.GetKey(KeyCode.Z); }
        public bool getZDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Z); }
        public bool getZUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Z); }

        public bool getX() { return UnityEngine.Input.GetKey(KeyCode.X); }
        public bool getXDown() { return UnityEngine.Input.GetKeyDown(KeyCode.X); }
        public bool getXUp() { return UnityEngine.Input.GetKeyUp(KeyCode.X); }

        public bool getC() { return UnityEngine.Input.GetKey(KeyCode.C); }
        public bool getCDown() { return UnityEngine.Input.GetKeyDown(KeyCode.C); }
        public bool getCUp() { return UnityEngine.Input.GetKeyUp(KeyCode.C); }

        public bool getV() { return UnityEngine.Input.GetKey(KeyCode.V); }
        public bool getVDown() { return UnityEngine.Input.GetKeyDown(KeyCode.V); }
        public bool getVUp() { return UnityEngine.Input.GetKeyUp(KeyCode.V); }

        public bool getB() { return UnityEngine.Input.GetKey(KeyCode.B); }
        public bool getBDown() { return UnityEngine.Input.GetKeyDown(KeyCode.B); }
        public bool getBUp() { return UnityEngine.Input.GetKeyUp(KeyCode.B); }

        public bool getN() { return UnityEngine.Input.GetKey(KeyCode.N); }
        public bool getNDown() { return UnityEngine.Input.GetKeyDown(KeyCode.N); }
        public bool getNUp() { return UnityEngine.Input.GetKeyUp(KeyCode.N); }

        public bool getM() { return UnityEngine.Input.GetKey(KeyCode.M); }
        public bool getMDown() { return UnityEngine.Input.GetKeyDown(KeyCode.M); }
        public bool getMUp() { return UnityEngine.Input.GetKeyUp(KeyCode.M); }

        public bool getComma() { return UnityEngine.Input.GetKey(KeyCode.Comma); }
        public bool getCommaDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Comma); }
        public bool getCommaUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Comma); }

        public bool getPeriod() { return UnityEngine.Input.GetKey(KeyCode.Period); }
        public bool getPeriodDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Period); }
        public bool getPeriodUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Period); }

        public bool getSlash() { return UnityEngine.Input.GetKey(KeyCode.Slash); }
        public bool getSlashDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Slash); }
        public bool getSlashUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Slash); }

        public bool getRightShift() { return UnityEngine.Input.GetKey(KeyCode.RightShift); }
        public bool getRightShiftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightShift); }
        public bool getRightShiftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightShift); }

        //

        public bool getLeftCtrl() { return UnityEngine.Input.GetKey(KeyCode.LeftControl); }
        public bool getLeftCtrlDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftControl); }
        public bool getLeftCtrlUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftControl); }

        public bool getLeftWindows() { return UnityEngine.Input.GetKey(KeyCode.LeftWindows); }
        public bool getLeftWindowsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftWindows); }
        public bool getLeftWindowsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftWindows); }

        public bool getLeftAlt() { return UnityEngine.Input.GetKey(KeyCode.LeftAlt); }
        public bool getLeftAltDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftAlt); }
        public bool getLeftAltUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftAlt); }

        public bool getSpace() { return UnityEngine.Input.GetKey(KeyCode.Space); }
        public bool getSpaceDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Space); }
        public bool getSpaceUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Space); }

        public bool getRightAlt() { return UnityEngine.Input.GetKey(KeyCode.RightAlt); }
        public bool getRightAltDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightAlt); }
        public bool getRightAltUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightAlt); }

        public bool getRightWindows() { return UnityEngine.Input.GetKey(KeyCode.RightWindows); }
        public bool getRightWindowsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightWindows); }
        public bool getRightWindowsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightWindows); }

        public bool getContext() { return UnityEngine.Input.GetKey(KeyCode.Menu); }
        public bool getContextDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Menu); }
        public bool getContextUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Menu); }

        public bool getRightCtrl() { return UnityEngine.Input.GetKey(KeyCode.RightControl); }
        public bool getRightCtrlDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightControl); }
        public bool getRightCtrlUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightControl); }

        //

        public bool getLeft() { return UnityEngine.Input.GetKey(KeyCode.LeftArrow); }
        public bool getLeftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftArrow); }
        public bool getLeftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftArrow); }

        public bool getRight() { return UnityEngine.Input.GetKey(KeyCode.RightArrow); }
        public bool getRightDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightArrow); }
        public bool getRightUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightArrow); }

        public bool getUp() { return UnityEngine.Input.GetKey(KeyCode.UpArrow); }
        public bool getUpDown() { return UnityEngine.Input.GetKeyDown(KeyCode.UpArrow); }
        public bool getUpUp() { return UnityEngine.Input.GetKeyUp(KeyCode.UpArrow); }

        public bool getDown() { return UnityEngine.Input.GetKey(KeyCode.DownArrow); }
        public bool getDownDown() { return UnityEngine.Input.GetKeyDown(KeyCode.DownArrow); }
        public bool getDownUp() { return UnityEngine.Input.GetKeyUp(KeyCode.DownArrow); }

        //

        public bool getInsert() { return UnityEngine.Input.GetKey(KeyCode.Insert); }
        public bool getInsertDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Insert); }
        public bool getInsertUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Insert); }

        public bool getHome() { return UnityEngine.Input.GetKey(KeyCode.Home); }
        public bool getHomeDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Home); }
        public bool getHomeUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Home); }

        public bool getPageUp() { return UnityEngine.Input.GetKey(KeyCode.PageUp); }
        public bool getPageUpDown() { return UnityEngine.Input.GetKeyDown(KeyCode.PageUp); }
        public bool getPageUpUp() { return UnityEngine.Input.GetKeyUp(KeyCode.PageUp); }

        public bool getDelete() { return UnityEngine.Input.GetKey(KeyCode.Delete); }
        public bool getDeleteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Delete); }
        public bool getDeleteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Delete); }

        public bool getEnd() { return UnityEngine.Input.GetKey(KeyCode.End); }
        public bool getEndDown() { return UnityEngine.Input.GetKeyDown(KeyCode.End); }
        public bool getEndUp() { return UnityEngine.Input.GetKeyUp(KeyCode.End); }

        public bool getPageDown() { return UnityEngine.Input.GetKey(KeyCode.PageDown); }
        public bool getPageDownDown() { return UnityEngine.Input.GetKeyDown(KeyCode.PageDown); }
        public bool getPageDownUp() { return UnityEngine.Input.GetKeyUp(KeyCode.PageDown); }

        //

        public bool getNumlock() { return UnityEngine.Input.GetKey(KeyCode.Numlock); }
        public bool getNumlockDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Numlock); }
        public bool getNumlockUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Numlock); }

        public bool getKeypadDivide() { return UnityEngine.Input.GetKey(KeyCode.KeypadDivide); }
        public bool getKeypadDivideDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadDivide); }
        public bool getKeypadDivideUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadDivide); }

        public bool getKeypadMultiply() { return UnityEngine.Input.GetKey(KeyCode.KeypadMultiply); }
        public bool getKeypadMultiplyDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadMultiply); }
        public bool getKeypadMultiplyUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadMultiply); }

        public bool getKeypadMinus() { return UnityEngine.Input.GetKey(KeyCode.KeypadMinus); }
        public bool getKeypadMinusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadMinus); }
        public bool getKeypadMinusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadMinus); }

        public bool getKeypadPlus() { return UnityEngine.Input.GetKey(KeyCode.KeypadPlus); }
        public bool getKeypadPlusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadPlus); }
        public bool getKeypadPlusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadPlus); }

        public bool getKeypadEnter() { return UnityEngine.Input.GetKey(KeyCode.KeypadEnter); }
        public bool getKeypadEnterDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadEnter); }
        public bool getKeypadEnterUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadEnter); }

        public bool getKeypadPeriod() { return UnityEngine.Input.GetKey(KeyCode.KeypadPeriod); }
        public bool getKeypadPeriodDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadPeriod); }
        public bool getKeypadPeriodUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadPeriod); }

        public bool getKeypad0() { return UnityEngine.Input.GetKey(KeyCode.Keypad0); }
        public bool getKeypad0Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad0); }
        public bool getKeypad0Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad0); }

        public bool getKeypad1() { return UnityEngine.Input.GetKey(KeyCode.Keypad1); }
        public bool getKeypad1Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad1); }
        public bool getKeypad1Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad1); }

        public bool getKeypad2() { return UnityEngine.Input.GetKey(KeyCode.Keypad2); }
        public bool getKeypad2Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad2); }
        public bool getKeypad2Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad2); }

        public bool getKeypad3() { return UnityEngine.Input.GetKey(KeyCode.Keypad3); }
        public bool getKeypad3Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad3); }
        public bool getKeypad3Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad3); }

        public bool getKeypad4() { return UnityEngine.Input.GetKey(KeyCode.Keypad4); }
        public bool getKeypad4Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad4); }
        public bool getKeypad4Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad4); }

        public bool getKeypad5() { return UnityEngine.Input.GetKey(KeyCode.Keypad5); }
        public bool getKeypad5Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad5); }
        public bool getKeypad5Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad5); }

        public bool getKeypad6() { return UnityEngine.Input.GetKey(KeyCode.Keypad6); }
        public bool getKeypad6Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad6); }
        public bool getKeypad6Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad6); }

        public bool getKeypad7() { return UnityEngine.Input.GetKey(KeyCode.Keypad7); }
        public bool getKeypad7Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad7); }
        public bool getKeypad7Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad7); }

        public bool getKeypad8() { return UnityEngine.Input.GetKey(KeyCode.Keypad8); }
        public bool getKeypad8Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad8); }
        public bool getKeypad8Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad8); }

        public bool getKeypad9() { return UnityEngine.Input.GetKey(KeyCode.Keypad9); }
        public bool getKeypad9Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad9); }
        public bool getKeypad9Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad9); }
    }
    /// <summary>
    /// Contains all the data for the keyboard.
    /// </summary>
    public Keyboard keyboard = new Keyboard();

    /// <summary>
    /// Contains all the data for a mouse.
    /// </summary>
    [System.Serializable]
    public class Mouse
    {
        /// <summary>
        /// If the mouse is active or not.
        /// </summary>
        public bool active;

        /// <summary>
        /// The mouses' position on the screen.
        /// </summary>
        public Vector2 position;

        [HideInInspector]
        public float scroll;
        /// <summary>
        /// Get if mouse is scrolling up.
        /// </summary>
        public bool getScrollUp() { return scroll > 0f; }
        /// <summary>
        /// Get if mouse is scrolling down.
        /// </summary>
        public bool getScrollDown() { return scroll < 0f; }

        /// <summary>
        /// Detect if left mouse button.
        /// </summary>
        public bool getL() { return UnityEngine.Input.GetMouseButton(0); }
        /// <summary>
        /// Detect if left mouse button is down.
        /// </summary>
        public bool getLDown() { return UnityEngine.Input.GetMouseButtonDown(0); }
        /// <summary>
        /// Detect if left mouse button is up.
        /// </summary>
        public bool getLUp() { return UnityEngine.Input.GetMouseButtonUp(0); }

        /// <summary>
        /// Detect if center mouse button.
        /// </summary>
        public bool getC() { return UnityEngine.Input.GetMouseButton(2); }
        /// <summary>
        /// Detect if center mouse button is down.
        /// </summary>
        public bool getCDown() { return UnityEngine.Input.GetMouseButtonDown(2); }
        /// <summary>
        /// Detect if center mouse button is up.
        /// </summary>
        public bool getCUp() { return UnityEngine.Input.GetMouseButtonUp(2); }

        /// <summary>
        /// Detect if right mouse button.
        /// </summary>
        public bool getR() { return UnityEngine.Input.GetMouseButton(1); }
        /// <summary>
        /// Detect if right mouse button is down.
        /// </summary>
        public bool getRDown() { return UnityEngine.Input.GetMouseButtonDown(1); }
        /// <summary>
        /// Detect if right mouse button is up.
        /// </summary>
        public bool getRUp() { return UnityEngine.Input.GetMouseButtonUp(1); }
    }
    /// <summary>
    /// Contains all the data on the mouse.
    /// </summary>
    public Mouse mouse = new Mouse();

    /// <summary>
    /// Contains all the data for a joystick.
    /// </summary>
    [System.Serializable]
    public class JoyStick
    {
        public bool active;

        public Vector2 Axis0;
        public Vector2 Axis0Prev;

        public bool getAxis0Up() { return Axis0.y > 0.95f; }
        public bool getAxis0UpDown() { return Axis0.y > 0.95f && Axis0Prev.y < 0.95f; }
        public bool getAxis0UpUp() { return Axis0.y < 0.95f && Axis0Prev.y > 0.95f; }

        public bool getAxis0Down() { return Axis0.y < -0.95f; }
        public bool getAxis0DownDown() { return Axis0.y < -0.95f && Axis0Prev.y > -0.95f; }
        public bool getAxis0DownUp() { return Axis0.y > -0.95f && Axis0Prev.y < -0.95f; }

        public bool getAxis0Left() { return Axis0.x < -0.95f; }
        public bool getAxis0LeftDown() { return Axis0.x < -0.95f && Axis0Prev.x > -0.95f; }
        public bool getAxis0LeftUp() { return Axis0.x > -0.95f && Axis0Prev.x < -0.95f; }

        public bool getAxis0Right() { return Axis0.x > 0.95f; }
        public bool getAxis0RightDown() { return Axis0.x > 0.95f && Axis0Prev.x < 0.95f; }
        public bool getAxis0RightUp() { return Axis0.x < 0.95f && Axis0Prev.x > 0.95f; }


        public Vector2 Axis1;
        public Vector2 Axis1Prev;

        public bool getAxis1Up() { return Axis1.y > 0.95f; }
        public bool getAxis1UpDown() { return Axis1.y > 0.95f && Axis1Prev.y < 0.95f; }
        public bool getAxis1UpUp() { return Axis1.y < 0.95f && Axis1Prev.y > 0.95f; }
                           
        public bool getAxis1Down() { return Axis1.y < -0.95f; }
        public bool getAxis1DownDown() { return Axis1.y < -0.95f && Axis1Prev.y > -0.95f; }
        public bool getAxis1DownUp() { return Axis1.y > -0.95f && Axis1Prev.y < -0.95f; }
                           
        public bool getAxis1Left() { return Axis1.x < -0.95f; }
        public bool getAxis1LeftDown() { return Axis1.x < -0.95f && Axis1Prev.x > -0.95f; }
        public bool getAxis1LeftUp() { return Axis1.x > -0.95f && Axis1Prev.x < -0.95f; }
                           
        public bool getAxis1Right() { return Axis1.x > 0.95f; }
        public bool getAxis1RightDown() { return Axis1.x > 0.95f && Axis1Prev.x < 0.95f; }
        public bool getAxis1RightUp() { return Axis1.x < 0.95f && Axis1Prev.x > 0.95f; }

        public Vector2 Axis2;
        public Vector2 Axis2Prev;

        public bool getAxis2Up() { return Axis2.y > 0.95f; }
        public bool getAxis2UpDown() { return Axis2.y > 0.95f && Axis2Prev.y < 0.95f; }
        public bool getAxis2UpUp() { return Axis2.y < 0.95f && Axis2Prev.y > 0.95f; }

        public bool getAxis2Down() { return Axis2.y < -0.95f; }
        public bool getAxis2DownDown() { return Axis2.y < -0.95f && Axis2Prev.y > -0.95f; }
        public bool getAxis2DownUp() { return Axis2.y > -0.95f && Axis2Prev.y < -0.95f; }

        public bool getAxis2Left() { return Axis2.x < -0.95f; }
        public bool getAxis2LeftDown() { return Axis2.x < -0.95f && Axis2Prev.x > -0.95f; }
        public bool getAxis2LeftUp() { return Axis2.x > -0.95f && Axis2Prev.x < -0.95f; }

        public bool getAxis2Right() { return Axis2.x > 0.95f; }
        public bool getAxis2RightDown() { return Axis2.x > 0.95f && Axis2Prev.x < 0.95f; }
        public bool getAxis2RightUp() { return Axis2.x < 0.95f && Axis2Prev.x > 0.95f; }

        public bool lb;
        [HideInInspector]
        public bool lbPrev;

        public bool getLB() { return lb; }
        public bool getLBDown() { return lbPrev == false && lb == true; }
        public bool getLBUp() { return lbPrev == true && lb == false; }

        public bool rb;
        [HideInInspector]
        public bool rbPrev;

        public bool getRB() { return rb; }
        public bool getRBDown() { return rbPrev == false && rb == true; }
        public bool getRBUp() { return rbPrev == true && rb == false; }

        public bool back;
        [HideInInspector]
        public bool backPrev;

        public bool getBack() { return back; }
        public bool getBackDown() { return backPrev == false && back == true; }
        public bool getBackUp() { return backPrev == true && back == false; }

        // Start
        public bool start;
        [HideInInspector]
        public bool startPrev;

        public bool getStart() { return start; }
        public bool getStartDown() { return startPrev == false && start == true; }
        public bool getStartUp() { return startPrev == true && start == false; }

        // A
        public bool a;
        [HideInInspector]
        public bool aPrev;

        public bool getA() { return a; }
        public bool getADown() { return aPrev == false && a == true; }
        public bool getAUp() { return aPrev == true && a == false; }

        // B
        public bool b;
        [HideInInspector]
        public bool bPrev;

        public bool getB() { return b; }
        public bool getBDown() { return bPrev == false && b == true; }
        public bool getBUp() { return bPrev == true && b == false; }

        public bool x;
        [HideInInspector]
        public bool xPrev;

        public bool getX() { return x; }
        public bool getXDown() { return xPrev == false && x == true; }
        public bool getXUp() { return xPrev == true && x == false; }

        public bool y;
        [HideInInspector]
        public bool yPrev;

        public bool getY() { return y; }
        public bool getYDown() { return yPrev == false && y == true; }
        public bool getYUp() { return yPrev == true && y == false; }

        public void ResetJoyStick()
        {
            Axis0 = Vector2.zero;
            Axis1 = Vector2.zero;
            Axis2 = Vector2.zero;

            back = false;
            backPrev = false;
            start = false;
            startPrev = false;
            a = false;
            aPrev = false;
            b = false;
            bPrev = false;
            x = false;
            xPrev = false;
            y = false;
            yPrev = false;
        }

        public JoyStick() { }
    }
    /// <summary>
    /// Contains all the data for the 4 joysticks.
    /// </summary>
    public JoyStick[] joysticks = new JoyStick[4];
    /// <summary>
    /// Which joysticks are currently active.
    /// </summary>
    public bool[] activeJoysticks = new bool[4];
    /// <summary>
    /// The number of currently active joysticks.
    /// </summary>
    public int activeJoysticksCount = 0;

    /// <summary>
    /// Contains all the data for the master joystick.
    /// </summary>
    [System.Serializable]
    public class MasterJoyStick
    {
        public bool active;

        public Vector2 Axis0Prev;
        public Vector2 Axis0;

        public bool getAxis0Up() { return Axis0.y > 0.90f; }
        public bool getAxis0UpDown() { return Axis0.y > 0.90f && Axis0Prev.y < 0.90f; }
        public bool getAxis0UpUp() { return Axis0.y < 0.90f && Axis0Prev.y > 0.90f; }

        public bool getAxis0Down() { return Axis0.y < -0.90f; }
        public bool getAxis0DownDown() { return Axis0.y < -0.90f && Axis0Prev.y > -0.90f; }
        public bool getAxis0DownUp() { return Axis0.y > -0.90f && Axis0Prev.y < -0.90f; }

        public bool getAxis0Left() { return Axis0.x < -0.90f; }
        public bool getAxis0LeftDown() { return Axis0.x < -0.90f && Axis0Prev.x > -0.90f; }
        public bool getAxis0LeftUp() { return Axis0.x > -0.90f && Axis0Prev.x < -0.90f; }

        public bool getAxis0Right() { return Axis0.x > 0.90f; }
        public bool getAxis0RightDown() { return Axis0.x > 0.90f && Axis0Prev.x < 0.90f; }
        public bool getAxis0RightUp() { return Axis0.x < 0.90f && Axis0Prev.x > 0.90f; }

        public Vector2 Axis1Prev;
        public Vector2 Axis1;

        public bool getAxis1Up() { return Axis1.y > 0.90f; }
        public bool getAxis1UpDown() { return Axis1.y > 0.90f && Axis1Prev.y < 0.90f; }
        public bool getAxis1UpUp() { return Axis1.y < 0.90f && Axis1Prev.y > 0.90f; }

        public bool getAxis1Down() { return Axis1.y < -0.90f; }
        public bool getAxis1DownDown() { return Axis1.y < -0.90f && Axis1Prev.y > -0.90f; }
        public bool getAxis1DownUp() { return Axis1.y > -0.90f && Axis1Prev.y < -0.90f; }

        public bool getAxis1Left() { return Axis1.x < -0.90f; }
        public bool getAxis1LeftDown() { return Axis1.x < -0.90f && Axis1Prev.x > -0.90f; }
        public bool getAxis1LeftUp() { return Axis1.x > -0.90f && Axis1Prev.x < -0.90f; }

        public bool getAxis1Right() { return Axis1.x > 0.90f; }
        public bool getAxis1RightDown() { return Axis1.x > 0.90f && Axis1Prev.x < 0.90f; }
        public bool getAxis1RightUp() { return Axis1.x < 0.90f && Axis1Prev.x > 0.90f; }

        public Vector2 Axis2Prev;
        public Vector2 Axis2;

        public bool getAxis2Up() { return Axis2.y > 0.90f; }
        public bool getAxis2UpDown() { return Axis2.y > 0.90f && Axis2Prev.y < 0.90f; }
        public bool getAxis2UpUp() { return Axis2.y < 0.90f && Axis2Prev.y > 0.90f; }

        public bool getAxis2Down() { return Axis2.y < -0.90f; }
        public bool getAxis2DownDown() { return Axis2.y < -0.90f && Axis2Prev.y > -0.90f; }
        public bool getAxis2DownUp() { return Axis2.y > -0.90f && Axis2Prev.y < -0.90f; }

        public bool getAxis2Left() { return Axis2.x < -0.90f; }
        public bool getAxis2LeftDown() { return Axis2.x < -0.90f && Axis2Prev.x > -0.90f; }
        public bool getAxis2LeftUp() { return Axis2.x > -0.90f && Axis2Prev.x < -0.90f; }

        public bool getAxis2Right() { return Axis2.x > 0.90f; }
        public bool getAxis2RightDown() { return Axis2.x > 0.90f && Axis2Prev.x < 0.90f; }
        public bool getAxis2RightUp() { return Axis2.x < 0.90f && Axis2Prev.x > 0.90f; }

        // LB
        public int lb;
        public int lbDown;
        public int lbUp;

        public bool getLB() { return (lb > 0); }
        public bool getLBDown() { return (lbDown > 0); }
        public bool getLBUp() { return (lbUp > 0); }

        // RB
        public int rb;
        public int rbDown;
        public int rbUp;

        public bool getRB() { return (rb > 0); }
        public bool getRBDown() { return (rbDown > 0); }
        public bool getRBUp() { return (rbUp > 0); }

        // Back
        public int back;
        public int backDown;
        public int backUp;

        public bool getBack() { return (back > 0); }
        public bool getBackDown() { return (backDown > 0); }
        public bool getBackUp() { return (backUp > 0); }

        // Start
        public int start;
        public int startDown;
        public int startUp;

        public bool getStart() { return (start > 0); }
        public bool getStartDown() { return (startDown > 0); }
        public bool getStartUp() { return (startUp > 0); }

        // A
        public int a;
        public int aDown;
        public int aUp;

        public bool getA() { return (a > 0); }
        public bool getADown() { return (aDown > 0); }
        public bool getAUp() { return (aUp > 0); }

        // B
        public int b;
        public int bDown;
        public int bUp;

        public bool getB() { return (b > 0); }
        public bool getBDown() { return (bDown > 0); }
        public bool getBUp() { return (bUp > 0); }

        // X
        public int x;
        public int xDown;
        public int xUp;

        public bool getX() { return (x > 0); }
        public bool getXDown() { return (xDown > 0); }
        public bool getXUp() { return (xUp > 0); }

        // Y
        public int y;
        public int yDown;
        public int yUp;

        public bool getY() { return (y > 0); }
        public bool getYDown() { return (yDown > 0); }
        public bool getYUp() { return (yUp > 0); }

        /// <summary>
        /// Reset Master Joystick
        /// </summary>
        public void ResetJoyStick()
        {
            Axis0 = Vector2.zero;
            Axis0Prev = Vector2.zero;
            Axis1 = Vector2.zero;
            Axis1Prev = Vector2.zero;
            Axis2 = Vector2.zero;
            Axis2Prev = Vector2.zero;

            // LB
            lb = 0;
            lbDown = 0;
            lbUp = 0;

            // RB
            rb = 0;
            rbDown = 0;
            rbUp = 0;

            // Back
            back = 0;
            backDown = 0;
            backUp = 0;

            // Start
            start = 0;
            startDown = 0;
            startUp = 0;

            // A
            a = 0;
            aDown = 0;
            aUp = 0;

            // B
            b = 0;
            bDown = 0;
            bUp = 0;

            // X
            x = 0;
            xDown = 0;
            xUp = 0;

            // Y
            y = 0;
            yDown = 0;
            yUp = 0;

        }

        /// <summary>
        /// Create Master Joystick.
        /// </summary>
        public MasterJoyStick() { }
    }

    public MasterJoyStick joystick = new MasterJoyStick();

    /// <summary>
    /// Updates the keyboard.
    /// </summary>
    public void UpdateKeyboard()
    {

    }

    /// <summary>
    /// Updates the mouse.
    /// </summary>
    public void UpdateMouse()
    {
        mouse.position = new Vector2(UnityEngine.Input.mousePosition.x, UnityEngine.Input.mousePosition.y);

        //Scroll Wheel
        mouse.scroll = UnityEngine.Input.GetAxisRaw("MouseScroll");
    }

    /// <summary>
    /// Gets a joystick key.
    /// </summary>
    /// <param name="joystick">Joystick to get.</param>
    /// <param name="button">Key to get.</param>
    /// <returns></returns>
    public bool GetJoystickKey(int joystick, int button)
    {
        return (UnityEngine.Input.GetKey(string.Format("joystick {0} button {1}", joystick + 1, button))) ? true : false;
    }

    /// <summary>
    /// Updates the joysticks.
    /// </summary>
    public void UpdateJoysticks()
    {
        activeJoysticksCount = 0;
        for (int i = 0; i <= 3; i++)
        {
            if (UnityEngine.Input.GetJoystickNames().Length > i)
            {
                if (UnityEngine.Input.GetJoystickNames()[i] != "")
                {
                    activeJoysticksCount++;
                    joysticks[i].active = true;
                    activeJoysticks[i] = true;
                }
                else
                {
                    joysticks[i].ResetJoyStick();
                    joysticks[i].active = false;
                    activeJoysticks[i] = false;
                }
            }
        }

        joystick.ResetJoyStick();

        for (int i = 0; i <= 3; i++)
        {
            if (activeJoysticks[i] == true)
            {
                //LB
                joysticks[i].lbPrev = joysticks[i].lb;
                joysticks[i].lb = (GetJoystickKey(i, 4));
                joystick.lb += (joysticks[i].getLB()) ? 1 : 0;
                joystick.lbDown += (joysticks[i].getLBDown()) ? 1 : 0;
                joystick.lbUp += (joysticks[i].getLBUp()) ? 1 : 0;

                //RB
                joysticks[i].rbPrev = joysticks[i].rb;
                joysticks[i].rb = (GetJoystickKey(i, 5));
                joystick.rb += (joysticks[i].getRB()) ? 1 : 0;
                joystick.rbDown += (joysticks[i].getRBDown()) ? 1 : 0;
                joystick.rbUp += (joysticks[i].getRBUp()) ? 1 : 0;

                //A
                joysticks[i].aPrev = joysticks[i].a;
                joysticks[i].a = (GetJoystickKey(i, 0));
                joystick.a += (joysticks[i].getA()) ? 1 : 0;
                joystick.aDown += (joysticks[i].getADown()) ? 1 : 0;
                joystick.aUp += (joysticks[i].getAUp()) ? 1 : 0;

                //B
                joysticks[i].bPrev = joysticks[i].b;
                joysticks[i].b = (GetJoystickKey(i, 1));
                joystick.b += (joysticks[i].getB()) ? 1 : 0;
                joystick.bDown += (joysticks[i].getBDown()) ? 1 : 0;
                joystick.bUp += (joysticks[i].getBUp()) ? 1 : 0;

                //X
                joysticks[i].xPrev = joysticks[i].x;
                joysticks[i].x = (GetJoystickKey(i, 2));
                joystick.x += (joysticks[i].getX()) ? 1 : 0;
                joystick.xDown += (joysticks[i].getXDown()) ? 1 : 0;
                joystick.xUp += (joysticks[i].getXUp()) ? 1 : 0;

                //Y
                joysticks[i].yPrev = joysticks[i].y;
                joysticks[i].y = (GetJoystickKey(i, 3));
                joystick.y += (joysticks[i].getY()) ? 1 : 0;
                joystick.yDown += (joysticks[i].getYDown()) ? 1 : 0;
                joystick.yUp += (joysticks[i].getYUp()) ? 1 : 0;

                //Back
                joysticks[i].backPrev = joysticks[i].back;
                joysticks[i].back = (GetJoystickKey(i, 6));
                joystick.back += (joysticks[i].getBack()) ? 1 : 0;
                joystick.backDown += (joysticks[i].getBackDown()) ? 1 : 0;
                joystick.backUp += (joysticks[i].getBackUp()) ? 1 : 0;

                //Start
                joysticks[i].startPrev = joysticks[i].start;
                joysticks[i].start = (GetJoystickKey(i, 7));
                joystick.start += (joysticks[i].getStart()) ? 1 : 0;
                joystick.startDown += (joysticks[i].getStartDown()) ? 1 : 0;
                joystick.startUp += (joysticks[i].getStartUp()) ? 1 : 0;

                //Axis0
                joysticks[i].Axis0Prev = joysticks[i].Axis0;
                joystick.Axis0Prev += joysticks[i].Axis0;
                joysticks[i].Axis0 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X"), UnityEngine.Input.GetAxis("Joy" + i + "Y") * -1);
                joystick.Axis0 += joysticks[i].Axis0;
                joystick.Axis0 = new Vector2(Mathf.Clamp(joystick.Axis0.x, -1, 1), Mathf.Clamp(joystick.Axis0.y, -1, 1));
                joystick.Axis0Prev = new Vector2(Mathf.Clamp(joystick.Axis0Prev.x, -1, 1), Mathf.Clamp(joystick.Axis0Prev.y, -1, 1));

                //Axis1
                joysticks[i].Axis1Prev = joysticks[i].Axis1;
                joystick.Axis1Prev += joysticks[i].Axis1;
                joysticks[i].Axis1 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X2"), UnityEngine.Input.GetAxis("Joy" + i + "Y2") * -1);
                joystick.Axis1 += joysticks[i].Axis1;
                joystick.Axis1 = new Vector2(Mathf.Clamp(joystick.Axis1.x, -1, 1), Mathf.Clamp(joystick.Axis1.y, -1, 1));
                joystick.Axis1Prev = new Vector2(Mathf.Clamp(joystick.Axis1Prev.x, -1, 1), Mathf.Clamp(joystick.Axis1Prev.y, -1, 1));

                //Axis2
                joysticks[i].Axis2Prev = joysticks[i].Axis2;
                joystick.Axis2Prev += joysticks[i].Axis2;
                joysticks[i].Axis2 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X3"), UnityEngine.Input.GetAxis("Joy" + i + "Y3"));
                joystick.Axis2 += joysticks[i].Axis2;
                joystick.Axis2 = new Vector2(Mathf.Clamp(joystick.Axis2.x, -1, 1), Mathf.Clamp(joystick.Axis2.y, -1, 1));
                joystick.Axis2Prev = new Vector2(Mathf.Clamp(joystick.Axis2Prev.x, -1, 1), Mathf.Clamp(joystick.Axis2Prev.y, -1, 1));
            }
        }
    }
}
