using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private float vm; //Velocidade de movimento

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;
        this.rb.velocity = direcao * this.vm;
    }
}
