using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float vida;
    public int forca_Ataque;
    public float velocidade;
    public float jump_Forca;

    //função da vida
    public void SetVida(float vida)
    {
        this.vida = vida;
    }

    public float vidaDoPlayer()
    {
        return this.vida;
    }

    //função da força
    public void SetForca(int forca_Ataque)
    {
        this.forca_Ataque = forca_Ataque;
    }

    public int forcaDoPlayer()
    {
        return this.forca_Ataque;
    }
    
    //função velocidade
    public void SetVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float velocidadeDoPlayer()
    {
        return this.velocidade;
    }
    
    //função pulo
    public void SetJump(float jump_Forca)
    {
        this.jump_Forca = jump_Forca;
    }

    public float puloDoPlayer()
    {
        return this.jump_Forca;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
