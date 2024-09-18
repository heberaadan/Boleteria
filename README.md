# Boletería

Boletería es una aplicación desarrollada con un formulario en C# que permite gestionar la compra de boletos para conciertos, así como la creación y edición de usuarios.

## Funcionalidad del Programa

### 1. Inicio de Sesión (`TickBox`)
El formulario de inicio de sesión **TickBox** permite a los usuarios acceder a la aplicación. Los usuarios deben ingresar sus credenciales previamente creadas. Si no tienen cuenta, pueden crear una nueva seleccionando el botón **Crear nueva cuenta**, lo que los redirigirá a otro formulario.

### 2. Crear Usuario (`Crear_Usuario`)
Este formulario permite registrar una nueva cuenta de usuario. Se solicita la siguiente información:
- **Correo electrónico**: Verificado para asegurar que cumple con el formato estándar de un email.
- **Nombre**: Nombre del usuario.
- **Usuario**: El identificador del cliente, que solo debe contener letras.
- **Contraseña**: Se debe ingresar y verificar volviendo a escribirla en un segundo campo.
- **Teléfono**: Acepta solo números con una longitud de 10 caracteres.

Los datos ingresados se almacenan en un archivo llamado `usuarios.txt`.

### 3. Menú Principal (`Menu`)
Una vez que el usuario inicia sesión, es redirigido al formulario de **Menú**, donde se muestran las imágenes de los conciertos disponibles. Las imágenes cambian automáticamente después de cierto tiempo. 

#### Comprar Boletos
Para comprar boletos, el usuario debe:
1. Hacer clic en la imagen del concierto deseado.
2. Ingresar la cantidad de boletos que quiere comprar.

Además, el usuario puede esperar a que aparezca el concierto deseado o navegar manualmente entre las imágenes usando los botones de la parte inferior.

#### Consultar Compras
Desde el menú, el usuario puede consultar sus compras. Esto abre un formulario que muestra la información del evento, incluyendo la fecha y la hora en que se realizó la compra.

#### Editar Perfil (`EditarPerfil`)
En el menú, el usuario puede seleccionar el botón **Editar Perfil**, que lo redirige a un formulario donde puede cambiar sus datos personales. Para realizar modificaciones:
1. Presionar el botón **Cambiar** para habilitar el formulario.
2. Ingresar los cambios deseados en los campos correspondientes.
3. Confirmar los cambios.

### 4. Editar Compras (`EditarCompra`)
Desde el menú principal, el usuario también puede seleccionar el botón **Editar Compras**, que abre el formulario de **EditarCompra**. Aquí, el usuario puede seleccionar el evento que desea modificar. Sin embargo, solo se permite editar una compra dentro de los primeros **2 minutos** (representando un plazo de **48 horas** para cambios en la realidad). Si el tiempo ha pasado, el campo de texto para modificar la compra se deshabilitará.

---

### Almacenamiento de Datos
Toda la información de los usuarios se guarda en un archivo de texto llamado `usuarios.txt`.

### Requisitos:
- Se debe validar el formato de los correos electrónicos.
- El nombre de usuario solo puede contener letras.
- El teléfono debe ser de 10 caracteres numéricos.
- La contraseña debe ser ingresada dos veces para verificarla.

### Flujo de la Aplicación:
1. **Inicio de Sesión** o **Registro de Usuario**.
2. Acceso al **Menú Principal**.
3. Comprar boletos, consultar compras o editar perfil y compras.
4. Almacenar la información de usuarios y compras en archivos de texto.

---

Este proyecto fue desarrollado con formularios de Windows Forms en C#, utilizando un enfoque sencillo para gestionar la compra y edición de boletos de conciertos.
