using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    public CoinManager cm;
    private Label textoPontuacao;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }

    public void adicionarPonto()
    {
        cm.coinCount++;
    }
    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
            Debug.Log(textoPontuacao.text);
                adicionarPonto();
                this.textoPontuacao.text = cm.coinCount.ToString();
                Destroy(other.gameObject);
               
                Debug.Log(cm.coinCount);
               
            }
          
        }
   
       
   
    
    
}
