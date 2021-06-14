using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03_WinForm_Warcraft
{
    public partial class MainWindow : Form
    {
        public static Horde Thral = new Horde();

        public void InitHordeTempData()
        {
            Thral.AddOrc("Troll Bloodminer", 100, 45, true);
            Thral.AddOrc("Kovásznai Silentkiller", 90, 42, true);
            Thral.AddOrc("Kusper Blindhunter", 0, 20, false);
            Thral.AddOrc("Balla Spiritgrinder", 91, 43, true);
            Thral.AddOrc("Király Speedtalker", 75, 45, false);
        }
        public void InitDgvOrcs()
        {
            dgvOrcs.Columns.Clear();
            dgvOrcs.Rows.Clear();
            dgvOrcs.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn colId =
                new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.Visible = false;
            dgvOrcs.Columns.Add(colId);

            DataGridViewTextBoxColumn colName =
                new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.HeaderText = "Name";
            colName.Width = 200;
            dgvOrcs.Columns.Add(colName);

            DataGridViewTextBoxColumn colHealth =
                new DataGridViewTextBoxColumn();
            colHealth.Name = "Health";
            colHealth.HeaderText = "Health";
            colHealth.Width = 80;
            dgvOrcs.Columns.Add(colHealth);

            DataGridViewCheckBoxColumn colDead =
                new DataGridViewCheckBoxColumn();
            colDead.Name = "Dead";
            colDead.HeaderText = "Dead";
            colDead.Width = 60;
            dgvOrcs.Columns.Add(colDead);

            DataGridViewTextBoxColumn colDamage =
                new DataGridViewTextBoxColumn();
            colDamage.Name = "Damage";
            colDamage.HeaderText = "Damage";
            colDamage.Width = 80;
            dgvOrcs.Columns.Add(colDamage);

            DataGridViewCheckBoxColumn colCouncilor =
                new DataGridViewCheckBoxColumn();
            colCouncilor.Name = "Councilor";
            colCouncilor.HeaderText = "Councilor";
            colCouncilor.Width = 80;
            dgvOrcs.Columns.Add(colCouncilor);
        }
        public void UpdateDgvOrcs()
        {
            dgvOrcs.Rows.Clear();
            foreach (Orc orc in Thral.Orcs)
                dgvOrcs.Rows.Add(orc.Id, orc.Name, orc.Health,
                    orc.Dead, orc.Damage, orc.Councilor);
        }

        public MainWindow()
        {
            InitializeComponent();

            if (!Directory.Exists(Settings.Default.DirectoryImages))
                Directory.CreateDirectory(Settings.Default.DirectoryImages);

            InitHordeTempData();
            InitDgvOrcs();
            UpdateDgvOrcs();
        }

        private void btnAddOrc_Click(object sender, EventArgs e)
        {
            AddOrcForm addOrc = new AddOrcForm();
            addOrc.ShowDialog();
            UpdateDgvOrcs();
        }

        private void dgvOrcs_DoubleClick(object sender, EventArgs e)
        {
            uint selectedId = Convert.ToUInt32(
                dgvOrcs.SelectedRows[0].Cells["Id"].Value.ToString());
            DisplayOrcForm displayOrc = new DisplayOrcForm(selectedId);
            displayOrc.ShowDialog();
        }
    }
}
