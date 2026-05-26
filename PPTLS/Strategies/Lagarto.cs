namespace PPTLS.Strategies;
public class Lagarto : IJugada{
    public string Nombre => "Lagarto";
    public string ResolverContra(IJugada oponente){
        /*if (oponente is Tijera)
        return "Gana: Piedra rompe Tijera";
        
        AGREGAR LAS DEMÁS REGLAS*/
    return "0";
}
}