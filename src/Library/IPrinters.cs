using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe) {}
    }
}

//
// Se hace uso del patrón de Polimorfismo.
// En vez de crear una clase donde se escriba codigo para los diferentes tipos de impresión,
// se crea una interfaz de impresión, donde se definen su operación, y el código de la  
// operación será definido en cada clase que implemente esta interfaz.
// 
