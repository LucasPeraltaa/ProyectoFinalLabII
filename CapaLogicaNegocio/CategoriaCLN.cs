using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class CategoriaCLN //CONTROLAR CRUD AL FINAL
    {
        private DataTable miTabla;
        private CategoriaCAD objCategoriaCAD;
        private object ID_CATEGORIA;

        public CategoriaCLN()
        {
            miTabla = new DataTable();
            objCategoriaCAD = new CategoriaCAD();
            ID_CATEGORIA = new object();
        }

        public void agregarCategoria(object ID_categoria, string categoria)
        {
            objCategoriaCAD.agregarCategoria(Convert.ToInt32(ID_categoria) + 1, categoria);
        }

        public void eliminarCategoria(object ID_categoria)
        {
            objCategoriaCAD.eliminarCategoria(Convert.ToInt32(ID_categoria));
        }

        public void actualizarCategoria(object ID_categoria, string categoria)
        {
            objCategoriaCAD.actualizarCategoria(Convert.ToInt32(ID_categoria), categoria);
        }

        public DataTable consultarCategoria()
        {
            miTabla = objCategoriaCAD.consultarCategoria();
            return miTabla;
        }

        public int getPosicionUltFila(int cantFilas)
        {
            int posicionUltFila = cantFilas - 1;
            return posicionUltFila;
        }
    }
}
