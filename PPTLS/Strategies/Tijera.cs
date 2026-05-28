namespace PPTLS.Strategies;
public class Tijera : IJugada{
    public string Nombre => "Tijera";
    public string ResolverContra(IJugada oponente){
        if (oponente is Papel){
            return "Gana: Tijera corta Papel";
        }
        else if (oponente is Lagarto){
            return "Gana: Tijera mata Lagarto";
        }
        else if (oponente is Piedra){
            return "Pierde: Piedra rompe Tijera";
        }
        else if (oponente is Spock){
            return "Pierde: Spock rompe Tijera";
        }
        else{
            return "Empate";
        }
}
}