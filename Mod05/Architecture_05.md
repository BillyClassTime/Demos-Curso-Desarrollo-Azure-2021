# Lab: Implementación de procesos de cargas de trabajo mediante el uso de imágenes y contenedores

## Escenario de laboratorio

Su organización está buscando una forma de crear automáticamente máquinas virtuales (VM) para ejecutar tareas y finalizarlas de inmediato. Tiene la tarea de evaluar varios servicios en Microsoft Azure y determinar cual de ellos puede ayudarlo a crear automáticamente máquinas virtuales e instalar software personalizado en esas máquinas. Como prueba de concepto, ha decidido intentar crear máquinas virtuales a partir de imágenes predefinidas e imágenes de contenedor para poder comparar las dos soluciones. Para que su prueba de concepto sea simple, creará una aplicación especial de "verificación de IP" escrita en .NET que implementará automáticamente en sus máquinas. Su prueba de concepto evaluará los servicios de Azure Container Instances y Azure Virtual Machines.

## Objetivos

Después de completar esta práctica de laboratorio, podrá:

- Cree una máquina virtual mediante la interfaz de línea de comandos (CLI) de Azure.

- Implemente una imagen de contenedor de Docker en Azure Container Registry.

- Implemente un contenedor desde una imagen de contenedor en Container Registry mediante Container Instances.

## Arquitectura

![](images\Architecture.png)