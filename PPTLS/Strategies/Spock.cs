namespace PPTLS.Strategies;
public class Spock : IJugada{
    public string Nombre => "Spock";
    public string ResolverContra(IJugada oponente){
        /*if (oponente is Tijera)
        return "Gana: Piedra rompe Tijera";
        
        AGREGAR LAS DEMÁS REGLAS*/
    return "0";
}
}