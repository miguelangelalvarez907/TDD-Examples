using Lotto.Age.Predictor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto.Age.Predictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IUser user = new User();
            ILottoAge lottoAge = new LottoAge();


            var name = txtName.Text;
            var dob = mnCalDob.SelectionEnd.Year;

            var validateName = user.ValidateName(name);

            if (validateName)
            {
                var validateAge = lottoAge.CalculateAge(dob);

                var predictAge = lottoAge.PredictLottoAge(validateAge);

                MessageBox.Show($"Your age will be: {predictAge}");

                txtName.Name = String.Empty;
                mnCalDob.ResetText();
            }         
        }
    }
}
