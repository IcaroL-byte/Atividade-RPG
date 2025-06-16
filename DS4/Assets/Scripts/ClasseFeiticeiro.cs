using System;
using UnityEngine;

public class ClasseFeiticeiro : Personagem
{
    public string nome;
    public float mana;
    public float inteligencia;
    public int conhecimento;
    public int destreza;
    [SerializeField] 
    private CajadoMago magoArma;
    [SerializeField]
    private Habilidade habilidade;
    [SerializeField] 
    private Ultimate magoSpecial;
    public float numeroDaArma;
    public float numeroDaHabilidade;
    public float numeroDaUlti;
    
    
    //setando o cajado
    public enum CajadoMago
    {
        Cajado_caótico, Catalizador_Izalith, Catalizador_Oriental
    }
    
    public void MudarArma(CajadoMago arma)
    {
        this.magoArma = arma;
    }

    public CajadoMago Arma
    {
        get {return this.magoArma;}
    }
    
    //Setando Habilidade
    public enum Habilidade
    {
        Magia_caótica, Magia_Divina
    }
    
    public void MudarHabilidade(Habilidade habilidade)
    {
        this.habilidade = habilidade;
    }

    public Habilidade HabilidadeMago
    {
        get {return this.habilidade;}
    }
    
    //Setando Ultimate
    public enum Ultimate
    {
        Explosão_Arcana, Sopro_Do_Dragão
    }
    
    public void MudarUltimate(Ultimate magoSpecial)
    {
        this.magoSpecial = magoSpecial;
    }

    public Ultimate UltimateMago
    {
        get {return this.magoSpecial;}
    }
    
    //definições nome
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return this.nome;
    }

    //definições Mana
    public void SetMana(float mana)
    {
        this.mana = mana;
    }

    public float GetMana()
    {
        return this.mana;
    }

    //definições Mana
    public void SetInteligencia(float inteligencia)
    {
        this.inteligencia = inteligencia;
    }

    public float GetInteligencia()
    {
        return this.inteligencia;
    }

    //definições conhecimento
    public void SetConhecimento(int conhecimento)
    {
        this.conhecimento = conhecimento;
    }

    public int GetConhecimento()
    {
        return this.conhecimento;
    }

    //definições destreza
    public void SetDestreza(int destreza)
    {
        this.destreza = destreza;
    }

    public int GetDestreza()
    {
        return this.destreza;
    }
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        DanoDoInimigo();
        HabilidadeBase();
        UltimateBase();
    }
    
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (magoArma)
        {
            case CajadoMago.Cajado_caótico:
                dano = forcaDoPlayer() + 10;
                numeroDaArma = 1;
                break;
            case CajadoMago.Catalizador_Izalith:
                dano = forcaDoPlayer() + 12;
                numeroDaArma = 2;
                break;
            case CajadoMago.Catalizador_Oriental:
                dano = forcaDoPlayer() + 22;
                numeroDaArma = 3;
                break;
        }
        
        // dano do ataque com a arma
        
        return dano;
    }

    public int HabilidadeBase()
    {
        int dano = 0;

        switch (habilidade)
        {
            case Habilidade.Magia_caótica:
                dano = forcaDoPlayer() + 10;
                numeroDaHabilidade = 1;
                break;
            case Habilidade.Magia_Divina:
                dano = forcaDoPlayer() + 12;
                numeroDaHabilidade = 2;
                break;
            
        }
        
        // dano do ataque com a arma
        
        return dano;
    }
    
    public int UltimateBase()
    {
        int dano = 0;

        switch (magoSpecial)
        {
            case Ultimate.Explosão_Arcana:
                dano = forcaDoPlayer() + 20;
                numeroDaUlti = 1;
                break;
            case Ultimate.Sopro_Do_Dragão:
                dano = forcaDoPlayer() + 32;
                numeroDaUlti = 2;
                break;
            
        }
        
        // dano do ataque com a arma
        
        return dano;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("inimigo"))
        {
            if (numeroDaArma == 1)
            {
                Debug.Log("voce deu " + (forca_Ataque + 10) + " de dano");
                mana +=1;
                Debug.Log("Seu personagem está com " + mana + " de mana");
            }

            else if (numeroDaArma == 2)
            {
                Debug.Log("voce deu " + (forca_Ataque + 12) + " de dano");
                mana +=1;
                Debug.Log("Seu personagem está com " + mana + " de mana");
            }

            else
            {
                Debug.Log("voce deu " + (forca_Ataque + 22) + " de dano");
                mana +=1;
                Debug.Log("Seu personagem está com " + mana + " de mana");
            }
        }
    }
}
