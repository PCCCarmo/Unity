using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoR : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float forcapulo = 600f;
    public bool direita = true;
    public float moveX;
    private Rigidbody2D objeto;
    private Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        objeto = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();

    }

    void Mover()
    {
        moveX = Input.GetAxis("Console");
        if (moveX > 0 && !direita)
        {
            virarPersonagem();
        }
        else if (moveX < 0 && direita)
        {
            virarPersonagem();
        }
        objeto.velocity = new Vector2(moveX * velocidade, objeto.velocity.y);
    }
    void virarPersonagem()
    {
        direita = !direita;
        Vector3 scale = GetComponent<Transform>().localScale;
        scale.x *= -1;
        GetComponent<Transform>().localScale = scale;
    }
    // Update is called once per frame
    void Update()
    {
        Mover();
    }
}
