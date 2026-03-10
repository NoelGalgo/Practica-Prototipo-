# Patrón Prototype en C#

## Alumno
Serma Segura Noel ALberto

## Número de Control
22210354
## Materia
Patrones de Diseño

---

# Descripción

Este repositorio contiene una implementación del **patrón Prototype ** aplicado a un sistema de gestión de exámenes para el Tecnológico.  

El objetivo es permitir la creación de múltiples exámenes de diversas materias mediante la **clonación de prototipos pre-elaborados**, evitando crear cada objeto desde cero.

---

# Contenido del repositorio

- Identificación y explicación  
- Diagrama UML  
- Código ejecutable (8 materias)  
- Conclusión  

---

# Identificación y explicación

## 1. El concepto de clonación

El **patrón Prototype** es un patrón de tipo **creacional**.  
Su funcionalidad principal consiste en crear nuevos objetos **copiando (clonando) instancias existentes**, en lugar de generarlas desde cero.

Esto permite reutilizar configuraciones ya definidas y ahorrar recursos cuando los objetos tienen una estructura compleja.

---

## 2. Atributos protegidos y herencia

Para este ejercicio se utilizan atributos con modificador **protected**, como el nombre de la materia y la clave.

Esto permite que:

- Las **subclases puedan heredar estos atributos**
- Los datos **no sean accesibles directamente desde fuera de la clase**

De esta manera se mantiene **encapsulamiento** y reutilización mediante **herencia**.

---

## 3. Método Clone (Shallow Copy)

El método más importante en este patrón es **Clone()**.

Este método utiliza **MemberwiseClone()**, el cual crea una **copia superficial (Shallow Copy)** del objeto.

Ventajas de este enfoque:

- Evita crear objetos complejos desde cero  
- Reduce el consumo de recursos  
- Permite generar múltiples copias rápidamente  

## Conclusion 

Conclusión
El patrón Prototype es útil cuando se necesita crear objetos basados en otros ya existentes, ocultando el proceso de clonación.

En el contexto de un sistema del Tecnológico, este patrón permite que una materia con su nombre y clave definidos pueda duplicarse fácilmente para distintos docentes, grupos o salones, sin modificar el objeto original.

A diferencia del patrón Singleton, que limita la creación a una sola instancia, el Prototype facilita la generación de múltiples copias personalizables.

El uso de MemberwiseClone() permite realizar copias rápidas en memoria, lo que resulta eficiente cuando la configuración inicial del objeto es la misma pero algunos datos específicos cambian.
