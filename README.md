# Práctica principios S.O.L.I.D.

Indique qué principio/s SOLID y/o buenas prácticas del desarrollo de software no se cumplen y modifique el programa para que sí los cumpla.

 - La interfaz ITransporte no cumple con ISP ni SRP porque obliga a implementar métodos no utilizados *volar()* y métodos que no son responsabilidad de esas clases *guardarEnBD*
 - El método *guardarEnBD()* no cumple con DIP porque dentro está acoplando con una implementación concreta del Repositorio, o sea, es el caso donde una clase de alto nivel depende directamente de una clase de bajo nivel y no de su abstracción (interfaz).
 - En el programa principal no se cumple con LSP porque se está consultando por el tipo de las instancias *Avion* y *Tren*. Además esto no cumple con Tell Don't Ask.
 
