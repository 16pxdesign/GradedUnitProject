using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject
{
    interface FormComunicatorInterface
    {
        void OnFormClose();
        void OpenChildForm(Form form);
       
    }
}
