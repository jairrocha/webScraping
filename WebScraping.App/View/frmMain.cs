using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraping.Business.Service;
using WebScraping.Controller;
using WebScraping.Domain.Interface.Service;


namespace WebScraping.View
{
    public partial class frmMain : Form
    {

        private readonly ServiceProvider _serviceProvider;

        public frmMain(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            InitializeComponent();
            this.cbx_opcao.Text = "Folha de pgto";

        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {

            Form formB = null;

            if (cbx_opcao.Text == "Folha de pgto")
            {
                formB = new frmFolhaPgto(_serviceProvider.GetRequiredService<IScrapingFolhaPgtoService>());
            }
            else {
                formB = new frmForumMsdn(_serviceProvider.GetRequiredService<IScrapingMsdnService>());
            }

            formB.Show();
            formB.BringToFront();
            
        }




        private void btn_baixar_Click(object sender, EventArgs e)
        {
       

            //var msdn = new MsdnScraping();

            //List<Task> tasks = new List<Task>();
            //List<Msdn> dados = new List<Msdn>();

            //gv_dados.Rows.Clear();

            //var UiTask = TaskScheduler.FromCurrentSynchronizationContext();

            //for (int index = 0; index < 10; index++)
            //{
            //    var task = Task.Factory.StartNew(() =>
            //    {
            //        CapturaPosts(msdn, dados, index);

            //    });

            //    tasks.Add(task);

            //}

            //Task.WhenAll(tasks.ToArray())
            //    .ContinueWith(task =>
            //    {
            //        AtualizaView(dados);
            //    }, UiTask);


        }





        //private static void CapturaPosts(MsdnScraping msdn, List<Msdn> dados, int index)
        //{
        //    //foreach (var post in msdn.Get(index))
        //    //{
        //    //    dados.Add(new Msdn
        //    //    {
        //    //        Titulo = post.Titulo,
        //    //        Respostas = post.Respostas,
        //    //        Exibicoes = post.Exibicoes,
        //    //        CriadoPor = post.CriadoPor,
        //    //        Link = post.Link
        //    //    });
        //    //}
        //}

        //private void AtualizaView(List<Msdn> dados)
        //{


        //    foreach (var item in dados)
        //    {
        //        gv_dados.Rows.Add(item.Titulo, item.Respostas, item.Exibicoes, item.CriadoPor, item.Link);
        //    }
        //}





    }
}
