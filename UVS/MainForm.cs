using System;
using System.Windows.Forms;
using Controller.Abstract;
using DIR;

namespace UVS
{
    public partial class MainForm : Form, IView
    {
        private Object myLock = new Object();
        IController controller;

        public MainForm()
        {
            InitializeComponent();
            SetUpControlls();
            controller = NinjectFactory.Resolve<IController>(this);
        }

        private void SetUpControlls()
        {
            lstv_List.Columns.Add("Thread ID", -2, HorizontalAlignment.Left);
            lstv_List.Columns.Add("Data", -2, HorizontalAlignment.Left);
            lstv_List.View = View.Details;

            num_ThreadCount.Minimum = 2;
            num_ThreadCount.Maximum = 15;
            num_ThreadCount.ReadOnly = true;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            controller.Start((int)num_ThreadCount.Value);
        }

        public void AddToListView(IGeneratedData data)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<IGeneratedData>(AddToListView), new object[] { data });
                return;
            }

            lock (myLock)
            {
                if (lstv_List.Items.Count >= 20)
                {
                    lstv_List.Items[0].Remove();
                }
                var item = new ListViewItem(data.ThreadID.ToString());
                item.SubItems.Add(data.Data);
                lstv_List.Items.Add(item);
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            controller.Stop();
        }

        public void ShowErrorMessage(Exception ex)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<Exception>(ShowErrorMessage), new object[] { ex });
                return;
            }

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EnableStartButton()
        {
            CheckAndInvoke(new Action(EnableStartButton));
            bt_Start.Enabled = true;
        }

        public void DisableStartButton()
        {
            CheckAndInvoke(new Action(DisableStartButton));
            bt_Start.Enabled = false;
        }

        public void EnableStopButton()
        {
            CheckAndInvoke(new Action(EnableStopButton));
            bt_Stop.Enabled = true;
        }

        public void DisableStopButton()
        {
            CheckAndInvoke(new Action(DisableStopButton));
            bt_Stop.Enabled = false;
        }

        private void ts_UpperMenu_bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckAndInvoke(Delegate check)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(check);
                return;
            }
        }
    }
}
