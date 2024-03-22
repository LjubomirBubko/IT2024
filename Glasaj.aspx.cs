using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1
{
    public partial class About : Page
    {
        string[] professorsDB = new string[]
       {
                "вонр. проф. д-р Весна Димитрова",
                "доц. д-р Гоце Арменски",
                "доц. д-р Слободан Калајџиски"
       };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] subjectsDB = new string[]
                {
                    "Дигитална Форензика",
                    "Интернет Технологии",
                    "Бази на податоци"
                };

                foreach (string s in subjectsDB)
                {
                    listSubjects.Items.Add(s);
                }

                string[] creditsDB = new string[]
                {
                    "6",
                    "3",
                    "7"
                };

                for (int i = 0; i < creditsDB.Length; i++)
                {
                    listCredits.Items.Add(creditsDB[i]);
                }

                listSubjects.SelectedIndex = 0;
                listCredits.SelectedIndex = 0;
            }
        }

        protected void btnAddSubject_Click(object sender, EventArgs e)
        {
            ListItem newSubject = new ListItem(addSubject.Text);
            ListItem newCredit = new ListItem(addCredit.Text);

            if (newSubject.Text != "" && newCredit.Text != "")
            {
                listSubjects.Items.Add(newSubject);
                listCredits.Items.Add(newCredit);
                addSubject.Text = "";
                addCredit.Text = "";
            }
        }

        protected void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (listSubjects.SelectedIndex != -1)
            {
                int i = listSubjects.SelectedIndex;
                listSubjects.Items.RemoveAt(i);
                listCredits.Items.RemoveAt(i);
            }
        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            Response.Redirect("UspeshnoGlasanje.aspx");
        }

        protected void listSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listCredits.SelectedIndex = listSubjects.SelectedIndex;

            if (listSubjects.SelectedIndex >= professorsDB.Length)
            {
                lblProfessor.Text = "проф. по " + listSubjects.Text;
            }

            else
            {
                lblProfessor.Text = professorsDB[listSubjects.SelectedIndex];
            }
        }

        protected void addCredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}