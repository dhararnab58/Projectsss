using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SharpUpdate;
namespace Project
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        private SharpUpdater updater;
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
        #region SharpUpdate
        public string ApplicationName
        {
            get { return "Project"; }
        }

        public string ApplicationID
        {
            get { return "Project"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://raw.githubusercontent.com/dhararnab58/Projectsss/master/Update.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion
    }
}
