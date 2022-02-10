using dio_dotnet_poo_lab_2_master.Classes;
using System.Collections.Generic;

namespace DIO.Series
{
    namespace dio_dotnet_poo_lab_2_master.Classes
    {
        public class FilmeRepositorio
        {

            private List<Filme> listaFilme = new List<Filme>();
            public void Atualiza(int id, Filme objeto)
            {
                listaFilme[id] = objeto;
            }

            public void Exclui(int id)
            {
                listaFilme[id].Excluir();
            }

            public void Insere(Filme objeto)
            {
                listaFilme.Add(objeto);
            }

            public List<Filme> Lista()
            {
                return listaFilme;
            }

            public int ProximoId()
            {
                return listaFilme.Count;
            }

            public Filme RetornaPorId(int id)
            {
                return listaFilme[id];
            }
        }
    }
}