using Presentation.MessageBoxForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public abstract class ResultMessageBox
    {
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new LogoutMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
    }
}
