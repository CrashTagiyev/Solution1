using LibraryProject.DataLayer.Repositories.Concretes;
using LibraryProject.Models.Entities.Concretes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryRepository<Category> ct = new();
            foreach (var item in ct.GetAll())
            {
                ListViewItem lwitem = new ListViewItem(item.Name);
                LB_Data.Items.Add(lwitem.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibraryRepository<Category> ct = new();
            var cat = ct.GetById(Convert.ToInt32(textBox1.Text));
            if (cat == null) throw new Exception("Not found");
            LB_Data.Items.Clear();
            LB_Data.Items.Add(cat.Name);
        }

        private void AddAuthor_Button_Click(object sender, EventArgs e)
        {
            LibraryRepository<Author> ct = new();
            ct.Add(new Author() { Firstname = TB_Author_Firstname.Text, Lastname = TB_Author_Lastname.Text });
        }


    }
}