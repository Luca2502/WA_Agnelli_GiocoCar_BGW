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

namespace WA_Agnelli_GiocoCar_BGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        //variabili global
        BackgroundWorker bgw1, bgw2;
        bool CheckGiri = false;
        int NumGiri, NumGiriTrag, NumGiriTrag1, NumGiriTrag2;
        bool Win = false;
        int Velocità1, Velocità2;
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            pct_giri.Visible = true;

            //faccio assegnari i giri in modo random
            if (CheckGiri == false)
            {
                //numero random per i giri
                Random rnd = new Random();
                //a seconda dei giri che si vogliono,cambiare il secondo numero(n giri+1)
                NumGiri = rnd.Next(1, 6);
                pct_giri.Text = NumGiri.ToString();

                //assegno alle variabili il numero di giri               
                NumGiriTrag = NumGiri;
                NumGiriTrag1 = NumGiri;
                NumGiriTrag2 = NumGiri;
                CheckGiri = true;
            }

            //creo i backgroundworker per le macchine
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork;
            bgw1.ProgressChanged += Bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted; 
            
            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork;
            bgw2.ProgressChanged += Bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            
            bgw1.RunWorkerAsync();
            bgw2.RunWorkerAsync();
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }               
        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //muovo la macchina1 e la macchina2          
            car1.Left = car1.Left + Velocità1;
            car2.Left = car2.Left + Velocità2;

            //ciclo per compiere i giri
            for (int i = 0; i <= NumGiri; i++)
            {
                if (Win == false)
                {
                    //se i giri sono uguali a zero dico chi ha vinto
                    if (NumGiriTrag1 == 0)
                    {
                        Win = true;
                        MessageBox.Show("La Macchina numero: 1 ha vinto la corsa");                        
                    }
                    if (NumGiriTrag2 == 0)
                    {
                        Win = true;
                        MessageBox.Show("La Macchina numero: 2 ha vinto la corsa");                      
                    }

                    //finche le macchine non fanno tutti i giri le faccio andare avanti
                    if (NumGiriTrag != 0)
                    {
                        if (car1.Bounds.IntersectsWith(trag.Bounds))
                        {
                            NumGiriTrag1--;
                            car1.Location = new Point(43,72);
                        }
                        if (car2.Bounds.IntersectsWith(trag.Bounds))
                        {
                            NumGiriTrag2--;
                            car2.Location = new Point(43,279);
                        }
                    }
                }

            }
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            while (Win != true)
            {
                //estraggo le velocità delle 
                Random rnd = new Random();
                Thread.Sleep(100);
                Velocità1 = rnd.Next(1, 11);
                Velocità2 = rnd.Next(1, 11);
                
                bgw.ReportProgress(Velocità1, Velocità2);
            }
        }
    }
}
