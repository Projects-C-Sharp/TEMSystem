
# Sistema de Gestión de Eventos Temáticos (Full Stack)

## 1. Planteamiento del Problema
En la actualidad, la organización de eventos (musicales, deportivos, culturales o de nicho como el anime) requiere de herramientas que no solo permitan administrar la información técnica, sino que también ofrezcan una experiencia de usuario visualmente atractiva y moderna. 

Muchos sistemas de gestión fallan al utilizar plantillas genéricas que no se adaptan a la identidad del evento. Por ello, se requiere desarrollar una plataforma web que permita a un administrador gestionar el ciclo de vida completo de los eventos (CRUD) y a los usuarios finales visualizar esta cartelera mediante una interfaz basada en materialize css.

## 2. Objetivos de la Actividad

### Objetivo General
Desarrollar una aplicación web utilizando **.NET** para la lógica de servidor y **MySQL** para la persistencia de datos, garantizando una interfaz de usuario moderna y profesional.

### Objetivos Específicos
* **Diseño de Datos:** Implementar un esquema de base de datos en MySQL que soporte la integridad de la información de los eventos.
* **Gestión de Información:** Construir un sistema CRUD (Crear, Leer, Actualizar, Eliminar) funcional y validado.
* **Excelencia en UI/UX:** Aplicar los principios estéticos y funcionales de Google (Material Design), evitando el uso de los estilos por defecto de Bootstrap.
* **Personalización:** Adaptar la plataforma a una temática específica elegida por el desarrollador (Música, Festivales, Anime, etc.).

## 3. Requerimientos Técnicos

### Backend y Base de Datos
* **Framework:** .NET 9 o superior.
* **Motor de BD:** MySQL. solo 1 entidad (events)
* **Arquitectura:** Implementar el patrón MVC.

### Frontend (Interfaz de Usuario)
* **Estilo:** Queda **estrictamente prohibido** utilizar el diseño de Bootstrap que viene por defecto en el proyecto de .NET.
* **Librerías sugeridas:** Materialize CSS, o MDBootstrap (Versión Material).

## 4. Estructura del Sistema

### Vista 1: Panel de Administración (CRUD)
* Formulario para la creación de eventos con campos como: Nombre, Fecha, Descripción, Ubicación y URL de imagen/poster.
* Listado administrativo (Tabla o Lista de Material) con opciones para editar la información o dar de baja un evento.

### Vista 2: Galería de Eventos (Pública)
* Visualización tipo "Grid" o "Masonry" utilizando *Cards*.
* Filtros básicos por categoría o fecha.
* Diseño responsivo para visualización en dispositivos móviles.



## 5. Criterios de Evaluación
1.  **Funcionalidad:** El CRUD debe operar sin errores y persistir los datos correctamente en MySQL.
2.  **Identidad Visual:** Coherencia en el uso de la paleta de colores y componentes.
3.  **Creatividad:** Adaptación original de la temática seleccionada.
4.  **Calidad del Código:** Limpieza en la definición de modelos y controladores.
***
