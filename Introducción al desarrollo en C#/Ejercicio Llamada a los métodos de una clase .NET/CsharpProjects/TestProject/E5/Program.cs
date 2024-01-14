//Desafío de código: Notificar los identificadores de pedido que necesitan una investigación más detallada

/*El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para investigar más en profundidad.
Siga estos pasos para completar este desafío.
Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.
Si es necesario, abra Visual Studio Code y, luego, lleve a cabo los pasos siguientes para preparar un archivo Program.cs en el editor:
En el menú Archivo, seleccione Abrir carpeta.
Use el cuadro de diálogo "Abrir carpeta" para ir a la carpeta CsharpProjects.
En el panel EXPLORADOR de Visual Studio Code, seleccione Program.cs.
En el menú Selección de Visual Studio Code, elija Seleccionar todo y presione la tecla Supr.
*/

//Declare una matriz e inicialícela para que contenga los siguientes elementos:

string[] ids = {"B123","C234","A345", "C15", "B177", "G3003", "C235", "B179"};
string[] idsWithB = {};
foreach (string id in ids){
if (id.StartsWith("B"))
{
    Console.WriteLine($"{id}");
}    
}





