using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscobaFunction : MonoBehaviour
{
    [SerializeField] public int danio;
    [SerializeField] private float tiempoActual;
    [SerializeField] private float tiempoDeVida;

    public int tareaHecha = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActual += Time.deltaTime;

        if(tiempoActual > tiempoDeVida)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mugre"))
        {
            collision.GetComponent<vidaMugre>().tomarDanio(danio);
            
        }
    }
}
