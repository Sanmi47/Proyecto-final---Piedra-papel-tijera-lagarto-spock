namespace PPTLS.Strategies;
public class Lagarto : IJugada{
    public string Nombre => "Lagarto";
    public string ResolverContra(IJugada oponente){
        if (oponente is Papel){
            return "Gana: Lagarto come Papel";
        }
        else if (oponente is Spock){
            return "Gana: Lagarto come Spock";
        }
        else if (oponente is Tijera){
            return "Pierde: Tijera mata Lagarto";
        }
        else if (oponente is Piedra){
            return "Pierde: Piedra mata Lagarto";
        }
        else{
            return "Empate";
        }
    }
}