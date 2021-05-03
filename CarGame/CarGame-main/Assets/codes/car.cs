using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float carSpeed;
    float horiztontal;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        carMoving();
    }

    void carMoving()
    {
        horiztontal = Input.GetAxis("Horizontal");
        rigid.AddForce(new Vector3(horiztontal * carSpeed, 0, 0));
    }



}
