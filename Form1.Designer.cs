namespace PerontCacheSimulator
{
    partial class CacheSimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CacheSimForm));
            this.Memory_Panel = new System.Windows.Forms.Panel();
            this.Mem4 = new System.Windows.Forms.ListView();
            this.Address_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mem3 = new System.Windows.Forms.ListView();
            this.Address_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mem2 = new System.Windows.Forms.ListView();
            this.Address_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.Mem1 = new System.Windows.Forms.ListView();
            this.Address_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMemoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearCacheMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Simulator_Panel = new System.Windows.Forms.Panel();
            this.HM_Colon = new System.Windows.Forms.Label();
            this.HM_Slash = new System.Windows.Forms.Label();
            this.HM_Miss = new System.Windows.Forms.Label();
            this.HM_Hit = new System.Windows.Forms.Label();
            this.HM_Data = new System.Windows.Forms.Label();
            this.HM_Tag = new System.Windows.Forms.Label();
            this.LAC = new System.Windows.Forms.Label();
            this.LAC_Label = new System.Windows.Forms.Label();
            this.AddressInputButton = new System.Windows.Forms.Button();
            this.AddressInputLabel = new System.Windows.Forms.Label();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.Cache_Panel = new System.Windows.Forms.Panel();
            this.Cache = new System.Windows.Forms.Panel();
            this.Set11 = new System.Windows.Forms.Label();
            this.Set10 = new System.Windows.Forms.Label();
            this.Set01 = new System.Windows.Forms.Label();
            this.Set00 = new System.Windows.Forms.Label();
            this.Data_32 = new System.Windows.Forms.Label();
            this.Tag_32 = new System.Windows.Forms.Label();
            this.Data_31 = new System.Windows.Forms.Label();
            this.Tag_31 = new System.Windows.Forms.Label();
            this.Data_22 = new System.Windows.Forms.Label();
            this.Tag_22 = new System.Windows.Forms.Label();
            this.Data_21 = new System.Windows.Forms.Label();
            this.Tag_21 = new System.Windows.Forms.Label();
            this.Data_12 = new System.Windows.Forms.Label();
            this.Tag_12 = new System.Windows.Forms.Label();
            this.Data_11 = new System.Windows.Forms.Label();
            this.Tag_11 = new System.Windows.Forms.Label();
            this.Data_02 = new System.Windows.Forms.Label();
            this.Tag_02 = new System.Windows.Forms.Label();
            this.Data_01 = new System.Windows.Forms.Label();
            this.Tag_01 = new System.Windows.Forms.Label();
            this.Cache_Data_2 = new System.Windows.Forms.Label();
            this.Cache_Tag_2 = new System.Windows.Forms.Label();
            this.Cache_Data_1 = new System.Windows.Forms.Label();
            this.Cache_Tag_1 = new System.Windows.Forms.Label();
            this.ClearCacheButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Memory_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Simulator_Panel.SuspendLayout();
            this.Cache_Panel.SuspendLayout();
            this.Cache.SuspendLayout();
            this.SuspendLayout();
            // 
            // Memory_Panel
            // 
            this.Memory_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Memory_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Memory_Panel.Controls.Add(this.Mem4);
            this.Memory_Panel.Controls.Add(this.Mem3);
            this.Memory_Panel.Controls.Add(this.Mem2);
            this.Memory_Panel.Controls.Add(this.MemoryLabel);
            this.Memory_Panel.Controls.Add(this.Mem1);
            this.Memory_Panel.Location = new System.Drawing.Point(516, 0);
            this.Memory_Panel.Name = "Memory_Panel";
            this.Memory_Panel.Size = new System.Drawing.Size(477, 518);
            this.Memory_Panel.TabIndex = 1;
            // 
            // Mem4
            // 
            this.Mem4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_4,
            this.Data_4});
            this.Mem4.HideSelection = false;
            this.Mem4.Location = new System.Drawing.Point(361, 93);
            this.Mem4.Name = "Mem4";
            this.Mem4.Size = new System.Drawing.Size(104, 400);
            this.Mem4.TabIndex = 6;
            this.Mem4.UseCompatibleStateImageBehavior = false;
            this.Mem4.View = System.Windows.Forms.View.Details;
            // 
            // Address_4
            // 
            this.Address_4.Text = "Address";
            this.Address_4.Width = 50;
            // 
            // Data_4
            // 
            this.Data_4.Text = "Data";
            this.Data_4.Width = 50;
            // 
            // Mem3
            // 
            this.Mem3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_3,
            this.Data_3});
            this.Mem3.HideSelection = false;
            this.Mem3.Location = new System.Drawing.Point(251, 93);
            this.Mem3.Name = "Mem3";
            this.Mem3.Size = new System.Drawing.Size(104, 400);
            this.Mem3.TabIndex = 5;
            this.Mem3.UseCompatibleStateImageBehavior = false;
            this.Mem3.View = System.Windows.Forms.View.Details;
            // 
            // Address_3
            // 
            this.Address_3.Text = "Address";
            this.Address_3.Width = 50;
            // 
            // Data_3
            // 
            this.Data_3.Text = "Data";
            this.Data_3.Width = 50;
            // 
            // Mem2
            // 
            this.Mem2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_2,
            this.Data_2});
            this.Mem2.HideSelection = false;
            this.Mem2.Location = new System.Drawing.Point(141, 93);
            this.Mem2.Name = "Mem2";
            this.Mem2.Size = new System.Drawing.Size(104, 400);
            this.Mem2.TabIndex = 4;
            this.Mem2.UseCompatibleStateImageBehavior = false;
            this.Mem2.View = System.Windows.Forms.View.Details;
            // 
            // Address_2
            // 
            this.Address_2.Text = "Address";
            this.Address_2.Width = 50;
            // 
            // Data_2
            // 
            this.Data_2.Text = "Data";
            this.Data_2.Width = 50;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(169, 38);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(163, 36);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Main Memory";
            // 
            // Mem1
            // 
            this.Mem1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address_1,
            this.Data_1});
            this.Mem1.HideSelection = false;
            this.Mem1.Location = new System.Drawing.Point(31, 93);
            this.Mem1.Name = "Mem1";
            this.Mem1.Size = new System.Drawing.Size(104, 400);
            this.Mem1.TabIndex = 3;
            this.Mem1.UseCompatibleStateImageBehavior = false;
            this.Mem1.View = System.Windows.Forms.View.Details;
            // 
            // Address_1
            // 
            this.Address_1.Text = "Address";
            this.Address_1.Width = 50;
            // 
            // Data_1
            // 
            this.Data_1.Text = "Data";
            this.Data_1.Width = 50;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMemoryMenu,
            this.ClearCacheMenu});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ViewMemoryMenu
            // 
            this.ViewMemoryMenu.AccessibleName = "ViewMemory";
            this.ViewMemoryMenu.Checked = true;
            this.ViewMemoryMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewMemoryMenu.Name = "ViewMemoryMenu";
            this.ViewMemoryMenu.Size = new System.Drawing.Size(180, 22);
            this.ViewMemoryMenu.Text = "View Memory";
            this.ViewMemoryMenu.Click += new System.EventHandler(this.ViewMemoryMenu_Click);
            // 
            // ClearCacheMenu
            // 
            this.ClearCacheMenu.Name = "ClearCacheMenu";
            this.ClearCacheMenu.Size = new System.Drawing.Size(180, 22);
            this.ClearCacheMenu.Text = "Clear Cache";
            this.ClearCacheMenu.Click += new System.EventHandler(this.ClearCacheMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpMenu,
            this.AboutMenu});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // ViewHelpMenu
            // 
            this.ViewHelpMenu.Name = "ViewHelpMenu";
            this.ViewHelpMenu.Size = new System.Drawing.Size(180, 22);
            this.ViewHelpMenu.Text = "View Help";
            this.ViewHelpMenu.Click += new System.EventHandler(this.ViewHelpMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(180, 22);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Simulator_Panel
            // 
            this.Simulator_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Simulator_Panel.Controls.Add(this.HM_Colon);
            this.Simulator_Panel.Controls.Add(this.HM_Slash);
            this.Simulator_Panel.Controls.Add(this.HM_Miss);
            this.Simulator_Panel.Controls.Add(this.HM_Hit);
            this.Simulator_Panel.Controls.Add(this.HM_Data);
            this.Simulator_Panel.Controls.Add(this.HM_Tag);
            this.Simulator_Panel.Controls.Add(this.LAC);
            this.Simulator_Panel.Controls.Add(this.LAC_Label);
            this.Simulator_Panel.Controls.Add(this.AddressInputButton);
            this.Simulator_Panel.Controls.Add(this.AddressInputLabel);
            this.Simulator_Panel.Controls.Add(this.AddressInput);
            this.Simulator_Panel.Location = new System.Drawing.Point(0, 0);
            this.Simulator_Panel.Name = "Simulator_Panel";
            this.Simulator_Panel.Size = new System.Drawing.Size(516, 194);
            this.Simulator_Panel.TabIndex = 3;
            // 
            // HM_Colon
            // 
            this.HM_Colon.AutoSize = true;
            this.HM_Colon.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Colon.Location = new System.Drawing.Point(342, 144);
            this.HM_Colon.Name = "HM_Colon";
            this.HM_Colon.Size = new System.Drawing.Size(15, 15);
            this.HM_Colon.TabIndex = 11;
            this.HM_Colon.Text = ":";
            // 
            // HM_Slash
            // 
            this.HM_Slash.AutoSize = true;
            this.HM_Slash.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Slash.Location = new System.Drawing.Point(284, 144);
            this.HM_Slash.Name = "HM_Slash";
            this.HM_Slash.Size = new System.Drawing.Size(15, 15);
            this.HM_Slash.TabIndex = 10;
            this.HM_Slash.Text = "/";
            // 
            // HM_Miss
            // 
            this.HM_Miss.AutoSize = true;
            this.HM_Miss.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Miss.Location = new System.Drawing.Point(305, 144);
            this.HM_Miss.Name = "HM_Miss";
            this.HM_Miss.Size = new System.Drawing.Size(39, 15);
            this.HM_Miss.TabIndex = 9;
            this.HM_Miss.Text = "Miss";
            // 
            // HM_Hit
            // 
            this.HM_Hit.AutoSize = true;
            this.HM_Hit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HM_Hit.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Hit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HM_Hit.Location = new System.Drawing.Point(247, 144);
            this.HM_Hit.Name = "HM_Hit";
            this.HM_Hit.Size = new System.Drawing.Size(31, 15);
            this.HM_Hit.TabIndex = 8;
            this.HM_Hit.Text = "Hit";
            // 
            // HM_Data
            // 
            this.HM_Data.AutoSize = true;
            this.HM_Data.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Data.Location = new System.Drawing.Point(363, 159);
            this.HM_Data.Name = "HM_Data";
            this.HM_Data.Size = new System.Drawing.Size(0, 15);
            this.HM_Data.TabIndex = 7;
            // 
            // HM_Tag
            // 
            this.HM_Tag.AutoSize = true;
            this.HM_Tag.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HM_Tag.Location = new System.Drawing.Point(363, 144);
            this.HM_Tag.Name = "HM_Tag";
            this.HM_Tag.Size = new System.Drawing.Size(0, 15);
            this.HM_Tag.TabIndex = 6;
            // 
            // LAC
            // 
            this.LAC.AutoSize = true;
            this.LAC.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAC.Location = new System.Drawing.Point(363, 123);
            this.LAC.Name = "LAC";
            this.LAC.Size = new System.Drawing.Size(0, 15);
            this.LAC.TabIndex = 5;
            // 
            // LAC_Label
            // 
            this.LAC_Label.AutoSize = true;
            this.LAC_Label.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAC_Label.Location = new System.Drawing.Point(190, 123);
            this.LAC_Label.Name = "LAC_Label";
            this.LAC_Label.Size = new System.Drawing.Size(167, 15);
            this.LAC_Label.TabIndex = 3;
            this.LAC_Label.Text = "Last Address Called:";
            // 
            // AddressInputButton
            // 
            this.AddressInputButton.BackColor = System.Drawing.Color.White;
            this.AddressInputButton.Font = new System.Drawing.Font("Liberation Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInputButton.Location = new System.Drawing.Point(26, 144);
            this.AddressInputButton.Name = "AddressInputButton";
            this.AddressInputButton.Size = new System.Drawing.Size(124, 36);
            this.AddressInputButton.TabIndex = 2;
            this.AddressInputButton.Text = "Call Address";
            this.AddressInputButton.UseVisualStyleBackColor = false;
            this.AddressInputButton.Click += new System.EventHandler(this.AddressInputButton_Click);
            // 
            // AddressInputLabel
            // 
            this.AddressInputLabel.AutoSize = true;
            this.AddressInputLabel.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressInputLabel.Location = new System.Drawing.Point(23, 100);
            this.AddressInputLabel.Name = "AddressInputLabel";
            this.AddressInputLabel.Size = new System.Drawing.Size(127, 15);
            this.AddressInputLabel.TabIndex = 1;
            this.AddressInputLabel.Text = "2 Digit Address";
            // 
            // AddressInput
            // 
            this.AddressInput.Location = new System.Drawing.Point(26, 118);
            this.AddressInput.MaxLength = 2;
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(124, 20);
            this.AddressInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.AddressInput, "2 Digit Address between 0-63");
            this.AddressInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressInputCheckEnter);
            // 
            // Cache_Panel
            // 
            this.Cache_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cache_Panel.Controls.Add(this.Cache);
            this.Cache_Panel.Controls.Add(this.ClearCacheButton);
            this.Cache_Panel.Location = new System.Drawing.Point(0, 230);
            this.Cache_Panel.Name = "Cache_Panel";
            this.Cache_Panel.Size = new System.Drawing.Size(516, 288);
            this.Cache_Panel.TabIndex = 4;
            // 
            // Cache
            // 
            this.Cache.BackColor = System.Drawing.SystemColors.Window;
            this.Cache.Controls.Add(this.Set11);
            this.Cache.Controls.Add(this.Set10);
            this.Cache.Controls.Add(this.Set01);
            this.Cache.Controls.Add(this.Set00);
            this.Cache.Controls.Add(this.Data_32);
            this.Cache.Controls.Add(this.Tag_32);
            this.Cache.Controls.Add(this.Data_31);
            this.Cache.Controls.Add(this.Tag_31);
            this.Cache.Controls.Add(this.Data_22);
            this.Cache.Controls.Add(this.Tag_22);
            this.Cache.Controls.Add(this.Data_21);
            this.Cache.Controls.Add(this.Tag_21);
            this.Cache.Controls.Add(this.Data_12);
            this.Cache.Controls.Add(this.Tag_12);
            this.Cache.Controls.Add(this.Data_11);
            this.Cache.Controls.Add(this.Tag_11);
            this.Cache.Controls.Add(this.Data_02);
            this.Cache.Controls.Add(this.Tag_02);
            this.Cache.Controls.Add(this.Data_01);
            this.Cache.Controls.Add(this.Tag_01);
            this.Cache.Controls.Add(this.Cache_Data_2);
            this.Cache.Controls.Add(this.Cache_Tag_2);
            this.Cache.Controls.Add(this.Cache_Data_1);
            this.Cache.Controls.Add(this.Cache_Tag_1);
            this.Cache.Location = new System.Drawing.Point(26, 7);
            this.Cache.Name = "Cache";
            this.Cache.Size = new System.Drawing.Size(484, 214);
            this.Cache.TabIndex = 2;
            // 
            // Set11
            // 
            this.Set11.AutoSize = true;
            this.Set11.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set11.Location = new System.Drawing.Point(24, 173);
            this.Set11.Name = "Set11";
            this.Set11.Size = new System.Drawing.Size(63, 15);
            this.Set11.TabIndex = 23;
            this.Set11.Text = "Set 11:";
            // 
            // Set10
            // 
            this.Set10.AutoSize = true;
            this.Set10.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set10.Location = new System.Drawing.Point(24, 135);
            this.Set10.Name = "Set10";
            this.Set10.Size = new System.Drawing.Size(63, 15);
            this.Set10.TabIndex = 22;
            this.Set10.Text = "Set 10:";
            // 
            // Set01
            // 
            this.Set01.AutoSize = true;
            this.Set01.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set01.Location = new System.Drawing.Point(24, 97);
            this.Set01.Name = "Set01";
            this.Set01.Size = new System.Drawing.Size(63, 15);
            this.Set01.TabIndex = 21;
            this.Set01.Text = "Set 01:";
            // 
            // Set00
            // 
            this.Set00.AutoSize = true;
            this.Set00.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set00.Location = new System.Drawing.Point(24, 58);
            this.Set00.Name = "Set00";
            this.Set00.Size = new System.Drawing.Size(63, 15);
            this.Set00.TabIndex = 20;
            this.Set00.Text = "Set 00:";
            // 
            // Data_32
            // 
            this.Data_32.AutoSize = true;
            this.Data_32.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_32.Location = new System.Drawing.Point(382, 173);
            this.Data_32.Name = "Data_32";
            this.Data_32.Size = new System.Drawing.Size(0, 15);
            this.Data_32.TabIndex = 19;
            // 
            // Tag_32
            // 
            this.Tag_32.AutoSize = true;
            this.Tag_32.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_32.Location = new System.Drawing.Point(287, 173);
            this.Tag_32.Name = "Tag_32";
            this.Tag_32.Size = new System.Drawing.Size(0, 15);
            this.Tag_32.TabIndex = 18;
            // 
            // Data_31
            // 
            this.Data_31.AutoSize = true;
            this.Data_31.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_31.Location = new System.Drawing.Point(182, 173);
            this.Data_31.Name = "Data_31";
            this.Data_31.Size = new System.Drawing.Size(0, 15);
            this.Data_31.TabIndex = 17;
            // 
            // Tag_31
            // 
            this.Tag_31.AutoSize = true;
            this.Tag_31.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_31.Location = new System.Drawing.Point(93, 173);
            this.Tag_31.Name = "Tag_31";
            this.Tag_31.Size = new System.Drawing.Size(0, 15);
            this.Tag_31.TabIndex = 16;
            // 
            // Data_22
            // 
            this.Data_22.AutoSize = true;
            this.Data_22.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_22.Location = new System.Drawing.Point(382, 135);
            this.Data_22.Name = "Data_22";
            this.Data_22.Size = new System.Drawing.Size(0, 15);
            this.Data_22.TabIndex = 15;
            // 
            // Tag_22
            // 
            this.Tag_22.AutoSize = true;
            this.Tag_22.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_22.Location = new System.Drawing.Point(287, 135);
            this.Tag_22.Name = "Tag_22";
            this.Tag_22.Size = new System.Drawing.Size(0, 15);
            this.Tag_22.TabIndex = 14;
            // 
            // Data_21
            // 
            this.Data_21.AutoSize = true;
            this.Data_21.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_21.Location = new System.Drawing.Point(182, 135);
            this.Data_21.Name = "Data_21";
            this.Data_21.Size = new System.Drawing.Size(0, 15);
            this.Data_21.TabIndex = 13;
            // 
            // Tag_21
            // 
            this.Tag_21.AutoSize = true;
            this.Tag_21.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_21.Location = new System.Drawing.Point(93, 135);
            this.Tag_21.Name = "Tag_21";
            this.Tag_21.Size = new System.Drawing.Size(0, 15);
            this.Tag_21.TabIndex = 12;
            // 
            // Data_12
            // 
            this.Data_12.AutoSize = true;
            this.Data_12.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_12.Location = new System.Drawing.Point(382, 97);
            this.Data_12.Name = "Data_12";
            this.Data_12.Size = new System.Drawing.Size(0, 15);
            this.Data_12.TabIndex = 11;
            // 
            // Tag_12
            // 
            this.Tag_12.AutoSize = true;
            this.Tag_12.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_12.Location = new System.Drawing.Point(287, 97);
            this.Tag_12.Name = "Tag_12";
            this.Tag_12.Size = new System.Drawing.Size(0, 15);
            this.Tag_12.TabIndex = 10;
            // 
            // Data_11
            // 
            this.Data_11.AutoSize = true;
            this.Data_11.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_11.Location = new System.Drawing.Point(182, 97);
            this.Data_11.Name = "Data_11";
            this.Data_11.Size = new System.Drawing.Size(0, 15);
            this.Data_11.TabIndex = 9;
            // 
            // Tag_11
            // 
            this.Tag_11.AutoSize = true;
            this.Tag_11.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_11.Location = new System.Drawing.Point(93, 97);
            this.Tag_11.Name = "Tag_11";
            this.Tag_11.Size = new System.Drawing.Size(0, 15);
            this.Tag_11.TabIndex = 8;
            // 
            // Data_02
            // 
            this.Data_02.AutoSize = true;
            this.Data_02.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_02.Location = new System.Drawing.Point(382, 58);
            this.Data_02.Name = "Data_02";
            this.Data_02.Size = new System.Drawing.Size(0, 15);
            this.Data_02.TabIndex = 7;
            // 
            // Tag_02
            // 
            this.Tag_02.AutoSize = true;
            this.Tag_02.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_02.Location = new System.Drawing.Point(287, 58);
            this.Tag_02.Name = "Tag_02";
            this.Tag_02.Size = new System.Drawing.Size(0, 15);
            this.Tag_02.TabIndex = 6;
            // 
            // Data_01
            // 
            this.Data_01.AutoSize = true;
            this.Data_01.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_01.Location = new System.Drawing.Point(182, 58);
            this.Data_01.Name = "Data_01";
            this.Data_01.Size = new System.Drawing.Size(0, 15);
            this.Data_01.TabIndex = 5;
            // 
            // Tag_01
            // 
            this.Tag_01.AutoSize = true;
            this.Tag_01.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tag_01.Location = new System.Drawing.Point(93, 58);
            this.Tag_01.Name = "Tag_01";
            this.Tag_01.Size = new System.Drawing.Size(0, 15);
            this.Tag_01.TabIndex = 4;
            // 
            // Cache_Data_2
            // 
            this.Cache_Data_2.AutoSize = true;
            this.Cache_Data_2.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cache_Data_2.Location = new System.Drawing.Point(382, 18);
            this.Cache_Data_2.Name = "Cache_Data_2";
            this.Cache_Data_2.Size = new System.Drawing.Size(39, 15);
            this.Cache_Data_2.TabIndex = 3;
            this.Cache_Data_2.Text = "Data";
            // 
            // Cache_Tag_2
            // 
            this.Cache_Tag_2.AutoSize = true;
            this.Cache_Tag_2.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cache_Tag_2.Location = new System.Drawing.Point(287, 18);
            this.Cache_Tag_2.Name = "Cache_Tag_2";
            this.Cache_Tag_2.Size = new System.Drawing.Size(31, 15);
            this.Cache_Tag_2.TabIndex = 2;
            this.Cache_Tag_2.Text = "Tag";
            // 
            // Cache_Data_1
            // 
            this.Cache_Data_1.AutoSize = true;
            this.Cache_Data_1.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cache_Data_1.Location = new System.Drawing.Point(182, 18);
            this.Cache_Data_1.Name = "Cache_Data_1";
            this.Cache_Data_1.Size = new System.Drawing.Size(39, 15);
            this.Cache_Data_1.TabIndex = 1;
            this.Cache_Data_1.Text = "Data";
            // 
            // Cache_Tag_1
            // 
            this.Cache_Tag_1.AutoSize = true;
            this.Cache_Tag_1.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cache_Tag_1.Location = new System.Drawing.Point(93, 18);
            this.Cache_Tag_1.Name = "Cache_Tag_1";
            this.Cache_Tag_1.Size = new System.Drawing.Size(31, 15);
            this.Cache_Tag_1.TabIndex = 0;
            this.Cache_Tag_1.Text = "Tag";
            // 
            // ClearCacheButton
            // 
            this.ClearCacheButton.BackColor = System.Drawing.Color.White;
            this.ClearCacheButton.Font = new System.Drawing.Font("Liberation Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCacheButton.Location = new System.Drawing.Point(411, 227);
            this.ClearCacheButton.Name = "ClearCacheButton";
            this.ClearCacheButton.Size = new System.Drawing.Size(99, 36);
            this.ClearCacheButton.TabIndex = 1;
            this.ClearCacheButton.Text = "Clear Cache";
            this.ClearCacheButton.UseVisualStyleBackColor = false;
            this.ClearCacheButton.Click += new System.EventHandler(this.ClearCacheButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // CacheSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 518);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Cache_Panel);
            this.Controls.Add(this.Simulator_Panel);
            this.Controls.Add(this.Memory_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CacheSimForm";
            this.Text = "Cache Simulator";
            this.toolTip1.SetToolTip(this, "2 Digit Address between 0-63");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Memory_Panel.ResumeLayout(false);
            this.Memory_Panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Simulator_Panel.ResumeLayout(false);
            this.Simulator_Panel.PerformLayout();
            this.Cache_Panel.ResumeLayout(false);
            this.Cache.ResumeLayout(false);
            this.Cache.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Panel Memory_Panel;
        private System.Windows.Forms.ListView Mem1;
        private System.Windows.Forms.ColumnHeader Address_1;
        private System.Windows.Forms.ColumnHeader Data_1;
        private System.Windows.Forms.ListView Mem4;
        private System.Windows.Forms.ColumnHeader Address_4;
        private System.Windows.Forms.ColumnHeader Data_4;
        private System.Windows.Forms.ListView Mem3;
        private System.Windows.Forms.ColumnHeader Address_3;
        private System.Windows.Forms.ColumnHeader Data_3;
        private System.Windows.Forms.ListView Mem2;
        private System.Windows.Forms.ColumnHeader Address_2;
        private System.Windows.Forms.ColumnHeader Data_2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMemoryMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearCacheMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel Simulator_Panel;
        private System.Windows.Forms.Panel Cache_Panel;
        private System.Windows.Forms.Button ClearCacheButton;
        private System.Windows.Forms.Label HM_Tag;
        private System.Windows.Forms.Label LAC;
        private System.Windows.Forms.Label LAC_Label;
        private System.Windows.Forms.Button AddressInputButton;
        private System.Windows.Forms.Label AddressInputLabel;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label HM_Data;
        private System.Windows.Forms.Panel Cache;
        private System.Windows.Forms.Label Cache_Data_1;
        private System.Windows.Forms.Label Cache_Tag_1;
        private System.Windows.Forms.Label Tag_01;
        private System.Windows.Forms.Label Cache_Data_2;
        private System.Windows.Forms.Label Cache_Tag_2;
        private System.Windows.Forms.Label Set11;
        private System.Windows.Forms.Label Set10;
        private System.Windows.Forms.Label Set01;
        private System.Windows.Forms.Label Set00;
        private System.Windows.Forms.Label Data_32;
        private System.Windows.Forms.Label Tag_32;
        private System.Windows.Forms.Label Data_31;
        private System.Windows.Forms.Label Tag_31;
        private System.Windows.Forms.Label Data_22;
        private System.Windows.Forms.Label Tag_22;
        private System.Windows.Forms.Label Data_21;
        private System.Windows.Forms.Label Tag_21;
        private System.Windows.Forms.Label Data_12;
        private System.Windows.Forms.Label Tag_12;
        private System.Windows.Forms.Label Data_11;
        private System.Windows.Forms.Label Tag_11;
        private System.Windows.Forms.Label Data_02;
        private System.Windows.Forms.Label Tag_02;
        private System.Windows.Forms.Label Data_01;
        private System.Windows.Forms.Label HM_Slash;
        private System.Windows.Forms.Label HM_Miss;
        private System.Windows.Forms.Label HM_Hit;
        private System.Windows.Forms.Label HM_Colon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

