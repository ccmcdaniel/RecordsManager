namespace RecordsManager
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecordsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRecordsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecordsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFIrstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblFileOpen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRecordsFileToolStripMenuItem,
            this.createRecordsFileToolStripMenuItem,
            this.saveRecordsFileToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRecordsFileToolStripMenuItem
            // 
            this.openRecordsFileToolStripMenuItem.Name = "openRecordsFileToolStripMenuItem";
            this.openRecordsFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openRecordsFileToolStripMenuItem.Text = "New Records File";
            this.openRecordsFileToolStripMenuItem.Click += new System.EventHandler(this.openRecordsFileToolStripMenuItem_Click);
            // 
            // createRecordsFileToolStripMenuItem
            // 
            this.createRecordsFileToolStripMenuItem.Name = "createRecordsFileToolStripMenuItem";
            this.createRecordsFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createRecordsFileToolStripMenuItem.Text = "Create Records File";
            this.createRecordsFileToolStripMenuItem.Click += new System.EventHandler(this.createRecordsFileToolStripMenuItem_Click);
            // 
            // saveRecordsFileToolStripMenuItem
            // 
            this.saveRecordsFileToolStripMenuItem.Name = "saveRecordsFileToolStripMenuItem";
            this.saveRecordsFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveRecordsFileToolStripMenuItem.Text = "Save Records File";
            this.saveRecordsFileToolStripMenuItem.Click += new System.EventHandler(this.saveRecordsFileToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFileOpen, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colFIrstName,
            this.colLastName,
            this.colBalance});
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(600, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colID
            // 
            this.colID.FillWeight = 10F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colFIrstName
            // 
            this.colFIrstName.FillWeight = 40F;
            this.colFIrstName.HeaderText = "First Name";
            this.colFIrstName.Name = "colFIrstName";
            // 
            // colLastName
            // 
            this.colLastName.FillWeight = 40F;
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            // 
            // colBalance
            // 
            this.colBalance.FillWeight = 10F;
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            // 
            // lblFileOpen
            // 
            this.lblFileOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileOpen.Location = new System.Drawing.Point(3, 0);
            this.lblFileOpen.Name = "lblFileOpen";
            this.lblFileOpen.Size = new System.Drawing.Size(794, 30);
            this.lblFileOpen.TabIndex = 1;
            this.lblFileOpen.Text = "File Open: ";
            this.lblFileOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Records Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openRecordsFileToolStripMenuItem;
        private ToolStripMenuItem createRecordsFileToolStripMenuItem;
        private ToolStripMenuItem saveRecordsFileToolStripMenuItem;
        private ToolStripMenuItem exitProgramToolStripMenuItem;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFIrstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colBalance;
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblFileOpen;
    }
}