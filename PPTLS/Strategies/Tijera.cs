namespace PPTLS.Strategies;
public class Tijera : IJugada{
    public string Nombre => "Tijera";
    public string ResolverContra(IJugada oponente){
        /*if (oponente is Tijera)
        return "Gana: Piedra rompe Tijera";
        
        AGREGAR LAS DEMÁS REGLAS*/
    return "0";
}
}