## Proyecto Final CxC Programacion II

_Hola, somos el grupo #2 y este es nuestro proyecto final. Se trata sobre una aplicación de Cuentas Por Pagar._

### Autores ✒️

**Integrantes:** (La parte que aporto y enlace a su github personal respectivamente)

* **Ludwig Cabrera** - *Clientes* - [Ludwig](https://github.com/md5-loki)
* **Gilberto Ubiera** - *Tipos de Documento* - [Gilberto](https://github.com/Diretol00)
* **Carlos Henriquez** - *Balances y Transacciones* - [Carlos](https://github.com/Carlos-Henriquez)

<hr>

## Comenzando 🚀

_Para probar el proyecto puedes a traves de tu terminal de git bash hacer clone o descargar directamente desde aquí en un comprimido._

_Teniendo en cuenta que tienes que tener una base de datos en SQL Server (con la estructura del proyecto) y modificar el acceso en el código._


## Pre-requisitos 📋


Para utilizar esta aplicación necesitas:
- Visual Studio 2019 o cualquier versión compatible.
- SQL Server (con la estructura de datos del proyecto).
- NET Framework 3.4 en adelante instalado en tu máquina.
- Conocimiento basico en C# Windows Forms y SQL Server para poder editar el acceso a base de datos.


## Instalación 🔧

Instalación paso a paso del proyecto:

Paso #1

Despues de haber descargado/clonado el proyecto debemos abrir el archivo .sln que se encuentra en la raiz del proyecto.

![SC1](https://i.imgur.com/RpXYYjv.png)

Paso #2

Ya que tenemos el proyecto abierto en nuestro Visual Studio debemos irnos a las diferentes capas de datos y alterar la conexion, para que haga referencia a nuestra base de datos.

![SC2](https://i.imgur.com/3aujkP2.png)

Paso #3

Luego de haber alterado las lineas para nuestra base de datos, debemos crearla. Para ello te dejamos los scripts con la estructura necesaria:

```
https://pastebin.com/a0rqRneC
```

_Luego de haber realizado los 3 pasos correctamente podremos ejecutar nuestro proyecto desde Visual Studio y veremos la navegacion de esta manera:_

![SC3](https://i.imgur.com/2rfhUx9.png)

<hr>

## Clientes 🧑
Similar a todas las partes del proyecto utiliza la programacion multicapas con su capa de presentacion, negocios y acceso a datos.

En la parte de clientes tenemos el mantenimiento principal con su opcion de agregar, eliminar y editar:

![SC4](https://i.imgur.com/CI8aAOU.png)

En la parte de agregar tenemos lo siguiente, nos permite agregar nuevos clientes:

![SC5](https://i.imgur.com/vunWfNw.png)

<hr>

## Tipos de Documentos 📃
Esta parte del proyecto (como todas las otras) utliza la programación multicapas que contiene su capa de presentación, negocios y acceso a datos
como se mencionan en apartados anteriores. 

Como podremos ver en la imagen de abajo tenemos un formulario donde se pueden agregar, modificar y eliminar los campos que se muestran tipo tabla: 

![TD1]((https://imgur.com/j0LggmT)

Cuando seleccionamos una fila de la tabla, los textboxs se llenan con sus respectiva información seleccionada, cada campo donde corresponde.
También nos permite buscar en caso de que tengamos muchos campos que nos impida encontrar un registro fácilmente.

