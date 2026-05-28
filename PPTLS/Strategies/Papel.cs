namespace PPTLS.Strategies;
public class Papel : IJugada{
    public string Nombre => "Papel";
    public string ResolverContra(IJugada oponente){
        if (oponente is Piedra){
            return "Gana: Papel cubre piedra";
        }
        else if (oponente is Spock){
            return "Gana: Papel cubre Spock";
        }
        else if (oponente is Tijera){
            return "Pierde: Tijera corta Papel";
        }
        else if (oponente is Lagarto){
            return "Pierde: Lagarto come Papel";
        }
        else{
            return "Empate";
        }
    }
}