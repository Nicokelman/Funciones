using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EscribirHolaMundoEnConsola();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirCadenaEnConsola("Acá tenes tu argumento");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(RetornaRandomEntre(1, 11));
        }
    }
    public void DestruirObjeto()
    {
        Destroy(gameObject);
    }

void EscribirHolaMundoEnConsola()
    {
        Debug.Log("HolaMundo!");
    }

    void EscribirCadenaEnConsola(string cadena)
    {

        Debug.Log(cadena);
    }

    string RetornaJeronimo()
    {
        return "Jeronimo";
    }

    int RetornaRandomEntre(int n1, int n2)
    {
        if (n1>=0 && n2>0) {
            return Random.Range(n1, n2);
        }
        else
        {
            return -1;
        }
    }
}
