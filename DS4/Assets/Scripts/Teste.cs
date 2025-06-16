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
        if (Input.GetKeyDown(KeyCode.Space) && classeFeiticeiro.mana >= 50)
        {
            if (classeFeiticeiro.numeroDaHabilidade == 1)
            {
                Debug.Log("Voce causou " + (personagem.forca_Ataque + 10) + " de dano");
                classeFeiticeiro.mana -= 50;
                Debug.Log("Seu personagem está com " + classeFeiticeiro.mana + " de mana");
            }

            else
            {
                Debug.Log("Voce causou " + (personagem.forca_Ataque + 12) + " de dano");
                classeFeiticeiro.mana -= 50;
                Debug.Log("Seu personagem está com " + classeFeiticeiro.mana + " de mana");
            }
        }
        
        if (Input.GetKeyDown(KeyCode.X) && classeFeiticeiro.mana >= 100)
        {
            if (classeFeiticeiro.numeroDaUlti == 1)
            {
                Debug.Log("Voce causou " + (personagem.forca_Ataque + 20) + " de dano com a Explosão Arcana");
                classeFeiticeiro.mana -= 100;
                Debug.Log("Seu personagem está com " + classeFeiticeiro.mana + " de mana");
            }

            else
            {
                Debug.Log("Voce causou " + (personagem.forca_Ataque + 32) + " de dano com o Sopro do Dragao");
                classeFeiticeiro.mana -= 100;
                Debug.Log("Seu personagem está com " + classeFeiticeiro.mana + " de mana");
            }
        }
    }
    
    
    
}
