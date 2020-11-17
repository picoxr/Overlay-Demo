using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 控制使用的ray
/// </summary>
public class RayController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] starts;

    [SerializeField]
    private GameObject[] dots;

    private int hand;

    [SerializeField]
    private GameObject m_head;
    //[SerializeField]
    //private GameObject m_cursor;

    // Update is called once per frame
    void Update()
    {
        
        if (Pvr_UnitySDKAPI.Controller.UPvr_GetControllerState(0) == Pvr_UnitySDKAPI.ControllerState.Connected ||
            Pvr_UnitySDKAPI.Controller.UPvr_GetControllerState(1) == Pvr_UnitySDKAPI.ControllerState.Connected)
        {
            hand = Pvr_UnitySDKAPI.Controller.UPvr_GetMainHandNess();
            ControllerPhysicRaycastManager.Instance.ray =
                new Ray(starts[hand].transform.position,
                (dots[hand].transform.position - starts[hand].transform.position).normalized);
        }
        else
        {
            ControllerPhysicRaycastManager.Instance.ray =
                new Ray(m_head.transform.position, m_head.transform.forward);
            //Debug.Log("手柄未连接，请连接手柄");
        }
    }
}
