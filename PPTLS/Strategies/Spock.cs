namespace PPTLS.Strategies;
public class Spock : IJugada{
    public string Nombre => "Spock";
    public string ResolverContra(IJugada oponente){
        if (oponente is Piedra){
            return "Gana: Spock mata Piedra";
        }
        else if (oponente is Tijera){
            return "Gana: Spock rompe Tijera";
        }
        else if (oponente is Lagarto){
            return "Pierde: Lagarto come Spock";
        }
        else if (oponente is Papel){
            return "Pierde: Papel cubre Spock";
        }
        else{
            return "Empate";
        }
    }
}