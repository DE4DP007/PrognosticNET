using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewEx.Entities;

namespace DataGridViewEx
{
    public partial class Form1 : Form
    {
        BindingList<BusinessInformatics> data;
        BindingList<BusinessInformatics_Res> data2;
        public Form1()
        {
            int n = 100;
            int m = 5;
            InitializeComponent();
            //learning
            data = new BindingList<BusinessInformatics>();
            data2 = new BindingList<BusinessInformatics_Res>();
            for (int j = 0; j < n; j++) {
                data.Add(new BusinessInformatics(3));
                data2.Add(new BusinessInformatics_Res(3));
            }
            dgwLearning_Input.DataSource = data;
            dgwLearning_Output.DataSource = data2;
            //progress
            data = new BindingList<BusinessInformatics>();
            data2 = new BindingList<BusinessInformatics_Res>();
            for (int j = 0; j < m; j++) {
                data.Add(new BusinessInformatics(3));
                data2.Add(new BusinessInformatics_Res(3));
            }
            dgwProgress_Input.DataSource = data;
            dgwProgress_Output.DataSource = data2;
        }

        
    }
}
