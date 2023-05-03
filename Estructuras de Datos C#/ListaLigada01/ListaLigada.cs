using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada01
{
    class ListaLigada
    {
        // Ancla o cabeza de la lista
        private Nodo ancla;

        // Variable de referencia para trabajar con la lista
        private Nodo trabajo;

        // Variable de referencia para apoyo en ciertas operaciones de la lista
        private Nodo trabajo2;

        public ListaLigada()
        {
            // Instanciar ancla
            ancla = new Nodo();

            ancla.Siguiente = null;

        }

        // Recorre toda la lista
        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                // Obtenemos el dato y lo mostramos
                int d = trabajo.Dato;
                Console.Write("{0}, ", d);
            }
            Console.WriteLine();
        }

        // Adicionar un nuevo elemento, este elemento se adiciona SIEMPRE al final
        public void Adicionar(int nuevoDato)
        {
            // trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
                trabajo = trabajo.Siguiente;

            // Creamos el nuevo nodo
            Nodo temp = new Nodo();

            // Insertamos el dato
            temp.Dato = nuevoDato;

            // Finalizamos correctamente
            temp.Siguiente = null;

            // Ligamos el ultimom nodo encontrado con el nuevo recien creado
            trabajo.Siguiente = temp;
        }

        // Vaciar lista
        public void Vaciar()
        {
            ancla.Siguiente = null;                                 
            // Se aprovecha del recolector de basura.
            // En lenguajes no administrados hay que liberar la memoria adecuadamente.
        }

        public bool EsVacia()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }

        public Nodo Buscar(int datoABuscar)
        {
            if (EsVacia())
                return null;

            trabajo2 = ancla;

            while (trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                // al encontrarlo lo regresamos
                if (trabajo2.Dato == datoABuscar)
                    return trabajo2;
            }

            // No se encontro
            return null;
        }

        // Busca el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int datoBusqueda)
        {
            int n = -1;
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Dato == datoBusqueda)
                    return n;
            }

            return -1;
        }

        // Buscar el anterior nodo
        // Si esta en el primer nodo se regresa al ancal
        // si el dato no existe se regresa al ultimo nodo.
        public Nodo BuscarAnterior(int datoBusqueda)
        {
            trabajo2 = ancla;

            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != datoBusqueda)
            {
                trabajo2 = trabajo2.Siguiente;
            }
            
            return trabajo2;
        }

        // Borrar la primer ocurrencia del dato proporcionado
        public void BorrarNodo(int datoBusqueda)
        {
            if (EsVacia())
                return;

            // Buscamos los nodos con los que se trabajará
            Nodo anterior = BuscarAnterior(datoBusqueda);
            Nodo encontrado = Buscar(datoBusqueda);

            // Si no hay nodo a borrar, salimos
            if (encontrado == null)
                return;

            // Brincamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            // Quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        // Insertar nodo despues de la primer ocurrencia del dato dato
        public void InsertarNodo(int posicionInsertar, int datoNuevo)
        {
            // Encontramos la posicion donde se va a insertar
            trabajo = Buscar(posicionInsertar);

            if (trabajo == null)
                return;

            // Creamos nodo temporal a insertar
            Nodo temp = new Nodo();
            temp.Dato = datoNuevo;

            // Conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;

            trabajo.Siguiente = temp;
        }

        // Agrega nodo en la posición después del ancla
        public void InsertarNodoAlInicio(int datoAInsertar)
        {
            Nodo nodoTemporal = new Nodo();
            nodoTemporal.Dato = datoAInsertar;

            nodoTemporal.Siguiente = ancla.Siguiente;
            ancla.Siguiente = nodoTemporal;
        }

        // Obtenemos la referencia al nodo dado el indicie
        public Nodo ObtenerPorIndice(int indiceBuscado)
        {
            Nodo trabajoAux = null;
            int indice = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == indiceBuscado)
                    trabajoAux = trabajo;
            }

            return trabajoAux;
        }
    }
}
