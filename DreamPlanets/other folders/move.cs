using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.D))//sað   //input.getkey klavyeden girdi//keycode.d klavye karakterinin kodu
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);//translate hareket ettirme//x y z ekseni //x*Time.deltaTime sabit hýz  
        }

        if (Input.GetKey(KeyCode.A))//sol
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        ///////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.W))//ileri
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))//geri
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        ///////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.E))//sola dön
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Q))//saða dön
        {
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
        ///////////////////////////////////////////////////////////////////////////
        if (Input.GetKey(KeyCode.Space))//yukarý
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Z))//aþaðý
        {
            transform.Translate(0, -speed * Time.deltaTime,0 );
        }

    }
}
