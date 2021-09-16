using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerSnake : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        //добавить свитч оператор
        if (other.gameObject.GetComponent<MeshRenderer>().material.color == GameController.s.currCollorSnake)
        {
            //кушаем человечков
        }
        else GameController.s.GameOver();
        // диаманты
        // бомбы
    }
}
