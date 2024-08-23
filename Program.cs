/* 1Pedido -> 1Cliente
1Cadete -> +1Pedido

delete
	pedido -> cliente

--1Pedido puede cambiar de Cadete

Mostrar informe sobre la actividad de la Cadeteria.*/

//CORRECCION: Cada Cliente forma parte de 1Pedido
            //Cada Cadete puede tener 1 o +1Pedido

//CARGAR LISTADO DE CADETES POR CSV (datos precargados tipo excel separados por coma)

Cadeteria CadeteriaYa = new Cadeteria();


Console.WriteLine("Bienvenido a Cadeteria Ya!");
Console.WriteLine("1-Alta Pedido");
Console.WriteLine("2-Asignar Cadete");
Console.WriteLine("3-Cambiar Estado Pedido");
Console.WriteLine("4-Reasignar Pedido a Cadete");
System.Console.WriteLine("5-Generar Informe Jornada.");