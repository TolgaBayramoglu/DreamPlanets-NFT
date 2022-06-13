using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camswap : MonoBehaviour
{
    public GameObject[] gameCameras;//kameralarýn dizisini tanýmla
    int gameCameraIndex = 0;//kamera indeksi diye bir deðiþken tanýmla
    void CameraIndex(int index)//kamera indeksi oluþturan fonksiyon
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
            changeCamera(1);//fonksiyon çaðýrýlarak kamera önceki indise gider
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            changeCamera(-1);//fonksiyon çaðýrýlarak kamera sonraki indise gider
        }


    }

}
