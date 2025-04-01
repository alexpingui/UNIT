using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNIT_rebuild.Engine;
using UNIT_rebuild.MapObjects;
using UNIT_rebuild.Maps;

namespace UNIT_rebuild
{
    public partial class MainMenu : Form
    {
        UNITER unit;
        Timer timer;
        public MainMenu()
        {
            InitializeComponent();
        

       


         InitializeComponent();

            Transform.GetSizeOfForm(Size.Width, Size.Height);

            Paint += new PaintEventHandler(DrawGame);
            timer = new Timer();
            timer.Interval = 20;


            Level.speedOfMap = 5;

           

            timer.Tick += new EventHandler(Update);




            Init();
        }

        

        public void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Level.DrawMap(g);
            
        }

        public void Update(object sender, EventArgs e)
        {
            Level.MoveMap();

            

            Invalidate();

        }

        private void Init()
        {
            Map map = new MAP_1();
            Level.Start(map, out unit);
            timer.Start();
            Invalidate();
        }

       

        private void MainPlay_MouseClick(object sender, MouseEventArgs e)
        {
            
           
            Form1 fr1 = new Form1();
            timer.Stop();
            fr1.ShowDialog();
            Hide();
            this.Close();

        }

        private void MainPlay_MouseEnter(object sender, EventArgs e)
        {
            MainPlay.Image = Properties.Resources.MainPlayInvert;



        }
    }
}
