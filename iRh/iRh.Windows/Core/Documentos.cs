using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Documentos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Documentos> ObterDocumentos()
        {
            var listaDeDocumentos = new List<Documentos>();

            listaDeDocumentos.Add(new Documentos { Id = 1, Descricao = "Carteira de Identidade" });
            listaDeDocumentos.Add(new Documentos { Id = 2, Descricao = "Carteira Nacional de Habilitação" });
            listaDeDocumentos.Add(new Documentos { Id = 3, Descricao = "Carteira de Trabalho e Previdência Social" });
            listaDeDocumentos.Add(new Documentos { Id = 4, Descricao = "Título de Eleitor" });
            listaDeDocumentos.Add(new Documentos { Id = 5, Descricao = "Documento Militar" });
            listaDeDocumentos.Add(new Documentos { Id = 6, Descricao = "Carteira de Identidade Estrangeira" });
        
            return listaDeDocumentos;
        }
    }
}
