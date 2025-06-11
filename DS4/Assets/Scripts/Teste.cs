using UnityEngine;

public class Teste : MonoBehaviour
{
    private Personagem personagem;
    private ClasseFeiticeiro classeFeiticeiro;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        personagem = GetComponent<Personagem>();
        classeFeiticeiro = GetComponent<ClasseFeiticeiro>();
        
        //
        Debug.Log("Seu nome é " + classeFeiticeiro.nome);
        Debug.Log("Seu personagem está com " + personagem.vida +" de vida");
        Debug.Log("Seu ataque é igual a " + personagem.forca_Ataque);
        Debug.Log("Sua velocida é igual a " + personagem.velocidade);
        Debug.Log("A força do pulo é " + personagem.jump_Forca);
        
        //
        Debug.Log("Seu personagem está com " + classeFeiticeiro.mana + " de mana");
        Debug.Log("Você está com " + classeFeiticeiro.inteligencia + " de inteligencia");
        Debug.Log("Você tem " + classeFeiticeiro.conhecimento + " de conhecimento");
        Debug.Log("Sua destreza é igual a " + classeFeiticeiro.destreza);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
}
