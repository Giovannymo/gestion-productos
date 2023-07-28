namespace gestionProductos{
    public class Producto{
        public  int Codigo {set;get;}
        public string Nombre {set;get;}
        public int Precio {set;get;}
        public int Inventario  {set;get;}
        public List<dynamic> Clientes = new List<dynamic>();

        public Producto (int codigo, string nombre, int precio, int inventario){
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Inventario = inventario;
        }


        public void MostrarDetalles(){
            Console.WriteLine("Informaciòn del producto: ");
            Console.WriteLine($"Codigo: #{Codigo}"+"\n"
                            +$"Nombre: {Nombre}"+"\n"
                            +$"Precio: ${Precio}"+"\n"
                            +$"Inventario: {Inventario} unidades."+"\n"
                            );
        }
        public void ActualizarPrecio(int precio){
             Precio = precio;
        }
        public void ActualizarInventario(int inventario){
             Inventario = inventario;
        }   
        void ActualizarClientes(string cliente){
             Clientes.Add(cliente);
        }

    }
}