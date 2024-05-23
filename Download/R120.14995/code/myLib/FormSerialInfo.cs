using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class FormSerialInfo : Form
    {
        #region Local Variables
        public static string TraceClass;
        #endregion

        #region Classes
        // Create an instance of classes
#pragma warning disable
        private static FrmTerminal s_parentForm;
#pragma warning restore
        #endregion // Classes

        #region Constructor
        public FormSerialInfo(FrmTerminal parent)
        {
            TraceClass = GetType().Name; // Assign the class name to the static variable
            s_parentForm = parent;
            InitializeComponent();
        }
        #endregion // Constructor

    }
}
