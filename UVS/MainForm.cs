using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ninject.Modules;
using Controller.Abstract;
using Tools;

namespace UVS
{
    public partial class MainForm : Form, IForm
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(EnableStartButton));
                return;
            }
            bt_Start.Enabled = true;
        }

        public void DisableStartButton()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(DisableStartButton));
                return;
            }
            bt_Start.Enabled = false;
        }

        public void EnableStopButton()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(EnableStopButton));
                return;
            }
            bt_Stop.Enabled = true;
        }

        public void DisableStopButton()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(DisableStopButton));
                return;
            }
            bt_Stop.Enabled = false;
        }
    }
}
