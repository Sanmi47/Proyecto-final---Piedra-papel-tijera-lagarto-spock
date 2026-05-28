namespace PPTLS.Strategies;
public class Piedra : IJugada{
    public string Nombre => "Piedra";
    public string ResolverContra(IJugada oponente){
    if (oponente is Tijera){
            return "Gana: Piedra rompe Tijera";
        }
        else if (oponente is Lagarto){
            return "Gana: Piedra mata Lagarto";
        }
        else if (oponente is Papel){
            return "Pierde: Papel cubre Piedra";
        }
        else if (oponente is Spock){
            return "Pierde: Spock mata Piedra";
        }
        else{
            return "Empate";
        }
    }
}