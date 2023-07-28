using gestionProductos;



internal class Program{
    public static void Main(string[] args){
        List<dynamic>   list = new List<dynamic>(); 
        List<Producto>  productos = new List<Producto>(); 
        bool next=true;


    do{
        Console.WriteLine("Nombre de cliente: ");
        string ? cliente = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n ========== MENÚ ========== \n");
        Console.ResetColor();
        Console.Write("1.Agregar nuevo productos. \n"+
                    "2.Mostrar producto especìfico. \n"+
                    "3.Mostrar lista de productos. \n"+
                    "4.Actualizar precio producto. \n"+
                    "5.Actualizar inventario producto. \n"+
                    "6.Actualizar listado clientes. \n"+
                    "0.Salir.\n");

      int ? select = int.Parse(Console.ReadLine());

      switch(select){
        case 1:
            Console.Write("Ingrese el codigo del producto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            string ? nombre = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            int precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            Producto producto = new Producto(codigo, nombre, precio, cantidad);
            producto.Clientes.Add(cliente);
            productos.Add(producto);
        break;
        case 2: 
            Console.Write("Ingrese el còdigo a buscar: ");
            int buscarCodigo = int.Parse(Console.ReadLine());
            foreach (var item in productos){
                if(item.Codigo == buscarCodigo){
                    item.MostrarDetalles();
                }
                    
            }
        break;
        case 3:
          //ImportantSelect();          
        break;
        case 4:
          //ShowContacts(directoryImportant);
        break;
        case 0: 
            next = false;
        break;
      }
      
    }while(next);
    }
}