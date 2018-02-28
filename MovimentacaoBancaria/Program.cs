using MovimentacaoBancaria.Dominio.Interfaces;
using MovimentacaoBancaria.Dominio.Models;
using MovimentacaoBancaria.Infra.Repositorios;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace MovimentacaoBancaria
{
    static class Program
    {
        private static SimpleInjector.Container container;

        /// <summary> 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CriarContainerInjecaoDependencia();
            Application.Run(container.GetInstance<Form1>());
        }

        private static void CriarContainerInjecaoDependencia()
        {
            container = new SimpleInjector.Container();

            container.Register<IClienteRepositorio<Cliente>, ClienteRepositorio>(Lifestyle.Singleton);
            container.Register<IContaCorrenteRepositorio<ContaCorrente>, ContaCorrenteRepositorio>(Lifestyle.Singleton);
            container.Register<IContaEspecialRepositorio<ContaEspecial>, ContaEspecialRepositorio>(Lifestyle.Singleton);
            container.Register<Form1>();
        }
    }
}
