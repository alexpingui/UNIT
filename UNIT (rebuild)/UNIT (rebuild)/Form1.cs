using System;
using System.Drawing;
using System.Windows.Forms;
using UNIT_rebuild.Engine;
using UNIT_rebuild.MapObjects;
using UNIT_rebuild.Maps;
using System.Drawing.Drawing2D;


namespace UNIT_rebuild
{
    public partial class Form1 : Form
    {
        UNITER unit;
        Timer timer;
       

        public Form1()
        {
            
            InitializeComponent();

            Transform.GetSizeOfForm(Size.Width, Size.Height);

            Paint += new PaintEventHandler(DrawGame);
            timer = new Timer();
            timer.Interval = 20;

            
          

            KeyDown += new KeyEventHandler(Jump);

            timer.Tick += new EventHandler(Update);


            Level.speedOfMap = 15;

            Init();
        }

        private void Jump(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    unit.physics.Jump();                    
                    break;
            }
        }

        public void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Level.DrawMap(g);
            unit.DrawUNIT(g);            
        }

        public void Update(object sender, EventArgs e)
        {
            if (unit.physics.CollideDeath()) 
            {
                
               
                Init();
                
               
            } 
            unit.physics.CalculatePhysics();
            Level.MoveMap();
            
            if (unit.physics.CollideFinish)
            {   
                Finish();
                YouWin.Show();
            }

            Invalidate();

        }

        private void Init()
        {
            Map map = new MAP_1();
            Level.Start(map, out unit);
            timer.Start();
            Invalidate();
        }

        public void Finish()
        {
            unit.physics.transform.position.Y = 512;

            unit.physics.transform.position.X += 4;
            if (unit.physics.transform.position.X > 800 )
            {
                MainMenu fr2 = new MainMenu();
                timer.Stop();
                fr2.ShowDialog();
                Hide();
                this.Close();
            }
           

        }

        private void Pause_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Stop();
            Play.Show();
            MainMenuExit.Show();
        }

       

        private void Play_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Start();
            MainMenuExit.Hide();
            Play.Hide();
        }

       

   

        private void Pause_MouseEnter(object sender, EventArgs e)
        {
            Pause.Image = Properties.Resources.PauseInvert;
        }

        private void Pause_MouseLeave(object sender, EventArgs e)
        {
            Pause.Image = Properties.Resources.Pause;
        }

        private void MainMenuExit_MouseClick(object sender, MouseEventArgs e)
        {
           
            Hide();
            MainMenu fr2 = new MainMenu();
            fr2.ShowDialog();
        }
    }
}
