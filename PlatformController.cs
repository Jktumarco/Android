

using System.Collections.Generic;
using UnityEngine;


public class PlatformController : MonoBehaviour
{
    public List<Platforms> platform;
    public GameObject diamands;
    public GameObject bombs;
    public GameObject humans;
    public List<Transform> points;
    public List<Color> colors;

    public Material mat;


    public static PlatformController s;
    // добавать вей-поиты для расположения предметов на платформе
    // добавить рандом для разных предметов на платформе;
    // счетчик добавить до 40 сек
    // границы
    // генерацию человечков группами одного цвета, рандомно от 2 -х до 5-ти
    // анимацию сьедения человечков
    // условия проигрыша
    // слежение камеры за геймплеем

    private void Awake()
    {
       
        if(s == null) { s = this; }
    }
    private void Start()
    {
       
    }


    public void SetColors(int indx )
    {
        mat.color = colors[indx];
    }

    [System.Obsolete]
    public float Randoms(float max)
    {
       return Random.RandomRange(0, max);
    }

    [System.Obsolete]
    public void MakeHumans()
    {
        int r = (int)Randoms(points.Count);
        GameObject go = Instantiate(humans, points[r]);
    }
    public void MakeDimands() { }

    public void MakeBombs() { }


    public void MakePlatform() {
        MakeHumans();
        MakeBombs();
        MakeDimands();
    }

        


    public void AnimationDeadHumans()
    {

    }

}


