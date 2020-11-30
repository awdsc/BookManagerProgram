using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageProgram
{
    public partial class MemberManageForm : Form
    {
        public MemberManageForm()
        {
            InitializeComponent();
        }

        private void 회원검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberSearchForm().ShowDialog();
        }
    }
}
