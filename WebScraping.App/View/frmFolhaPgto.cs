using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmFolhaPgto : Form
    {
        private readonly FolhaPgtoController _forumController;
        public frmFolhaPgto(IScrapingFolhaPgtoService folhaPgtoService)
        {
            _forumController = new FolhaPgtoController(folhaPgtoService);
            InitializeComponent();
            CarregarParametrosDefault();

        }

        private void CarregarParametrosDefault()
        {
            this.cbxAno.Text = DateTime.Now.Year.ToString();
            this.cbxMes.Text = DateTime.Now.AddMonths(-1).Month.ToString("d2");


        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            btn_buscar.Enabled = false;
            gv_folhaPgto.Rows.Clear();

            var parametros = new Dictionary<string, string>();
            parametros.Add("mes", cbxMes.Text);
            parametros.Add("ano", cbxAno.Text);
            parametros.Add("acumulado", "0");


            if (chk_acumulado.Checked)
            {
                parametros["acumulado"] = "1";
            }
            

            var folha = await _forumController.BuscarFolhaPgto(parametros);
            
            AtualizarGrid(folha);

            btn_buscar.Enabled = true;

            sw.Stop();

            MessageBox.Show(sw.ElapsedMilliseconds.ToString());
        }


        private async void AtualizarGrid(IEnumerable<Domain.Entity.FolhaPgtoBarauna> folha)
        {

            var taskUi = TaskScheduler.FromCurrentSynchronizationContext();

            var taskAtualizaGrid = (
                Task.Factory.StartNew(() =>
                {
                    foreach (var item in folha)
                    {
                        gv_folhaPgto.Rows.Add(
                                                item.Competencia,
                                                item.Matricula,
                                                item.Nome,
                                                item.CPF,
                                                item.Cargo,
                                                item.Secretaria,
                                                item.Regime,
                                                item.DtAdmissao,
                                                item.Vantagens,
                                                item.Descontos,
                                                item.Liquido,
                                                item.cpt);
                    }


                }, CancellationToken.None, TaskCreationOptions.None, taskUi));


            await taskAtualizaGrid;


        }

        private void chk_acumulado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_acumulado.Checked)
            {
                cbxAno.Enabled = false;
                cbxMes.Enabled = false;
            }
            else
            {
                cbxMes.Enabled = true;
                cbxAno.Enabled = true;
            }
        }
    }
}
