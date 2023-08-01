using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    private void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform .position.z);
    }
}
