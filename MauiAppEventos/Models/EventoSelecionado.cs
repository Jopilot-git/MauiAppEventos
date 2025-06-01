using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{

    // Aqui recebe da MainPage.xaml.cs os dados das ENTRY,  em Eventos.xaml.cs fazer o binding context
    public class EventoSelecionado
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public int participantes { get; set; }
        public double custo { get; set; }
        public DateTime datainicio { get; set; }
        public DateTime datatermino { get; set;}

        public int dias { get => datatermino.Subtract(datainicio).Days; }


        public double ValorTotal
        {
            get
            {
                double total = (participantes * custo)*dias;
                return total;   

            }

        }

        

    }


}
