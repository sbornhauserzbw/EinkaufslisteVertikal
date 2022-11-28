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

            // Ausbau in die Vertikale (5)
            DiskOperations diskOp = new DiskOperations();
            LstShopping.Items.AddRange(diskOp.LoadFromDisk().ToArray());
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (TxtShopping.Text != "")
            {
                // Ausbau in die Vertikale (1)
                LstShopping.Items.Add(TxtShopping.Text);

                // Ausbau in die Vertikale (3)
                List<string> shoppingList = new List<string>();
                shoppingList = LstShopping.Items.Cast<string>().ToList();
                
                DiskOperations diskOp = new DiskOperations();
                diskOp.SaveToDisk(shoppingList);
            }
        }
    }
}