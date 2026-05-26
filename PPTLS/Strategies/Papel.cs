namespace PPTLS.Strategies;
public class Papel : IJugada{
    public string Nombre => "Papel";
    public string ResolverContra(IJugada oponente){
        /*if (oponente is Tijera)
        return "Gana: Piedra rompe Tijera";
        
        AGREGAR LAS DEMÁS REGLAS*/
    return "0";
}
}