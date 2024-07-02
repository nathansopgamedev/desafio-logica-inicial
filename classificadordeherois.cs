public class Classificador : MonoBehavior 
{
    [SerializeField]private string name = "Pedro";
    [SerializeField]private float xp = 5998f;


    void start ()
    {
        Classificar();
    }

    void Classificar()
    {
        if(xp < 1000){
            print("O herói de nome " + name + "está no nível de Ferro");
        } else if (xp > 1000 || <= 2000){
            print("O herói de nome " + name + "está no nível de Bronze");
        } else if (xp > 2000 || <= 5000){
            print("O herói de nome " + name + "está no nível de Prata");
        } else if (xp > 5000 || <= 7000){
            print("O herói de nome " + name + "está no nível de Ouro");
        } else if (xp > 7000 || <= 8000){
            print("O herói de nome " + name + "está no nível de Platina");
        } else if (xp > 8000 || <= 9000){
            print("O herói de nome " + name + "está no nível de Ascendente");
        } else if (xp > 9000 || <= 10000){
            print("O herói de nome " + name + "está no nível de Imortal");
        } else if(xp >= 10001) {
            print("O herói de nome " + name + "está no nível de Radiante");
        }
        
    }
}