using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public UIScript cm;
    [SerializeField]
    private float velocidade = 3;
    //cria a variavel fisica do tipo Rigidbody
    Rigidbody2D fisica;

    public GameOver game;
    
    //método Awake é chamado toda vez que o objeto é criado
    private void Awake(){
    //adiciona à variavel física o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    //métodos private somente nossa classe pode acessar
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
    
            //chama o método impulsionar
            //o this serve para indicar que é o objeto ativo naquele momento que recerá ação
            this.Impulsionar();
        }
    }
    //método que impulsiona nosso pássaro
    private void Impulsionar(){
    //adiciona a variável física e o método AddForce, adicionando uma força para cima do tipo impulso
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            cm.adicionarPonto();
            Debug.Log(cm.coinCount);
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        game.GameOverActive();
    }
}
