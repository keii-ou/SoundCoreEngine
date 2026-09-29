SoundCore Engine v2.0
Gestor de cola de reproducción para DJ desarrollado en C# / WinForms (.NET 10), creado como proyecto integral de la Unidad 2 de Estructura de Datos — TecNM Campus Monclova.
Compara en vivo el comportamiento de tres estructuras de datos ante las mismas operaciones:
Una lista simplemente enlazada propia, implementada desde cero con nodos y punteros.
`LinkedList<T>` de .NET.
`List<T>` (arreglo dinámico) de .NET.
---
Estructura de la solución
```
SoundCoreEngine.sln
├── SoundCore.Modelos/               → record Pista (Id, Título, Artista, BPM, Duración)
├── SoundCore.EstructurasPropias/    → Nodo<T> y ListaSimpleEnlazada<T> (implementación manual)
└── SoundCore.UI/                    → Aplicación WinForms (Program.cs, MainForm.cs)
```
 Cómo ejecutarlo
Abre `SoundCoreEngine.sln` en Visual Studio 2022 (17.12+) o superior.
Verifica que tengas instalado el workload "Desarrollo de escritorio de .NET" y el SDK de .NET 10.
Establece `SoundCore.UI` como proyecto de inicio (aparece en negritas en el Explorador de Soluciones).
Presiona `F5` (con depurador) o `Ctrl+F5` (sin depurador).
 
Funcionalidades
Botón	Acción	Complejidad
Listar al Final	Encola una pista nueva al final de la cola	O(n) propia / O(1) LinkedList
Reproducir Next	Inserta una pista nueva justo después de la actual ("Up Next")	O(1)
Avanzar Track	Saca la pista en reproducción (cabeza de la cola)	O(1)
Invertir Lista	Invierte el orden de la cola in-place, sin listas auxiliares	O(n) tiempo, O(1) memoria
Ordenar por BPM	Reordena la cola por tempo (BPM) ascendente	O(n²) — inserción ordenada
Eliminar Duplicados	Elimina pistas repetidas por título	O(n²)
El panel inferior ejecuta un benchmark de estrés configurable (mínimo recomendado: 20,000 inserciones) que cronometra las tres estructuras con `Stopwatch` y muestra cuál conviene según el tipo de operación.

Tecnologías
C# 14 / .NET 10
Windows Forms
`Nullable` habilitado, sin dependencias externas

Integrantes
`<Lia Kei Uchino Bonney>` 
