
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockChainCourse.Cryptography;

namespace Blockchain_Test
{
    public partial class frmHash : Form
    {
        public frmHash()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHash256_Click(object sender, EventArgs e)
        {
            string chuoi1;
            chuoi1 = this.txtChuoiCanHash.Text.Trim();
            var sha256HashedMessage = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(chuoi1));
            this.txtMaBam.Text = Convert.ToBase64String(sha256HashedMessage);
          
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {

        }
    }
}
