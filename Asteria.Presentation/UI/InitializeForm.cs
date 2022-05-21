using DevExpress.XtraEditors;
using Asteria.Common;
using Asteria.Presentation.ManagementObjects;
using System;
using System.Windows.Forms;

namespace Asteria.Presentation.UI
{
    public partial class InitializeForm : XtraForm
    {
        private static InitializeForm _current;

        public static InitializeForm Current
        {
            get 
            {
                if (_current == null) return new InitializeForm();
                return _current; 
            }
        }

        private InitializeForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Hide();
        }

        private void InitializeForm_Load(object sender, System.EventArgs e)
        {
            Islem<LoginUI_MO, LoginUI>();
        }

        public void Islem<MO, UI>() where MO : class, new() where UI : Form, new()
        {
            MO mo = new MO();
        }
    }
}