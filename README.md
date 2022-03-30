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

Para obtener el string de la conexion debemos hacer lo siguiente:

Crear un documento de texto:

![SC22](https://i.imgur.com/LpQJH70.png)

Cambiarle el nombre y la extension a .udl:

![SC23](https://i.imgur.com/9v2gunx.png)

Luego abrimos el archivo para ver el siguiente programa:

![SC24](https://i.imgur.com/VkiJBLx.png)

En la primera parte debemos poner el nombre de nuestro servidor, para conseguirlo se hace lo siguiente en SQL Server:

![SC25](https://i.imgur.com/onNTWVI.jpg)

![SC26](https://i.imgur.com/ybiKG0R.png)

En la parte de autenticacion debemos elegir la forma que tengamos, luego de haber autenticado nos debe salir la opcion de elegir nuestra base de datos:

![SC27](https://i.imgur.com/lL3AG9c.jpg)

Luego de haber hecho todo esto y haberle dado a OK, abrimos el archivo .udl como texto en el notepad o cualquier editor de texto:

![SC28](https://i.imgur.com/2YCtKiv.png)

Solo se debe copiar la parte desde donde dice integrated en adelante.

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

![TD1](https://i.imgur.com/j0LggmT.jpg)

Cuando seleccionamos una fila de la tabla, los textboxs se llenan con sus respectiva información seleccionada, cada campo donde corresponde.
También nos permite buscar en caso de que tengamos muchos campos que nos impida encontrar un registro fácilmente.

Debemos destacar que cuando queramos agregar un registro tenemos que darle a nuevo y todos los textboxs se limpiarán (ya que contendrán la información de la fila seleccionada) para que podamos escribir y una vez tengamos todos los textboxs llenos le damos a guardar e inmediatamente se guardará nuestro registro y podemos hacer uso de la información almacenada de acuerdo a como consideremos (los administradores).

<hr>

## Transacciones 💵
En la parte de transacciones tenemos lo que es el mantenimiento principal donde se muestra la tabla con las diversas informaciones. El apartado de buscador donde podremos filtrar desde un número a letras o palabras y al presionar el botón buscar este realizará la búsqueda y lo mostrará en la tabla, al ser este botón presionado de nuevo con el área de buscador ahora vacío, se mostrarán nuevamente todos los datos. Al presionar eliminar se eliminará la fila a la cual pertenece la selección. A continuación se muestra el interfaz de transacciones:

![T](https://i.imgur.com/5LbnMvM.png)

Al presionar añadir se abrirá la interfaz de añadir los datos o detalles para una transacción. En el mismo tenor, editar abrirá la interfaz mencionada anteriormente pero ahora mostrando los datos de la fila donde lo selecciono lleno para estos ser editados. A continuación se muestra el interfaz de añadir o editar transacciones:

![DT](https://i.imgur.com/B1oDfzZ.png)

<hr>

## Balances 📊
Al igual que la parte de transacciones, en la parte de balances tenemos lo que es el mantenimiento principal donde se muestra la tabla con las diversas informaciones. Tomando en cuenta que posee las mismas características de lo que es el buscador, como la parte de eliminar. A continuación se muestra el interfaz de balances:

![B](https://i.imgur.com/yFan1S4.png)

Al presionar añadir se abrirá la interfaz de añadir los datos o detalles para un balance. Editar abrirá la interfaz anterior pero mostrando los datos de la fila donde lo selecciono pero en este caso lleno para estos ser editados. A continuación se muestra el interfaz de añadir o editar balances:

![DB](https://i.imgur.com/fmJywNd.png)

<hr>
