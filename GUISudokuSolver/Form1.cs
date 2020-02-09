using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISudokuSolver
{
    public partial class Form1 : Form
    {
        public static int[,] grid = new int[9, 9];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            int[,] grid = new int[9, 9];
            grid[0, 0] = Convert.ToInt32(textBox1.Text);
            grid[0, 1] = Convert.ToInt32(textBox2.Text);
            grid[0, 2] = Convert.ToInt32(textBox3.Text);
            grid[0, 3] = Convert.ToInt32(textBox9.Text);
            grid[0, 4] = Convert.ToInt32(textBox8.Text);
            grid[0, 5] = Convert.ToInt32(textBox7.Text);
            grid[0, 6] = Convert.ToInt32(textBox6.Text);
            grid[0, 7] = Convert.ToInt32(textBox5.Text);
            grid[0, 8] = Convert.ToInt32(textBox4.Text);
            grid[1, 0] = Convert.ToInt32(textBox18.Text);
            grid[1, 1] = Convert.ToInt32(textBox16.Text);
            grid[1, 2] = Convert.ToInt32(textBox17.Text);
            grid[1, 3] = Convert.ToInt32(textBox10.Text);
            grid[1, 4] = Convert.ToInt32(textBox11.Text);
            grid[1, 5] = Convert.ToInt32(textBox12.Text);
            grid[1, 6] = Convert.ToInt32(textBox13.Text);
            grid[1, 7] = Convert.ToInt32(textBox14.Text);
            grid[1, 8] = Convert.ToInt32(textBox15.Text);
            grid[2, 0] = Convert.ToInt32(textBox27.Text);
            grid[2, 1] = Convert.ToInt32(textBox25.Text);
            grid[2, 2] = Convert.ToInt32(textBox26.Text);
            grid[2, 3] = Convert.ToInt32(textBox19.Text);
            grid[2, 4] = Convert.ToInt32(textBox20.Text);
            grid[2, 5] = Convert.ToInt32(textBox21.Text);
            grid[2, 6] = Convert.ToInt32(textBox22.Text);
            grid[2, 7] = Convert.ToInt32(textBox23.Text);
            grid[2, 8] = Convert.ToInt32(textBox24.Text);
            grid[3, 0] = Convert.ToInt32(textBox45.Text);
            grid[3, 1] = Convert.ToInt32(textBox43.Text);
            grid[3, 2] = Convert.ToInt32(textBox44.Text);
            grid[3, 3] = Convert.ToInt32(textBox37.Text);
            grid[3, 4] = Convert.ToInt32(textBox38.Text);
            grid[3, 5] = Convert.ToInt32(textBox39.Text);
            grid[3, 6] = Convert.ToInt32(textBox40.Text);
            grid[3, 7] = Convert.ToInt32(textBox41.Text);
            grid[3, 8] = Convert.ToInt32(textBox42.Text);
            grid[4, 0] = Convert.ToInt32(textBox36.Text);
            grid[4, 1] = Convert.ToInt32(textBox34.Text);
            grid[4, 2] = Convert.ToInt32(textBox35.Text);
            grid[4, 3] = Convert.ToInt32(textBox28.Text);
            grid[4, 4] = Convert.ToInt32(textBox29.Text);
            grid[4, 5] = Convert.ToInt32(textBox30.Text);
            grid[4, 6] = Convert.ToInt32(textBox31.Text);
            grid[4, 7] = Convert.ToInt32(textBox32.Text);
            grid[4, 8] = Convert.ToInt32(textBox33.Text);
            grid[5, 0] = Convert.ToInt32(textBox54.Text);
            grid[5, 1] = Convert.ToInt32(textBox52.Text);
            grid[5, 2] = Convert.ToInt32(textBox53.Text);
            grid[5, 3] = Convert.ToInt32(textBox46.Text);
            grid[5, 4] = Convert.ToInt32(textBox47.Text);
            grid[5, 5] = Convert.ToInt32(textBox48.Text);
            grid[5, 6] = Convert.ToInt32(textBox49.Text);
            grid[5, 7] = Convert.ToInt32(textBox50.Text);
            grid[5, 8] = Convert.ToInt32(textBox51.Text);
            grid[6, 0] = Convert.ToInt32(textBox63.Text);
            grid[6, 1] = Convert.ToInt32(textBox61.Text);
            grid[6, 2] = Convert.ToInt32(textBox62.Text);
            grid[6, 3] = Convert.ToInt32(textBox55.Text);
            grid[6, 4] = Convert.ToInt32(textBox56.Text);
            grid[6, 5] = Convert.ToInt32(textBox57.Text);
            grid[6, 6] = Convert.ToInt32(textBox58.Text);
            grid[6, 7] = Convert.ToInt32(textBox59.Text);
            grid[6, 8] = Convert.ToInt32(textBox60.Text);
            grid[7, 0] = Convert.ToInt32(textBox72.Text);
            grid[7, 1] = Convert.ToInt32(textBox70.Text);
            grid[7, 2] = Convert.ToInt32(textBox71.Text);
            grid[7, 3] = Convert.ToInt32(textBox64.Text);
            grid[7, 4] = Convert.ToInt32(textBox65.Text);
            grid[7, 5] = Convert.ToInt32(textBox60.Text);
            grid[7, 6] = Convert.ToInt32(textBox67.Text);
            grid[7, 7] = Convert.ToInt32(textBox68.Text);
            grid[7, 8] = Convert.ToInt32(textBox69.Text);
            grid[8, 0] = Convert.ToInt32(textBox81.Text);
            grid[8, 1] = Convert.ToInt32(textBox79.Text);
            grid[8, 2] = Convert.ToInt32(textBox80.Text);
            grid[8, 3] = Convert.ToInt32(textBox73.Text);
            grid[8, 4] = Convert.ToInt32(textBox74.Text);
            grid[8, 5] = Convert.ToInt32(textBox75.Text);
            grid[8, 6] = Convert.ToInt32(textBox76.Text);
            grid[8, 7] = Convert.ToInt32(textBox77.Text);
            grid[8, 8] = Convert.ToInt32(textBox78.Text);
            if (gridSolution(grid) == false)
            {
                label1.Text = "doesnt have a solution";
            }
            else
            {
                textBox1.Text = Convert.ToString(grid[0, 0]);
                textBox2.Text = Convert.ToString(grid[0, 1]);
                textBox3.Text = Convert.ToString(grid[0, 2]);
                textBox9.Text = Convert.ToString(grid[0, 3]);
                textBox8.Text = Convert.ToString(grid[0, 4]);
                textBox7.Text = Convert.ToString(grid[0, 5]);
                textBox6.Text = Convert.ToString(grid[0, 6]);
                textBox5.Text = Convert.ToString(grid[0, 7]);
                textBox4.Text = Convert.ToString(grid[0, 8]);
                textBox18.Text = Convert.ToString(grid[1, 0]);
                textBox16.Text = Convert.ToString(grid[1, 1]);
                textBox17.Text = Convert.ToString(grid[1, 2]);
                textBox10.Text = Convert.ToString(grid[1, 3]);
                textBox11.Text = Convert.ToString(grid[1, 4]);
                textBox12.Text = Convert.ToString(grid[1, 5]);
                textBox13.Text = Convert.ToString(grid[1, 6]);
                textBox14.Text = Convert.ToString(grid[1, 7]);
                textBox15.Text = Convert.ToString(grid[1, 8]);
                textBox27.Text = Convert.ToString(grid[2, 0]);
                textBox25.Text = Convert.ToString(grid[2, 1]);
                textBox26.Text = Convert.ToString(grid[2, 2]);
                textBox19.Text = Convert.ToString(grid[2, 3]);
                textBox20.Text = Convert.ToString(grid[2, 4]);
                textBox21.Text = Convert.ToString(grid[2, 5]);
                textBox22.Text = Convert.ToString(grid[2, 6]);
                textBox23.Text = Convert.ToString(grid[2, 7]);
                textBox24.Text = Convert.ToString(grid[2, 8]);
                textBox45.Text = Convert.ToString(grid[3, 0]);
                textBox43.Text = Convert.ToString(grid[3, 1]);
                textBox44.Text = Convert.ToString(grid[3, 2]);
                textBox37.Text = Convert.ToString(grid[3, 3]);
                textBox38.Text = Convert.ToString(grid[3, 4]);
                textBox39.Text = Convert.ToString(grid[3, 5]);
                textBox40.Text = Convert.ToString(grid[3, 6]);
                textBox41.Text = Convert.ToString(grid[3, 7]);
                textBox42.Text = Convert.ToString(grid[3, 8]);
                textBox36.Text = Convert.ToString(grid[4, 0]);
                textBox34.Text = Convert.ToString(grid[4, 1]);
                textBox35.Text = Convert.ToString(grid[4, 2]);
                textBox28.Text = Convert.ToString(grid[4, 3]);
                textBox29.Text = Convert.ToString(grid[4, 4]);
                textBox30.Text = Convert.ToString(grid[4, 5]);
                textBox31.Text = Convert.ToString(grid[4, 6]);
                textBox32.Text = Convert.ToString(grid[4, 7]);
                textBox33.Text = Convert.ToString(grid[4, 8]);
                textBox54.Text = Convert.ToString(grid[5, 0]);
                textBox52.Text = Convert.ToString(grid[5, 1]);
                textBox53.Text = Convert.ToString(grid[5, 2]);
                textBox46.Text = Convert.ToString(grid[5, 3]);
                textBox47.Text = Convert.ToString(grid[5, 4]);
                textBox48.Text = Convert.ToString(grid[5, 5]);
                textBox49.Text = Convert.ToString(grid[5, 6]);
                textBox50.Text = Convert.ToString(grid[5, 7]);
                textBox51.Text = Convert.ToString(grid[5, 8]);
                textBox63.Text = Convert.ToString(grid[6, 0]);
                textBox61.Text = Convert.ToString(grid[6, 1]);
                textBox62.Text = Convert.ToString(grid[6, 2]);
                textBox55.Text = Convert.ToString(grid[6, 3]);
                textBox56.Text = Convert.ToString(grid[6, 4]);
                textBox57.Text = Convert.ToString(grid[6, 5]);
                textBox58.Text = Convert.ToString(grid[6, 6]);
                textBox59.Text = Convert.ToString(grid[6, 7]);
                textBox60.Text = Convert.ToString(grid[6, 8]);
                textBox72.Text = Convert.ToString(grid[7, 0]);
                textBox70.Text = Convert.ToString(grid[7, 1]);
                textBox71.Text = Convert.ToString(grid[7, 2]);
                textBox64.Text = Convert.ToString(grid[7, 3]);
                textBox65.Text = Convert.ToString(grid[7, 4]);
                textBox60.Text = Convert.ToString(grid[7, 5]);
                textBox67.Text = Convert.ToString(grid[7, 6]);
                textBox68.Text = Convert.ToString(grid[7, 7]);
                textBox69.Text = Convert.ToString(grid[7, 8]);
                textBox81.Text = Convert.ToString(grid[8, 0]);
                textBox79.Text = Convert.ToString(grid[8, 1]);
                textBox80.Text = Convert.ToString(grid[8, 2]);
                textBox73.Text = Convert.ToString(grid[8, 3]);
                textBox74.Text = Convert.ToString(grid[8, 4]);
                textBox75.Text = Convert.ToString(grid[8, 5]);
                textBox76.Text = Convert.ToString(grid[8, 6]);
                textBox77.Text = Convert.ToString(grid[8, 7]);
                textBox78.Text = Convert.ToString(grid[8, 8]);
            }
        }

        static bool gridSolution(int[,] grid)
        {
            int[] empty = gridEmpty(grid);
            if (empty[2] == 1)
            {
                return true;
            }
            for (int i = 1; i < 10; i++)
            {
                if (gridValid(grid, i, empty) == true)
                {
                    grid[empty[0], empty[1]] = i;
                    if (gridSolution(grid) == true)
                    {
                        return true;
                    }
                    grid[empty[0], empty[1]] = 0;
                }
            }
            return false;
        }

        static bool gridValid(int[,] grid, int generatedNumber, int[] pos)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[pos[0], i] == generatedNumber && pos[1] != i)
                {
                    return false;
                }
                if (grid[i, pos[1]] == generatedNumber && pos[0] != i)
                {
                    return false;
                }
            }
            int grid_x = pos[0] / 3;
            int grid_y = pos[1] / 3;
            for (int i = grid_y * 3; i < grid_y * 3 + 3; i++)
            {
                for (int j = grid_x * 3; j < grid_x * 3 + 3; j++)
                {
                    if (grid[j, i] == generatedNumber && (pos[0] != j && pos[1] != i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static int[] gridEmpty(int[,] grid)
        {
            int[] empty = new int[3];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        empty[0] = i;
                        empty[1] = j;
                        empty[2] = 0;
                        return empty;
                    }
                }
            }
            empty[2] = 1;
            return empty;
        }
    }
}
