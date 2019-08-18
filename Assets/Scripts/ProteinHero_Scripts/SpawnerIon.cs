using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerIon : MonoBehaviour
{
    private int segura;
    public int espera;
    public GameObject Ion_Azul;
    public GameObject Ion_Vermelho;
    public GameObject Ion_Amarelo;
    public GameObject Ion_Laranja;
    public GameObject Ion_Verde;
    public GameObject Ion_Rosa;


    // Start is called before the first frame update
    void Start()
    {
        segura = espera;
    }

    // Update is called once per frame
    void Update()
    {
        segura -= 1;
        if (segura <= 0)
        {
            segura = espera;
            int quant = Random.Range(1, 3);
            for (int i = 0; i <= quant; i++)
            {
                int qual = Random.Range(1, 7);

                switch (qual)
                {
                    case 1:
                        Instantiate(Ion_Azul, new Vector2(-7.5f, 7), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Ion_Amarelo, new Vector2(-4.5f, 7), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(Ion_Verde, new Vector2(-1.5f, 7), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(Ion_Vermelho, new Vector2(1.5f, 7), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(Ion_Rosa, new Vector2(4.5f, 7), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(Ion_Laranja, new Vector2(7.5f, 7), Quaternion.identity);
                        break;
                }
            }
        }
    }
}
