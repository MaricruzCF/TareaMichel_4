namespace TareaMichel_4
{
    class Catalogo
    {
        private Productos[] _catalogo;
        private int _contador = 0;

        public Catalogo()
        {
            _catalogo = new Productos[15];
        }

        public void Agregar(Productos producto)
        {
 
            if (_contador < _catalogo.Length)
            {

                int limite = _contador;

                int indice = limite;

                for (int i = 0; i < limite; i++)
                {
                    if (producto.Codigo < _catalogo[i].Codigo)
                    {
                        indice = i;
                        break;
                    }
                }

                for (int i = limite; i > indice; i--)
                {
          
                    _catalogo[i] = _catalogo[i - 1];
                }
  
                _catalogo[indice] = producto;

                _contador++;
            }
        }

        public Productos Buscar(int codigo)
        {

            for (int i = 0; i < _contador; i++)
            {
 
                if (codigo == _catalogo[i].Codigo)
                    return _catalogo[i];
            }

            return null;
        }

        public void Eliminar(int codigo)
        {

            for (int indice = 0; indice < _contador; indice++)
            {

                if (codigo == _catalogo[indice].Codigo)
                {

                    int ultima = _contador - 1;

                    for (int i = indice; i < ultima; i++)
                        _catalogo[i] = _catalogo[i + 1];

                    _catalogo[ultima] = null;

                    _contador--;
                    break;
                }
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _contador; i++)
                str += _catalogo[i].ToString() + System.Environment.NewLine;
            return str;
        }
    }
}
