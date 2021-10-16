using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

/// <summary>
/// This script handle all the control code, so detecting when the users click on a unit or building and selecting those
/// If a unit is selected it will give the order to go to the clicked point or building when right clicking.
/// </summary>
public class UserControl : MonoBehaviour
{
    public Camera GameCamera;
    public float PanSpeed = 10.0f;

    public Shape m_Player = null;

    public void Start()
    {
    }

    public void HandleAction()
    {
        var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //var building = hit.collider.GetComponentInParent<Building>();

            m_Player.GoTo(hit.point);
        }
    }

    public void Update()
    {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        GameCamera.transform.position = GameCamera.transform.position + new Vector3(move.x, 0, move.y) * PanSpeed * Time.deltaTime;

        if (m_Player != null && Input.GetMouseButtonDown(1))
        {//right click give order to the unit
            HandleAction();
        }
    }
}