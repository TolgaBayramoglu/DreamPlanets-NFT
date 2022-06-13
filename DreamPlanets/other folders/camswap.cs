using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswap : MonoBehaviour
{
    public GameObject[] gameCameras;//kameralar�n dizisini tan�mla
    int gameCameraIndex = 0;//kamera indeksi diye bir de�i�ken tan�mla
    void CameraIndex(int index)//kamera indeksi olu�turan fonksiyon
    {
        for (int i = 0; i < gameCameras.Length; i++)
        {
            gameCameras[i].SetActive(index == i);
        }
    }

    void changeCamera(int change)
    {
        gameCameraIndex += change;
        if (gameCameraIndex >= gameCameras.Length)
        {
            gameCameraIndex = 0;
        }

        if (gameCameraIndex < 0)
        {
            gameCameraIndex = gameCameras.Length - 1;
        }

        CameraIndex(gameCameraIndex);
    }


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            changeCamera(1);//fonksiyon �a��r�larak kamera �nceki indise gider
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            changeCamera(-1);//fonksiyon �a��r�larak kamera sonraki indise gider
        }


    }

}
