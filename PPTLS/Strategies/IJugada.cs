namespace PPTLS.Strategies;
public interface IJugada{
    string Nombre { get; }

    //Se implementa el método que se utilizará para definir interacciones
    string ResolverContra(IJugada oponente);
}