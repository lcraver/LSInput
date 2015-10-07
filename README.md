<a href="http://limestudios.net/article/lsinput"><img src="http://limestudios.net/assets/img/posts/article/lsinput/logo.png"></a>

##Description
I made LSInput to address the issues I had with Unity's input manager setup.

##Setup
1. Add the needed Axes to the InputManager in Unity. [Example](http://limestudios.net/article/lsinput/#setup)
2. Initialize a new LSInput in the script you want to use it in.
3. In your script's Update method put the updates for the desired parts of LSInput.
4. That's it you're done!

##Example
```C#
  public class Input : MonoBehaviour {
  
    public LSInput lsInput = new LSInput();
    
    void Update () {
      if (lsInput.joystick.getAxis2UpDown())
        Debug.Log("Axis2Up" + i + " pressed");
      if (lsInput.joystick.getAxis2UpUp())
        Debug.Log("Axis2Up" + i + " released");
        
      lsInput.UpdateJoysticks();
      lsInput.UpdateMouse();
      lsInput.UpdateKeyboard();
    }
  }
```
