using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;

namespace MyMacro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            macroList = null;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern bool ReleaseCapture();

        private Macro[] macroList;
        private bool macrosRunning = false;
        private Window window;

        private void cmbApplication_Click(object sender, EventArgs e)
        {
            cmbApplication.Items.Clear();
            foreach (Window window in Applications.getActiveWindows())
            {
                string windowTitle = window.getTitle();
                if(windowTitle.Length > 0)
                    cmbApplication.Items.Add(window);
            }
        }

        private void gridMacroList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1)
                return;

            if (e.RowIndex >= 0)
                gridMacroList[1, e.RowIndex].Value = "Presione una tecla...";
        }

        private void gridMacroList_KeyPress(object sender, KeyPressEventArgs e)
        {
            int selectedRowIndex = gridMacroList.SelectedCells[0].RowIndex;
            int selectedColumnIndex = gridMacroList.SelectedCells[0].ColumnIndex;

            if (selectedColumnIndex != 1)
                return;

            gridMacroList[selectedColumnIndex, selectedRowIndex].Value = e.KeyChar;
        }

        private void checkWindowInForeground()
        {
            while (macrosRunning)
            {
                if (GetAsyncKeyState(0x14) != 0)
                //if (!window.isForegroundWindow())
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        btnActivate_Click(null, null);
                    }));
                    return;
                }
                Thread.Sleep(50);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (cmbApplication.SelectedIndex < 0)
                return;

            if (macrosRunning)
            {
                foreach (Macro macro in macroList)
                {
                    macro.Stop();
                }
                btnActivate.Text = "Activar";
                cmbApplication.Enabled = true;
                gridMacroList.Enabled = true;
                macrosRunning = false;

                return;
            }
            else
            {
                btnActivate.Text = "Detener";
                cmbApplication.Enabled = false;
                gridMacroList.Enabled = false;
                macrosRunning = true;
            }


            window = (Window)cmbApplication.SelectedItem;
            //window.setForegroundWindow();

            macroList = buildMacroList();
            foreach (Macro macro in macroList)
            {
                macro.Start(window);
                Thread.Sleep(100);
            }

            Thread checkWindowInForegroundThread = new Thread(new ThreadStart(checkWindowInForeground));
            checkWindowInForegroundThread.Start();
        }

        private Macro[] buildMacroList()
        {
            ArrayList tempList = new ArrayList();
            foreach (DataGridViewRow row in gridMacroList.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                bool active = (bool)row.Cells[0].Value;

                if (!active)
                    continue;

                string key = row.Cells[1].Value.ToString();
                string description = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : "";
                int interval = int.Parse(row.Cells[3].Value.ToString());

                Macro macro = new Macro((int)key[0], interval);
                tempList.Add(macro);
            }
            Macro[] macroList = new Macro[tempList.Count];
            for (int i = 0; i < tempList.Count; i++)
            {
                macroList[i] = (Macro)tempList[i];
            }

            return macroList;
        }

        private void gridMacroList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool invalidData = false;

                string key = gridMacroList[1, e.RowIndex].Value.ToString();
                invalidData = key.Length != 1 || !char.IsLetterOrDigit(key[0]);

                if (!invalidData)
                {
                    int interval;
                    invalidData = !int.TryParse(gridMacroList[3, e.RowIndex].Value.ToString(), out interval);
                }
                
                if (invalidData)
                {
                    gridMacroList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    btnActivate.Enabled = false;
                }
                else
                {
                    gridMacroList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    foreach (DataGridViewRow row in gridMacroList.Rows)
                    {
                        if (row.DefaultCellStyle.BackColor == Color.Red)
                        {
                            btnActivate.Enabled = false;
                            return;
                        }
                    }
                    btnActivate.Enabled = true;
                }
            }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (macrosRunning)
            {
                foreach (Macro macro in macroList)
                {
                    macro.Stop();
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xa1, 0x2, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = MyMacro.Properties.Resources.minimize_hover;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = MyMacro.Properties.Resources.minimize;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = MyMacro.Properties.Resources.close_hover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = MyMacro.Properties.Resources.close;
        }
    }
}
