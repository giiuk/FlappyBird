using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoY;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private UIScript scriptDaUI;
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY,variacaoY));
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.pontuei && this.transform.position.x < posicaoPassaro.x)
        {
            Debug.Log("Pontuou");
            this.pontuei = true;
            this.scriptDaUI.adicionarPonto();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<UIScript>();
    }


  /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }*/

}
