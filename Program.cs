string nombreUsuario = "Juan";
string apellidoUsuario = "Carlos";
int edadUsuario = 32;
float altura = 5.9F;
bool esCasado = true;
decimal sueldo = 23459.87M;
char inicial = 'J';

Console.WriteLine($"Hola, mi nombre es {nombreUsuario} {apellidoUsuario}.");
Console.WriteLine($"Tengo {edadUsuario} años de edad.");
Console.WriteLine($"Mido {altura} pulgadas.");
Console.WriteLine($"Estoy casado: {esCasado}");
Console.WriteLine($"Mi sueldo es de {sueldo}");
Console.WriteLine($"La inicial de mi nombre {inicial}");

// Solicitar al usuario datos

Console.Write("Ingrese su nombre: ");
string? nombre = Console.ReadLine();

Console.Write("Ingrese su apellido: ");
string? apellido = Console.ReadLine();

Console.Write("Ingresa la edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre} {apellido}");
Console.WriteLine($"Tengo {edad} años de edad.");

//Estructura condicional
if (edad > 18) {
  Console.WriteLine("\nEres mayor de edad!");
}
else {
  Console.WriteLine("\nEres menor de edad");
}

// Estructura repetitivas o bubles
int i = 1;

while (i <= 10) {
  Console.WriteLine(i);

  i = i + 1;
  // i += 1;
  // i++;
}

bool iniciar = true;
string? respuesta;

while (iniciar) {
  Console.WriteLine("Bienvenido a mi aplicación!!!");

  Console.Write("¿Desea continuar? (s/n): ");
  respuesta = Console.ReadLine();

  if (respuesta == "n") {
    iniciar = false;
    // break;
  }
  // Console.Write("¿Desea continuar? ");
  // iniciar = Convert.ToBoolean(Console.ReadLine());
}

for (int indice = 1; i <= 12; i++) {
  Console.WriteLine(indice);
}

// Estructuras de datos

// Arreglos -> Estructura estática -> Su longitud no cambia
string[] nombres = ["Juan", "Carlos", "Pedro"];


Array.ForEach(nombres, (nombre) => {
  Console.WriteLine($"Bienvenido a esta clase {nombre}!");
});

// Listas -> Son flexibles, su longitud puede cambiar
List<string> usuarios = ["María", "Pablo", "José"];

usuarios.Add("Michael");

usuarios.ForEach(nombre => {
  Console.WriteLine($"Bienvenido a esta clase {nombre}!");
});
