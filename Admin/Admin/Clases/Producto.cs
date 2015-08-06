using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Producto
    {
        private int _renglon;
        private int _id;
        private int _codigo;
        private string _descripcion;
        private Tipo _tipo;
        private Color _color;
        private Talla _talla;
        private double _precioCosto;
        private double _porcGanancia;
        private double _precioVenta;
        private double _stockInicial;
        private double _stockActual;
        private double _porcDescuento;
        private Compra _compra;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Tipo Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Talla Talla
        {
            get { return _talla; }
            set { _talla = value; }
        }

        public double PrecioCosto
        {
            get { return _precioCosto; }
            set { _precioCosto = value; }
        }

        public double PorcGanancia
        {
            get { return _porcGanancia; }
            set { _porcGanancia = value; }
        }

        public double PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public double StockInicial
        {
            get { return _stockInicial; }
            set { _stockInicial = value; }
        }

        public double StockActual
        {
            get { return _stockActual; }
            set { _stockActual = value; }
        }

        public double PorcDescuento
        {
            get { return _porcDescuento; }
            set { _porcDescuento = value; }
        }

        public Compra Compra
        {
            get { return _compra; }
            set { _compra = value; }
        }

        public int Renglon
        {
            get { return _renglon; }
            set { _renglon = value; }
        }


        public Producto()
        {
            _compra = new Compra();
            _talla = new Talla();
            _color = new Color();
            _tipo = new Tipo();
        }
    }
}