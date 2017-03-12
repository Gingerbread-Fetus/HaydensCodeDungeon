using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class Form1 : Form
    {
        private Graphics g1;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(500, 500);
            g1 = Graphics.FromImage(this.pictureBox1.Image);
        }

        /// <summary>
        /// The method fro drawing 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = 200;
            int cellSize = 5;
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
        }

        /// <summary>
        /// When this button is clicked a few things need to happen.
        /// 
        /// 1. Attempt to load the txt. file selected that contains the beatmap
        /// 
        /// 2. Draw out the appropriate length grid in the picture box.
        /// 
        /// 3. Make sure that if a current unsaved beatmap is open that they're asked to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Make sure the beatmap is saved before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This method will save the beatmap as it is currently drawn to an xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the 'Load Existing' menu option. It will load an existing xml file
        /// and draw it to the grid.
        /// 
        /// Note that there are a few things that need to be done when the xml is loaded
        /// 
        /// 1. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the load new option. What this does is it loads a new grid from
        /// an existing beatmap.txt file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the button that will export the currently existing beatmap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
