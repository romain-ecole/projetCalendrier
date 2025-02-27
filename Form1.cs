using System.CodeDom.Compiler;
using System.Numerics;

namespace calendrier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string txt = Txt.Text;
                int annee = Convert.ToInt16(txt.Substring(6, 4));
                int fevr = 59;
                int jour = Convert.ToInt16(txt.Substring(0, 2));

                if (annee % 4 == 0)
                {
                    if (annee % 100 == 0)
                    {
                        if (annee % 400 == 0)
                        {
                            fevr = 60;
                        }
                    }
                    else
                    {
                        fevr = 60;
                    }
                }

                string[] weekDays = ["Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"];
                string[] month = ["Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"];
                int[] days = [0, 31, fevr, fevr + 31, fevr + 61, fevr + 92, fevr + 122, fevr + 153, fevr + 184, fevr + 214, fevr + 245, fevr + 275];

                jour += (annee * 365) + ((annee - 1) / 4) + ((annee - 1) / 400) - ((annee - 1) / 100) - 365 + days[Convert.ToInt16(txt.Substring(3, 2)) - 1];
                LabDate.Text = "Nous sommes le : " + weekDays[((jour % 7) + 7 - 1) % 7] + " " + txt.Substring(0, 2) + " " + month[Convert.ToInt16(txt.Substring(3, 2)) - 1] + " " + annee + ".";
            }
        }
    }
}
