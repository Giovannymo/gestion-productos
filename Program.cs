using gestionProductos;

internal class Program{
    public static void Main(string[] args){
        List<Producto>  productos = new List<Producto>(); 
        bool next=true;


    do{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n ========== MENÚ ========== \n");
        Console.ResetColor();
        Console.Write("1.Agregar nuevo productos. \n"+
                    "2.Mostrar producto especìfico. \n"+
                    "3.Mostrar lista de productos. \n"+
                    "4.Actualizar precio producto. \n"+
                    "5.Actualizar inventario producto. \n"+
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
            foreach (var item in productos){
                item.MostrarDetalles();
            }
   
        break;
        case 4:

            Console.Write("Ingrese el codigo del producto para actualizar: ");
            int actualizarCodigo = int.Parse(Console.ReadLine());
             foreach (var item in productos){
                if(item.Codigo == actualizarCodigo){
                    Console.Write("Ingrese el nuevo precio: ");
                    int nuevoPrecio = int.Parse(Console.ReadLine());
                    item.ActualizarPrecio(nuevoPrecio);
                    Console.WriteLine("Cambio éxitoso. ");
                }else{
                    Console.WriteLine("Ingrese un codigo existente.");
                }
                    
            }
        break;

        case 5:
            Console.Write("Ingrese el codigo del producto para actualizar: ");
            int actualizarInventario = int.Parse(Console.ReadLine());
             foreach (var item in productos){
                if(item.Codigo == actualizarInventario){
                    Console.Write("Ingrese el nuevo stock: ");
                    int nuevoStock = int.Parse(Console.ReadLine());
                    item.ActualizarInventario(nuevoStock);
                    Console.WriteLine("Cambio éxitoso. ");
                }else{
                    Console.WriteLine("Ingrese un codigo existente.");
                }
                    
            }
        break;
        case 0: 
            next = false;
        break;
      }
      
      
    }while(next);
    }
}