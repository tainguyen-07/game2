using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class nv : MonoBehaviour{
    private Transform AimTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
    }

    private void Awake()
{ 
    AimTransform = transform.Find("Aim");

}
public void LookAt()
{
    Vector3 mousePosition = UtilsClass.GetMouseWorldPosition();
    float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
    AimTransform.eulerAngles = new Vector3(0, 0, angle);
}
public static Vector3 GetMouseWorldPosition()
{
    Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    vec.z = 0f;
    return vec;

}
public static Vector3 GetMouseWorldPositionWithZ() => GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
{
    return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);

}
public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
{
    Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);

    return worldPosition; 
}

}
