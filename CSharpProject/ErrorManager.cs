using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class ErrorManager
    {
        private class ErrorControl
        {
            public ErrorControl()
            {
                this.errorProvider = new ErrorProvider();
                this.havingError = false;
            }

            public void SetError(Control control,string message)
            {
                errorProvider.SetError(control, message);
                havingError = true;
            }

            public void ClearError()
            {
                errorProvider.Clear();
                havingError = false;
            }

            public bool isHavingError()
            {
                return havingError;
            }
            
            public ErrorProvider errorProvider;
            private bool havingError;
        }
        
        private Dictionary<Control, ErrorControl> dictionary;

        public void Add(Control control)
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<Control, ErrorControl>();
            }
            dictionary.Add(control, new ErrorControl());

        }


        public void ShowError(Control control, string errorMessage)
        {
            ErrorControl errorControl = GetErrorControl(control);
            if (errorControl == null)
            {
                Add(control);
                errorControl = GetErrorControl(control);

            }
            errorControl.SetError(control, errorMessage);
        }

        public bool IsHavingError(Control control)
        {
            return dictionary[control].isHavingError();
        }
        public bool IsAnyHavingError()
        {
            foreach (KeyValuePair<Control, ErrorControl> pair in dictionary)
            {
                if (pair.Value.isHavingError())
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear(Control control)
        {
            ErrorControl errorControl = GetErrorControl(control);
            if (errorControl == null)
            {
                Add(control);
                errorControl = GetErrorControl(control);
            }
            errorControl.ClearError();
        }

        private ErrorControl GetErrorControl(Control control)
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<Control, ErrorControl>();
                return null;
            }
            else
            {
                try
                {
                    return dictionary[control];
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
            }
        }

        

        public void ClearAll()
        {
            foreach (KeyValuePair<Control, ErrorControl> pair in dictionary)
            {
                ErrorProvider errorProvider = pair.Value.errorProvider;
                errorProvider.Clear();
            }
        }
    }
}
