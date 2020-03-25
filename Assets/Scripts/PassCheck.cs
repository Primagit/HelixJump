using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCheck : MonoBehaviour {

    private void OnTriggerEnter(Collider other)// метод, срабатывающий при столкновении
    {
        GameManager.singleton.AddScore(1);

        FindObjectOfType<BallController>().perfectPass++;
    }
}
