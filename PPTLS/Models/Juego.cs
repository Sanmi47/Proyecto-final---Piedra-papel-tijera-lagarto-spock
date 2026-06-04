using PPTLS.Strategies;
namespace PPTLS.Models;
public class Juego{
    public Jugador JugadorHumano { get; private set; }
    public Jugador CPU { get; private set; }
    private List<IJugada> jugadas;
    private Random random;
    public int PuntosJugador { get; private set; }
    public int PuntosCPU { get; private set; }
    public int Empates { get; private set; }
    
    //Se inicializa el juego
    public Juego(){
        JugadorHumano = new Jugador("Jugador");
        CPU = new Jugador("CPU");
        
        //Se crea la lista de jugadas para que el CPU haga uso de ellas más adelante
        jugadas = new List<IJugada>()
        {
            new Piedra(),
            new Papel(),
            new Tijera(),
            new Lagarto(),
            new Spock()
        };
        random = new Random();
    }
    public string Jugar(IJugada jugadaHumana){
        //"JugadorHumano" recibe la jugada seleccionada
        JugadorHumano.ElegirJugada(jugadaHumana);

        //CPU recibe su jugada de manera aleatoria usando la lista creada anteriormente
        IJugada jugadaCPU = ObtenerJugadaAleatoria();
        
        //Se dicta el ganador usando ResolverContra()
        string resultado = jugadaHumana.ResolverContra(jugadaCPU);
        ActualizarMarcador(resultado);

        //Se retorna el resultado de la interracción
        return $"Jugador eligio: {jugadaHumana.Nombre}" + $"\nCPU eligio: {jugadaCPU.Nombre}" + $"\n{resultado}";
    }
    private IJugada ObtenerJugadaAleatoria(){
        int indice = random.Next(jugadas.Count);
        return jugadas[indice];
    }

    public string ActualizarMarcador(string resultado){
        return resultado;
    }

}