using FR_GA.Programm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FR_GA
{
    public partial class frmMain : Form
    {
        Bitmap input_image, output_image, orginal_image = null;
        int generation_count, individual_count;
        public frmMain()
        {
            InitializeComponent();
        }
        private void Control_Enter(object sender, EventArgs e)
        {
            Color clr = Color.YellowGreen;

            if (sender.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)sender;
                txt.BackColor = clr;
            }
            else if (sender.GetType() == typeof(Button))
            {
                Button btn = (Button)sender;
                btn.BackColor = clr;
            }
        }
        private void Control_Leave(object sender, EventArgs e)
        {
            Color clr = Color.White;

            if (sender.GetType() == typeof(TextBox))
            {
                TextBox txt = (TextBox)sender;
                txt.BackColor = clr;
            }
            else if (sender.GetType() == typeof(Button))
            {
                Button btn = (Button)sender;
                btn.BackColor = clr;
            }
        }
        public bool ISRealNumber(TextBox txt)
        {

            Regex rgx = new Regex(@"^[0]+([\.][0-9]*)$");
            if (!rgx.IsMatch(txt.Text) && txt.Text != "")
            {
                MessageBox.Show("Enter Float number between 0 and 1 in the filed: " + txt.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Text = "";
                return false;
            }
            return true;
        }
        public bool ISInteger(TextBox txt)
        {
            if (Regex.IsMatch(txt.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter Integer number in the filed: " + txt.Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Text = "";
                return false;
            }
            return true;
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxInputImage.Image = new Bitmap(dlg.FileName);
                    orginal_image = new Bitmap(dlg.FileName);
                }
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            ////check image
            if (orginal_image == null)
            {
                MessageBox.Show("Select Input Image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ////check the fileds if empty
            foreach (TextBox tb in this.pnl_controls.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    MessageBox.Show("Enter All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ////check the values if acceptable
            if (!ISInteger(Generations))
            {
                return;
            }
            else if (!ISInteger(Individuals))
            {
                return;
            }
            else if (!ISInteger(MutationValue))
            {
                return;
            }
            else if (!ISRealNumber(CrossProbability))
            {
                return;
            }
            else if (!ISRealNumber(MutationProbability))
            {
                return;
            }

            //initialize parameters
            generation_count = Convert.ToInt16(Generations.Text);
            individual_count = Convert.ToInt16(Individuals.Text);
            GA.mutation_value = Convert.ToInt16(MutationValue.Text);
            GA.cross_probability = Convert.ToDecimal(CrossProbability.Text);
            GA.mutation_probability = Convert.ToDecimal(MutationProbability.Text);

            //initialize and resize images
            input_image = new Bitmap(orginal_image);
            ImageProcessing.ResizeBitmap(ref input_image, 512, 512);
            output_image = new Bitmap(input_image);

            //convert to gray and show
            Bitmap gray_image = input_image;
            ImageProcessing.ConvertRGBToGrayPoniter(ref gray_image);
            pictureBoxOutputImage.Image = gray_image;                    

            //convert to 2d array
            int[,] pixels = ImageProcessing.BitmapToArray2D(gray_image);

            List<int> fitness_values = new List<int>();
            List<GA.chromosome> maxPopulation = new List<GA.chromosome>();
            List<GA.chromosome> newPopulation = new List<GA.chromosome>();
            List<GA.chromosome> population = GA.Initialize_population(individual_count);

            for (int g = 0; g < generation_count; g++)
            {
                int chromoCounter = 0;
                foreach (GA.chromosome chromo in population)
                {
                    chromoCounter += 1;
                    fitness_values.Add(GA.Fitness(chromo, pixels));
                    if (chromoCounter == population.Count)
                    {
                        int index_of_max_fitness = fitness_values.IndexOf(fitness_values.Max());
                        maxPopulation.Add(population[index_of_max_fitness]);
                        newPopulation = GA.Cross(population, ref fitness_values);
                        break;
                    }
                }

                population = newPopulation;
                GA.Mutations(ref population);
                chromoCounter = 0;
                fitness_values = new List<int>();
            }

            List<int> max_chromo = new List<int>();
            foreach (GA.chromosome chromo in maxPopulation)
            {
                max_chromo.Add(GA.Fitness(chromo, pixels));
            }

            int index_of_max_chromo = max_chromo.IndexOf(max_chromo.Max());
            GA.chromosome best_chromo = maxPopulation[index_of_max_chromo];

            int rectX = best_chromo.x0;
            int rectY = best_chromo.y0;
            int rectW = best_chromo.a * (int)Math.Sqrt(2);
            int rectH = best_chromo.b * (int)Math.Sqrt(2);

            Graphics graphics = Graphics.FromImage(output_image);
            Pen pen = new Pen(Color.FromKnownColor(KnownColor.Red), 3);

            graphics.DrawRectangle(pen, rectX, rectY, rectW, rectH);

            frmShowResult frm = new frmShowResult(output_image);
            frm.Show();
        }
    }
}
