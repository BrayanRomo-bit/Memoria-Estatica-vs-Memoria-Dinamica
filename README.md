# Memoria Estática vs. Memoria Dinámica

Aplicación de escritorio en **C# (.NET 10 / Windows Forms)** diseñada para demostrar de forma visual e interactiva cómo funciona la asignación de memoria en dos escenarios distintos:

- **Memoria Estática (bloques contiguos):** uso de arreglos de tamaño fijo (`int[]`) y el costo de redimensionarlos mediante reasignación (`Array.Resize`).
- **Memoria Dinámica (Heap):** creación de instancias enlazadas (`HeapObject`), referencias compartidas y liberación mediante el *Garbage Collector* (`GC.Collect`).

---

## Requisitos

- **Sistema operativo:** Windows
- **SDK:** [.NET 10 SDK](https://dotnet.microsoft.com/download) (con soporte para Windows Forms)

---

## Cómo ejecutar el proyecto

1. Clona o abre el repositorio en tu equipo.
2. Ejecuta la aplicación desde la terminal en la raíz del repositorio:

```powershell
dotnet run --project "src\MemoryComparison.csproj"
```

También puedes abrir la solución `Memoria Estatica.slnx` en **Visual Studio** y presionar `F5`.

---

## Guía rápida de la interfaz

### 1. Panel izquierdo: Memoria Estática (Arreglos contiguos)
- **Initial size + Generate Vector:** reserva un bloque contiguo de memoria para la cantidad indicada de enteros (`4 bytes` por elemento) y muestra su código de referencia en memoria.
- **New size + Resize:** cambia el tamaño del arreglo en tiempo de ejecución. Si el tamaño cambia, .NET asigna un **nuevo bloque contiguo**, copia los elementos existentes y actualiza la referencia.

### 2. Panel derecho: Memoria Dinámica (Instancias en el Heap)
- **Count + Create Instances:** crea objetos independientes (`HeapNode`) en el *Heap* (cada uno con un arreglo interno de `256 bytes`) y los enlaza entre sí como una lista ligada (`Next`).
- **Add +1:** agrega una nueva instancia al final sin reasignar ni mover los objetos ya existentes.
- **Test Heap Reference:** demuestra que dos variables (`refA` y `refB`) apuntan al **mismo objeto** en el *Heap* (modificar una altera la otra).
- **Release and Run GC:** elimina las referencias y ejecuta el *Garbage Collector* para recuperar la memoria del *Heap*.

### 3. Panel inferior: Benchmark comparativo (100,000 elementos)
- **Run 100,000-Element Comparison:** limpia ambos paneles y compara el tiempo de ejecución entre:
  1. Generar `50,000` enteros y redimensionar a `100,000` en memoria estática.
  2. Crear `100,000` instancias dinámicas en el *Heap*.

---

## Estructura del proyecto

| Archivo | Descripción |
| :--- | :--- |
| `src/Models/HeapNode.cs` | Modelo de nodo dinámico alojado en el *Heap* con payload y referencia al siguiente nodo. |
| `src/Models/StaticMemoryOperationResult.cs` | Resultado de las operaciones ejecutadas sobre memoria estática. |
| `src/Models/DynamicMemoryOperationResult.cs` | Resultado de las operaciones ejecutadas sobre memoria dinámica en el *Heap*. |
| `src/Services/StaticMemoryService.cs` | Lógica de asignación, redimensionamiento y benchmark de arreglos contiguos. |
| `src/Services/DynamicMemoryService.cs` | Gestión de instancias enlazadas en el *Heap*, prueba de referencias y recolección de basura. |
| `src/UI/MainForm.cs` | Controlador de eventos de la interfaz gráfica y actualización de resultados. |
| `src/UI/MainForm.Designer.cs` | Diseño de controles y disposición de paneles de la ventana principal. |
| `src/Program.cs` | Punto de entrada de la aplicación (con modo oscuro nativo de Windows). |
| `REPORTE_EJECUCION.md` | Reporte detallado de pruebas realizadas con capturas de pantalla. |

---

## Reporte de pruebas

Puedes consultar los resultados de ejecución y las capturas de pantalla de cada caso de prueba en [REPORTE_EJECUCION.md](REPORTE_EJECUCION.md).
