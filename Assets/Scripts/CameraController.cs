using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public BallController target;
    private float offset; // смещение камеры относительно мяча

    private void Awake()
    {
        offset = transform.position.y - target.transform.position.y;
    }

    void Update () {
        // перемещение камеры по вертикали
        Vector3 curPos = transform.position;
        curPos.y = target.transform.position.y + offset;
        transform.position = curPos;
    }
}
