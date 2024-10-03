using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeteria_ReNy
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cafeteria());
        }
        public partial class TelaCarrinho : Form
        {
            public void AdicionarItem(string item)
            {


                listBoxCarrinho.Items.Add(item);
            }
        }
    }
}
