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

    //setando o cajado
    public enum CajadoMago
    {
        Magia_caótica, Catalizador_Izalith, Catalizador_Oriental
    }
    
    public void MudarArma(CajadoMago arma)
    {
        this.magoArma = arma;
    }

    public CajadoMago Arma
    {
        get {return this.magoArma;}
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
        
    }
    
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (magoArma)
        {
            case CajadoMago.Magia_caótica:
                dano = forcaDoPlayer() + 10;
                break;
            case CajadoMago.Catalizador_Izalith:
                dano = forcaDoPlayer() + 12;
                break;
            case CajadoMago.Catalizador_Oriental:
                dano = forcaDoPlayer() + 22;
                break;
        }
        
        // dano do ataque com a arma
        
        return dano;
    }
    
}
