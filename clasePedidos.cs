public class Pedidos
{
    public int Nro;
    public string Obs;
    public int Cliente;
    public bool estado;

    
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