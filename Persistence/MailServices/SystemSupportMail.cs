using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.MailServices
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "jmanagementsupp@gmail.com";
            password = ";@#Management@!$05532:#";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializeSmtpClient();
        }
    }
}
