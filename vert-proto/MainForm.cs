namespace vert_proto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CmbBoxList.SelectedIndex= 0;
            TxtShopping.Select();
        }
    }
}