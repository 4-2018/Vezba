using BuissnessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly RestaurantBuissness buissness;
        public Form1()
        {
            this.buissness = new RestaurantBuissness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
        }
        public void FillList()
        {
            listBoxMenu.Items.Clear();
            List<Restaurant> restaurants = this.buissness.GetAllMenuItems();
            foreach (var item in restaurants)
            {
                listBoxMenu.Items.Add(item.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Restaurant r = new Restaurant();
            r.Title = textBoxTitle.Text;
            r.Description = textBoxDescription.Text;
            r.Price = Convert.ToDecimal(textBoxPrice.Text);

            bool result = this.buissness.InsertMenuItems(r);

            if(result)
            {
                FillList();
                MessageBox.Show("Uspesno ste uneli jelo!");
            }else
            {
                MessageBox.Show("Neuspesan unos!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Clear();
            decimal min = Convert.ToDecimal(textBoxMInPrice.Text);
            decimal max = Convert.ToDecimal(textBoxMaxPrice.Text);

            List<Restaurant> restaurants = this.buissness.Between(min, max);
            
            foreach(var r in restaurants)
            {
                listBoxMenu.Items.Add(r);
            }






        }
    }
}
