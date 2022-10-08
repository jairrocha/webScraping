using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebScraping.Controller;
using WebScraping.Domain.Interface.Service;

namespace WebScraping.View
{
    public partial class frmForumMsdn : Form
    {
        private readonly ForumController _forumController;

        public frmForumMsdn(IScrapingMsdnService scrapingMsdnService)
        {
            InitializeComponent();
            _forumController = new ForumController(scrapingMsdnService);
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            gv_posts.Rows.Clear();
            var p = new Dictionary<string, string>();
            p.Add("QntdePaginas", txt_pags.Text);
            var posts = await _forumController.BuscarPostsForum(p);

            AtualizarGrid(posts);
        }

        private async void AtualizarGrid(IEnumerable<Domain.Entity.Msdn> posts)
        {

            var taskUi = TaskScheduler.FromCurrentSynchronizationContext();

            var taskAtualizaGrid = (
                Task.Factory.StartNew(() =>
                {
                    foreach (var item in posts)
                    {
                        gv_posts.Rows.Add(
                                item.Titulo,
                                item.Exibicoes,
                                item.Respostas,
                                item.CriadoPor,
                                item.Link
                            );

                                             
                        
                    }


                }, CancellationToken.None, TaskCreationOptions.None, taskUi));


            await taskAtualizaGrid;


        }
    }
}
