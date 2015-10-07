using UnityEngine;
using System.Collections;
using System.IO;

public class Input : MonoBehaviour {

    public LSInput lsInput = new LSInput();

    public GameObject Canvas;
    public GameObject keyboard;
    public GameObject keyboardExtra;
    public GameObject mouse;
    public GameObject[] JoySticks;
    public GameObject masterJoystick;

    GameObject GetExtraKeyboardGameObject(string character)
    {
        return keyboardExtra.transform.FindChild(character).gameObject;
    }

    GameObject GetKeyboardGameObject(int line, string character)
    {
        return keyboard.transform.FindChild("Line " + line).transform.FindChild(character).gameObject;
    }

    void UpdateKeyboard()
    {
        // Backquote
        GameObject Backquote = GetKeyboardGameObject(1, "Backquote");
        Backquote.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getBackquote();

        // Alpha1
        GameObject Alpha1 = GetKeyboardGameObject(1, "1");
        Alpha1.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha1();

        // Alpha2
        GameObject Alpha2 = GetKeyboardGameObject(1, "2");
        Alpha2.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha2();

        // Alpha3
        GameObject Alpha3 = GetKeyboardGameObject(1, "3");
        Alpha3.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha3();

        // Alpha4
        GameObject Alpha4 = GetKeyboardGameObject(1, "4");
        Alpha4.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha4();

        // Alpha5
        GameObject Alpha5 = GetKeyboardGameObject(1, "5");
        Alpha5.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha5();

        // Alpha6
        GameObject Alpha6 = GetKeyboardGameObject(1, "6");
        Alpha6.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha6();

        // Alpha7
        GameObject Alpha7 = GetKeyboardGameObject(1, "7");
        Alpha7.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha7();

        // Alpha8
        GameObject Alpha8 = GetKeyboardGameObject(1, "8");
        Alpha8.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha8();

        // Alpha9
        GameObject Alpha9 = GetKeyboardGameObject(1, "9");
        Alpha9.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha9();

        // Alpha0
        GameObject Alpha0 = GetKeyboardGameObject(1, "0");
        Alpha0.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getAlpha0();

        // Minus
        GameObject Minus = GetKeyboardGameObject(1, "Minus");
        Minus.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getMinus();

        // Equals
        GameObject Equals = GetKeyboardGameObject(1, "Equals");
        Equals.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getEquals();

        // Backspace
        GameObject Backspace = GetKeyboardGameObject(1, "Backspace");
        Backspace.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getBackspace();

        //

        // Tab
        GameObject Tab = GetKeyboardGameObject(2, "Tab");
        Tab.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getTab();

        // Q
        GameObject Q = GetKeyboardGameObject(2, "Q");
        Q.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getQ();

        // W
        GameObject W = GetKeyboardGameObject(2, "W");
        W.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getW();

        // E
        GameObject E = GetKeyboardGameObject(2, "E");
        E.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getE();

        // R
        GameObject R = GetKeyboardGameObject(2, "R");
        R.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getR();

        // T
        GameObject T = GetKeyboardGameObject(2, "T");
        T.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getT();

        // Y
        GameObject Y = GetKeyboardGameObject(2, "Y");
        Y.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getY();

        // U
        GameObject U = GetKeyboardGameObject(2, "U");
        U.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getU();

        // I
        GameObject I = GetKeyboardGameObject(2, "I");
        I.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getI();

        // O
        GameObject O = GetKeyboardGameObject(2, "O");
        O.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getO();

        // P
        GameObject P = GetKeyboardGameObject(2, "P");
        P.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getP();

        // LeftBracket
        GameObject LBracket = GetKeyboardGameObject(2, "Left Bracket");
        LBracket.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeftBracket();

        // RightBracket
        GameObject RBracket = GetKeyboardGameObject(2, "Right Bracket");
        RBracket.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRightBracket();

        // Backslash
        GameObject ForwardSlash = GetKeyboardGameObject(2, "Backslash");
        ForwardSlash.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getBackslash();

        //

        // CapsLock
        GameObject CapsLock = GetKeyboardGameObject(3, "Caps Lock");
        CapsLock.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getCapsLock();

        // A
        GameObject A = GetKeyboardGameObject(3, "A");
        A.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getA();

        // S
        GameObject S = GetKeyboardGameObject(3, "S");
        S.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getS();

        // D
        GameObject D = GetKeyboardGameObject(3, "D");
        D.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getD();

        // F
        GameObject F = GetKeyboardGameObject(3, "F");
        F.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getF();

        // G
        GameObject G = GetKeyboardGameObject(3, "G");
        G.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getG();

        // H
        GameObject H = GetKeyboardGameObject(3, "H");
        H.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getH();

        // J
        GameObject J = GetKeyboardGameObject(3, "J");
        J.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getJ();

        // K
        GameObject K = GetKeyboardGameObject(3, "K");
        K.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getK();

        // L
        GameObject L = GetKeyboardGameObject(3, "L");
        L.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getL();

        // Semicolon
        GameObject Semicolon = GetKeyboardGameObject(3, "Semicolon");
        Semicolon.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getSemicolon();

        // Quote
        GameObject Quote = GetKeyboardGameObject(3, "Quote");
        Quote.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getQuote();

        // Return
        GameObject Return = GetKeyboardGameObject(3, "Enter");
        Return.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getReturn();

        //

        // Left Shift
        GameObject LeftShift = GetKeyboardGameObject(4, "Left Shift");
        LeftShift.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeftShift();

        // Z
        GameObject Z = GetKeyboardGameObject(4, "Z");
        Z.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getZ();

        // X
        GameObject X = GetKeyboardGameObject(4, "X");
        X.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getX();

        // C
        GameObject C = GetKeyboardGameObject(4, "C");
        C.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getC();

        // V
        GameObject V = GetKeyboardGameObject(4, "V");
        V.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getV();

        // B
        GameObject B = GetKeyboardGameObject(4, "B");
        B.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getB();

        // N
        GameObject N = GetKeyboardGameObject(4, "N");
        N.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getN();

        // N
        GameObject M = GetKeyboardGameObject(4, "M");
        M.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getM();

        // Comma
        GameObject Comma = GetKeyboardGameObject(4, "Comma");
        Comma.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getComma();

        // Period
        GameObject Period = GetKeyboardGameObject(4, "Period");
        Period.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getPeriod();

        // Slash
        GameObject Slash = GetKeyboardGameObject(4, "Slash");
        Slash.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getSlash();

        // Right Shift
        GameObject RightShift = GetKeyboardGameObject(4, "Right Shift");
        RightShift.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRightShift();

        //

        // Left Ctrl
        GameObject LeftCtrl = GetKeyboardGameObject(5, "Left Ctrl");
        LeftCtrl.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeftCtrl();

        // Left Windows
        GameObject LeftWindows = GetKeyboardGameObject(5, "Left Windows");
        LeftWindows.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeftWindows();

        // Left Alt
        GameObject LeftAlt = GetKeyboardGameObject(5, "Left Alt");
        LeftAlt.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeftAlt();

        // Space
        GameObject Space = GetKeyboardGameObject(5, "Space");
        Space.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getSpace();

        // Right Alt
        GameObject RightAlt = GetKeyboardGameObject(5, "Right Alt");
        RightAlt.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRightAlt();

        // Right Windows
        GameObject RightWindows = GetKeyboardGameObject(5, "Right Windows");
        RightWindows.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRightWindows();

        // Context
        GameObject Context = GetKeyboardGameObject(5, "Context");
        Context.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getContext();

        // Right Ctrl
        GameObject RightCtrl = GetKeyboardGameObject(5, "Right Ctrl");
        RightCtrl.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRightCtrl();

        // ---- EXTRA KEYBOARD ---- //

        // Insert
        GameObject Insert = GetExtraKeyboardGameObject("Insert");
        Insert.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getInsert();

        // Home
        GameObject Home = GetExtraKeyboardGameObject("Home");
        Home.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getHome();

        // PageUp
        GameObject PageUp = GetExtraKeyboardGameObject("Page Up");
        PageUp.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getPageUp();

        // PageDown
        GameObject PageDown = GetExtraKeyboardGameObject("Page Down");
        PageDown.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getPageDown();

        // Delete
        GameObject Delete = GetExtraKeyboardGameObject("Delete");
        Delete.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getDelete();

        // End
        GameObject End = GetExtraKeyboardGameObject("End");
        End.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getEnd();

        //

        // Left
        GameObject Left = GetExtraKeyboardGameObject("Left");
        Left.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getLeft();

        // Right
        GameObject Right = GetExtraKeyboardGameObject("Right");
        Right.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getRight();

        // Up
        GameObject Up = GetExtraKeyboardGameObject("Up");
        Up.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getUp();

        // Down
        GameObject Down = GetExtraKeyboardGameObject("Down");
        Down.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getDown();

        //

        // NumLock
        GameObject NumLock = GetExtraKeyboardGameObject("Num Lock");
        NumLock.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getNumlock();

        // KeypadDivide
        GameObject KeypadDivide = GetExtraKeyboardGameObject("Divide");
        KeypadDivide.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadDivide();

        // KeypadMultiply
        GameObject KeypadMultiply = GetExtraKeyboardGameObject("Multiply");
        KeypadMultiply.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadMultiply();

        // KeypadMinus
        GameObject KeypadMinus = GetExtraKeyboardGameObject("Minus");
        KeypadMinus.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadMinus();

        // KeypadPlus
        GameObject KeypadPlus = GetExtraKeyboardGameObject("Plus");
        KeypadPlus.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadPlus();

        // KeypadEnter
        GameObject KeypadEnter = GetExtraKeyboardGameObject("Enter");
        KeypadEnter.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadEnter();

        // KeypadPeriod
        GameObject KeypadPeriod = GetExtraKeyboardGameObject("Period");
        KeypadPeriod.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypadPeriod();

        // Keypad0
        GameObject Keypad0 = GetExtraKeyboardGameObject("0");
        Keypad0.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad0();

        // Keypad1
        GameObject Keypad1 = GetExtraKeyboardGameObject("1");
        Keypad1.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad1();

        // Keypad2
        GameObject Keypad2 = GetExtraKeyboardGameObject("2");
        Keypad2.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad2();

        // Keypad3
        GameObject Keypad3 = GetExtraKeyboardGameObject("3");
        Keypad3.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad3();

        // Keypad4
        GameObject Keypad4 = GetExtraKeyboardGameObject("4");
        Keypad4.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad4();

        // Keypad5
        GameObject Keypad5 = GetExtraKeyboardGameObject("5");
        Keypad5.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad5();

        // Keypad6
        GameObject Keypad6 = GetExtraKeyboardGameObject("6");
        Keypad6.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad6();

        // Keypad7
        GameObject Keypad7 = GetExtraKeyboardGameObject("7");
        Keypad7.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad7();

        // Keypad8
        GameObject Keypad8 = GetExtraKeyboardGameObject("8");
        Keypad8.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad8();

        // Keypad9
        GameObject Keypad9 = GetExtraKeyboardGameObject("9");
        Keypad9.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.keyboard.getKeypad9();
    }

    void UpdateMouse()
    {
        //L
        GameObject L = mouse.transform.FindChild("L").gameObject;
        L.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.mouse.getL();

        //C Top
        GameObject CTop = mouse.transform.FindChild("C Top").gameObject;
        CTop.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.mouse.getScrollUp();

        //C
        GameObject C = mouse.transform.FindChild("C").gameObject;
        C.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.mouse.getC();

        //C Bottom
        GameObject CBottom = mouse.transform.FindChild("C Bottom").gameObject;
        CBottom.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.mouse.getScrollDown();

        //R
        GameObject R = mouse.transform.FindChild("R").gameObject;
        R.GetComponent<UnityEngine.UI.Button>().interactable = lsInput.mouse.getR();
    }

    void UpdateController()
    {
        int i = 0;
        while (i <= 3)
        {
            int axisMultiplier = 35;

            // Active
            GameObject Active = JoySticks[i].transform.FindChild("Active").gameObject;
            Active.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].active);

            // LB
            GameObject LB = JoySticks[i].transform.FindChild("LB").gameObject;
            LB.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getLB());

            // RB
            GameObject RB = JoySticks[i].transform.FindChild("RB").gameObject;
            RB.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getRB());

            // A
            GameObject A = JoySticks[i].transform.FindChild("A").gameObject;
            A.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getA());

            // B
            GameObject B = JoySticks[i].transform.FindChild("B").gameObject;
            B.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getB());

            // X
            GameObject X = JoySticks[i].transform.FindChild("X").gameObject;
            X.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getX());

            // Y
            GameObject Y = JoySticks[i].transform.FindChild("Y").gameObject;
            Y.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getY());

            // Back Button
            GameObject Back = JoySticks[i].transform.FindChild("Back").gameObject;
            Back.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getBack());

            // Start Button
            GameObject Start = JoySticks[i].transform.FindChild("Start").gameObject;
            Start.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getStart());

            // Axis 1
            GameObject Axis0 = JoySticks[i].transform.FindChild("Axis 0").gameObject;
            GameObject AxisStick0 = Axis0.transform.FindChild("stick").gameObject;

            GameObject AxisStick0Top = Axis0.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick0Bottom = Axis0.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick0Left = Axis0.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick0Right = Axis0.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick0Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis0Up());
            if (lsInput.joysticks[i].getAxis0UpDown())
                Debug.Log("Axis0Up" + i + " pressed");
            if (lsInput.joysticks[i].getAxis0UpUp())
                Debug.Log("Axis0Up" + i + " released");

            AxisStick0Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis0Down());
            if (lsInput.joysticks[i].getAxis0DownDown())
                Debug.Log("Axis0Down" + i + " pressed");
            if (lsInput.joysticks[i].getAxis0DownUp())
                Debug.Log("Axis0Down" + i + " released");

            AxisStick0Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis0Left());
            if (lsInput.joysticks[i].getAxis0LeftDown())
                Debug.Log("Axis0Left" + i + " pressed");
            if (lsInput.joysticks[i].getAxis0LeftUp())
                Debug.Log("Axis0Left" + i + " released");

            AxisStick0Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis0Right());
            if (lsInput.joysticks[i].getAxis0RightDown())
                Debug.Log("Axis0Right" + i + " pressed");
            if (lsInput.joysticks[i].getAxis0RightUp())
                Debug.Log("Axis0Right" + i + " released");

            Vector2 Axis0Input = lsInput.joysticks[i].Axis0 * axisMultiplier;

            if (Mathf.Abs(Axis0Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis0Input.y) / axisMultiplier > 0.1f)
                AxisStick0.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick0.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick0.GetComponent<RectTransform>().localPosition = Axis0Input;

            // Axis 2
            GameObject Axis1 = JoySticks[i].transform.FindChild("Axis 1").gameObject;
            GameObject AxisStick1 = Axis1.transform.FindChild("stick").gameObject;

            GameObject AxisStick1Top = Axis1.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick1Bottom = Axis1.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick1Left = Axis1.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick1Right = Axis1.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick1Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis1Up());
            if (lsInput.joysticks[i].getAxis1UpDown())
                Debug.Log("Axis1Up" + i + " pressed");
            if (lsInput.joysticks[i].getAxis1UpUp())
                Debug.Log("Axis1Up" + i + " released");

            AxisStick1Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis1Down());
            if (lsInput.joysticks[i].getAxis1DownDown())
                Debug.Log("Axis1Down" + i + " pressed");
            if (lsInput.joysticks[i].getAxis1DownUp())
                Debug.Log("Axis1Down" + i + " released");

            AxisStick1Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis1Left());
            if (lsInput.joysticks[i].getAxis1LeftDown())
                Debug.Log("Axis1Left" + i + " pressed");
            if (lsInput.joysticks[i].getAxis1LeftUp())
                Debug.Log("Axis1Left" + i + " released");

            AxisStick1Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis1Right());
            if (lsInput.joysticks[i].getAxis1RightDown())
                Debug.Log("Axis1Right" + i + " pressed");
            if (lsInput.joysticks[i].getAxis1RightUp())
                Debug.Log("Axis1Right" + i + " released");

            Vector2 Axis1Input = lsInput.joysticks[i].Axis1 * axisMultiplier;

            if (Mathf.Abs(Axis1Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis1Input.y) / axisMultiplier > 0.1f)
                AxisStick1.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick1.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick1.GetComponent<RectTransform>().localPosition = Axis1Input;

            // Axis 3
            GameObject Axis2 = JoySticks[i].transform.FindChild("Axis 2").gameObject;
            GameObject AxisStick2 = Axis2.transform.FindChild("stick").gameObject;

            GameObject AxisStick2Top = Axis2.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick2Bottom = Axis2.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick2Left = Axis2.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick2Right = Axis2.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick2Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis2Up());
            if (lsInput.joysticks[i].getAxis2UpDown())
                Debug.Log("Axis2Up" + i + " pressed");
            if (lsInput.joysticks[i].getAxis2UpUp())
                Debug.Log("Axis2Up" + i + " released");

            AxisStick2Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis2Down());
            if (lsInput.joysticks[i].getAxis2DownDown())
                Debug.Log("Axis2Down" + i + " pressed");
            if (lsInput.joysticks[i].getAxis2DownUp())
                Debug.Log("Axis2Down" + i + " released");

            AxisStick2Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis2Left());
            if (lsInput.joysticks[i].getAxis2LeftDown())
                Debug.Log("Axis2Left" + i + " pressed");
            if (lsInput.joysticks[i].getAxis2LeftUp())
                Debug.Log("Axis2Left" + i + " released");

            AxisStick2Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joysticks[i].getAxis2Right());
            if (lsInput.joysticks[i].getAxis2RightDown())
                Debug.Log("Axis2Right" + i + " pressed");
            if (lsInput.joysticks[i].getAxis2RightUp())
                Debug.Log("Axis2Right" + i + " released");

            Vector2 Axis2Input = lsInput.joysticks[i].Axis2 * axisMultiplier;

            if (Mathf.Abs(Axis2Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis2Input.y) / axisMultiplier > 0.1f)
                AxisStick2.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick2.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick2.GetComponent<RectTransform>().localPosition = Axis2Input;

            i++;
        }

        // Master
        {
            int axisMultiplier = 35;

            // Active
            GameObject Active = masterJoystick.transform.FindChild("Active").gameObject;
            Active.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.active);

            // LB
            GameObject LB = masterJoystick.transform.FindChild("LB").gameObject;
            LB.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getLB());

            // RB
            GameObject RB = masterJoystick.transform.FindChild("RB").gameObject;
            RB.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getRB());

            // A
            GameObject A = masterJoystick.transform.FindChild("A").gameObject;
            A.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getA());

            // B
            GameObject B = masterJoystick.transform.FindChild("B").gameObject;
            B.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getB());

            // X
            GameObject X = masterJoystick.transform.FindChild("X").gameObject;
            X.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getX());

            // Y
            GameObject Y = masterJoystick.transform.FindChild("Y").gameObject;
            Y.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getY());

            // Back Button
            GameObject Back = masterJoystick.transform.FindChild("Back").gameObject;
            Back.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getBack());

            // Start Button
            GameObject Start = masterJoystick.transform.FindChild("Start").gameObject;
            Start.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getStart());

            // Axis 1
            GameObject Axis0 = masterJoystick.transform.FindChild("Axis 0").gameObject;
            GameObject AxisStick0 = Axis0.transform.FindChild("stick").gameObject;

            GameObject AxisStick0Top = Axis0.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick0Bottom = Axis0.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick0Left = Axis0.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick0Right = Axis0.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick0Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis0Up());
            if (lsInput.joystick.getAxis0UpDown())
                Debug.Log("Axis0Up" + i + " pressed");
            if (lsInput.joystick.getAxis0UpUp())
                Debug.Log("Axis0Up" + i + " released");

            AxisStick0Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis0Down());
            if (lsInput.joystick.getAxis0DownDown())
                Debug.Log("Axis0Down" + i + " pressed");
            if (lsInput.joystick.getAxis0DownUp())
                Debug.Log("Axis0Down" + i + " released");

            AxisStick0Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis0Left());
            if (lsInput.joystick.getAxis0LeftDown())
                Debug.Log("Axis0Left" + i + " pressed");
            if (lsInput.joystick.getAxis0LeftUp())
                Debug.Log("Axis0Left" + i + " released");

            AxisStick0Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis0Right());
            if (lsInput.joystick.getAxis0RightDown())
                Debug.Log("Axis0Right" + i + " pressed");
            if (lsInput.joystick.getAxis0RightUp())
                Debug.Log("Axis0Right" + i + " released");

            Vector2 Axis0Input = lsInput.joystick.Axis0 * axisMultiplier;

            if (Mathf.Abs(Axis0Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis0Input.y) / axisMultiplier > 0.1f)
                AxisStick0.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick0.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick0.GetComponent<RectTransform>().localPosition = Axis0Input;

            // Axis 2
            GameObject Axis1 = masterJoystick.transform.FindChild("Axis 1").gameObject;
            GameObject AxisStick1 = Axis1.transform.FindChild("stick").gameObject;

            GameObject AxisStick1Top = Axis1.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick1Bottom = Axis1.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick1Left = Axis1.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick1Right = Axis1.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick1Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis1Up());
            if (lsInput.joystick.getAxis1UpDown())
                Debug.Log("Axis1Up" + i + " pressed");
            if (lsInput.joystick.getAxis1UpUp())
                Debug.Log("Axis1Up" + i + " released");

            AxisStick1Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis1Down());
            if (lsInput.joystick.getAxis1DownDown())
                Debug.Log("Axis1Down" + i + " pressed");
            if (lsInput.joystick.getAxis1DownUp())
                Debug.Log("Axis1Down" + i + " released");

            AxisStick1Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis1Left());
            if (lsInput.joystick.getAxis1LeftDown())
                Debug.Log("Axis1Left" + i + " pressed");
            if (lsInput.joystick.getAxis1LeftUp())
                Debug.Log("Axis1Left" + i + " released");

            AxisStick1Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis1Right());
            if (lsInput.joystick.getAxis1RightDown())
                Debug.Log("Axis1Right" + i + " pressed");
            if (lsInput.joystick.getAxis1RightUp())
                Debug.Log("Axis1Right" + i + " released");

            Vector2 Axis1Input = lsInput.joystick.Axis1 * axisMultiplier;

            if (Mathf.Abs(Axis1Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis1Input.y) / axisMultiplier > 0.1f)
                AxisStick1.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick1.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick1.GetComponent<RectTransform>().localPosition = Axis1Input;

            // Axis 3
            GameObject Axis2 = masterJoystick.transform.FindChild("Axis 2").gameObject;
            GameObject AxisStick2 = Axis2.transform.FindChild("stick").gameObject;

            GameObject AxisStick2Top = Axis2.transform.FindChild("buttons").transform.FindChild("top").gameObject;
            GameObject AxisStick2Bottom = Axis2.transform.FindChild("buttons").transform.FindChild("bottom").gameObject;
            GameObject AxisStick2Left = Axis2.transform.FindChild("buttons").transform.FindChild("left").gameObject;
            GameObject AxisStick2Right = Axis2.transform.FindChild("buttons").transform.FindChild("right").gameObject;

            AxisStick2Top.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis2Up());
            if (lsInput.joystick.getAxis2UpDown())
                Debug.Log("Axis2Up" + i + " pressed");
            if (lsInput.joystick.getAxis2UpUp())
                Debug.Log("Axis2Up" + i + " released");

            AxisStick2Bottom.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis2Down());
            if (lsInput.joystick.getAxis2DownDown())
                Debug.Log("Axis2Down" + i + " pressed");
            if (lsInput.joystick.getAxis2DownUp())
                Debug.Log("Axis2Down" + i + " released");

            AxisStick2Left.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis2Left());
            if (lsInput.joystick.getAxis2LeftDown())
                Debug.Log("Axis2Left" + i + " pressed");
            if (lsInput.joystick.getAxis2LeftUp())
                Debug.Log("Axis2Left" + i + " released");

            AxisStick2Right.GetComponent<UnityEngine.UI.Button>().interactable = (lsInput.joystick.getAxis2Right());
            if (lsInput.joystick.getAxis2RightDown())
                Debug.Log("Axis2Right" + i + " pressed");
            if (lsInput.joystick.getAxis2RightUp())
                Debug.Log("Axis2Right" + i + " released");

            Vector2 Axis2Input = lsInput.joystick.Axis2 * axisMultiplier;

            if (Mathf.Abs(Axis2Input.x) / axisMultiplier > 0.1f || Mathf.Abs(Axis2Input.y) / axisMultiplier > 0.1f)
                AxisStick2.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            else
                AxisStick2.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            AxisStick2.GetComponent<RectTransform>().localPosition = Axis2Input;
        }
    }

	void Update () {
        if (lsInput.keyboard.getPDown())
        {
            string screenshotPath = Application.dataPath.Substring(0, Application.dataPath.LastIndexOf("/")) + "/screenshots";
            if (!Directory.Exists(screenshotPath))
            {
                Directory.CreateDirectory(screenshotPath);
            }
            Application.CaptureScreenshot(screenshotPath + "/" + System.DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".png");

            Debug.Log("Took Screenshot! - " + screenshotPath + "/" + System.DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".png");
        }
            
        lsInput.UpdateJoysticks();
        lsInput.UpdateMouse();
        lsInput.UpdateKeyboard();

        UpdateKeyboard();
        UpdateMouse();
        UpdateController();
    }
}
