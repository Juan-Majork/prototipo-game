using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaMugre : MonoBehaviour
{
    private int vida = 1;
    private GameObject exitLevel;

    // Start is called before the first frame update
    void Start()
    {
        exitLevel = GameObject.FindGameObjectWithTag("Puerta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tomarDanio(int danio)
    {
        vida -= danio;
        if(vida <= 0)
        {
            exitLevel.GetComponent<ExitLevel>().juntarTareas();
            Destroy(gameObject);
        }
    }
}
