using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput  {

    static int hand;

    public static Vector3 controllerPosition;

    public static bool controllerPresent = false;

    public static bool GetControllerDown()
    {
        hand = Pvr_UnitySDKAPI.Controller.UPvr_GetMainHandNess();
         return Input.GetKeyDown(KeyCode.JoystickButton0) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyDown(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TOUCHPAD) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyDown(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TRIGGER) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyDown(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.A) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyDown(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.X) ||
                Input.GetButtonDown("Submit") || Input.GetMouseButtonDown(0);
    }

    public static bool GetControllerUp()
    {
        hand = Pvr_UnitySDKAPI.Controller.UPvr_GetMainHandNess();
        return Input.GetKeyUp(KeyCode.JoystickButton0) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyUp(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TOUCHPAD) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyUp(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TRIGGER) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyUp(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.A) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKeyUp(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.X)
               || Input.GetButtonDown("Submit") || Input.GetMouseButtonUp(0);
    }


    public static bool GetController()
    {
        hand = Pvr_UnitySDKAPI.Controller.UPvr_GetMainHandNess();
        return Input.GetKey(KeyCode.Joystick1Button0) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKey(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TOUCHPAD) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKey(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.TRIGGER) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKey(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.A) ||
                Pvr_UnitySDKAPI.Controller.UPvr_GetKey(hand, Pvr_UnitySDKAPI.Pvr_KeyCode.X) ||
                Input.GetButton("Submit") || Input.GetMouseButton(0);
    }

}
