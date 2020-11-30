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
    public partial class BookManageForm : Form
    {
        public BookManageForm()
        {
            InitializeComponent();
        }

        private void 대출반납ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new BorrowBookForm().ShowDialog();
            new ReturnBookForm().ShowDialog();
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MemberSearchForm().ShowDialog();
        }
    }
}
