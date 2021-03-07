# Lab: Creación de una solución multi-nivel mediante el uso de servicios en Azure

# Escenario de laboratorio

Los desarrolladores de su empresa han adoptado y utilizado con éxito el sitio web https://httpbin.org/ para probar varios clientes que emiten solicitudes HTTP. Su empresa desea utilizar uno de los contenedores disponibles públicamente en Docker Hub para alojar la aplicación web httpbin en un entorno administrado por la empresa con algunas advertencias. En primer lugar, los desarrolladores que emiten consultas de Transferencia de estado representacional (REST) deben recibir encabezados estándar que se utilizan en todas las aplicaciones de la empresa. En segundo lugar, los desarrolladores deberían poder obtener respuestas mediante el uso de la notación de objetos de JavaScript (JSON), incluso si la API que se usa entre bastidores no es compatible con el formato de datos. Tiene la tarea de utilizar Microsoft Azure API Management para crear un nivel de proxy frente a la aplicación web httpbin para implementar las políticas de su empresa.

## Objetivos
Después de completar esta práctica de laboratorio, podrá:

- Crear una aplicación web a partir de una imagen de contenedor de Docker Hub.

- Crear una cuenta de API Management.

- Configurar una API como proxy para otro servicio de Azure con manipulación de encabezado y carga útil.

## Arquitectura

![](images\Architecture.png)