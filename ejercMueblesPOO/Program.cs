namespace ejercMueblesPoo
{
    // Crear una clase llamada Mueble que tenga los siguientes atributos: nombre, alto, ancho, material, cantidad.
    //● Crear 3 muebles utilizando parámetros.
    //● Mostrar por pantalla el nombre y el material de los 3 muebles.
    //● Colocar “Madera” como material de los 3 muebles creados. (pista a traves de
    //los setters)
    //● Mostrar nuevamente por pantalla el nombre y el material de los 3 muebles
    //que fueron cambiados.
    public class Program
    {
        static void Main(string[] args)
        {
            //creación de muebles
            Muebles mesaDeLuz = new Muebles();
            Muebles placard = new Muebles();
            Muebles escritorio = new Muebles();

            //Utilizo set para asignar nombre y material
            mesaDeLuz.SetNombre("Madrid Escandinava");
            mesaDeLuz.Setmaterial("Madera");

            placard.SetNombre("Gran Paraíso");
            placard.Setmaterial("Madera");

            escritorio.SetNombre("Escocia");
            escritorio.Setmaterial("Madera");

            //Utilizo un get para mostrar el nombre y el material
            Console.WriteLine("El nombre de la mesa de luz es: " + mesaDeLuz.GetNombre());
            Console.WriteLine("Está confeccionada con: " + mesaDeLuz.GetMaterial());

            Console.WriteLine("El nombre del Placard es: " + placard.GetNombre());
            Console.WriteLine("Está confeccionado con: " + placard.GetMaterial());


        }


        public class Muebles
        {
            //atributos
            private string nombre;
            private int alto;
            private int ancho;
            private string material;
            private int cantidad;

            //constructor con parametro, si lo creo con esto y luego utilizo el setNombre no funciona, entonces no se para que es el constructor
            /* public Muebles(string nombre, int alto, int ancho, string material, int cantidad)
             {
                 this.nombre = nombre;
                 this.alto = alto;
                 this.ancho = ancho;
                 this.material = material;
                 this.cantidad = cantidad;

             }*/


            //Get y Set nombre
            public string GetNombre()
            {
                return nombre;
            }
            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }


            // get y set de Material

            public string GetMaterial()
            {
                return material;
            }
            public void Setmaterial(string material)
            {
                this.material = material;
                //material = "pino blanco"; // esto no funciona 
            }

        }
    }
}