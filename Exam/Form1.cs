using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        CinemaDBContext context;
        public Form1()
        {
            InitializeComponent();
            context = new CinemaDBContext();
            GetName();
        }
        private void GetName()
        {
            List<Film> names = context.Films.ToList();
            foreach(Film film in names)
            {
                listBox1.Items.Add(film.Name);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                int i = listBox1.SelectedIndex;
                List<Session> sessions = context.Sessions.ToList();
                List<Film> films = context.Films.ToList();
                textBox1.Text = (from y in sessions where films[i].Id == y.film.Id select y).Count().ToString();

            }
        }
    }
}
