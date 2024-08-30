public class Pedidos
{
    public int Nro {get; set;}
    public string Obs {get; set;}
    public int Cliente {get; set;}
    public bool estado {get; set;}

    
    public string VerDireccionCliente(){
        string direccion="calle1";//ejemplo
        return direccion;
    }
    public string VerDatosCliente(){
        string datosCliente="Pepe Perez";//ejemplo
        return datosCliente;
    }

    //referencia a clase Cadete
    public void verDatosCadeteACargo(){

    }
}