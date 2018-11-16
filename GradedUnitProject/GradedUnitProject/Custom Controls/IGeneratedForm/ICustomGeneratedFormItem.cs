using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedUnitProject.Custom_Controls.IGeneratedForm
{
    public interface ICustomGeneratedFormItem
    {
        ICustomGeneratedFormItem NewRow(String name);
        ICustomGeneratedFormItem NewItem();
        CustomGeneratedFormBuilder Build();
    }
}
