namespace SimpleRPG
{
    partial class SimpleRPG
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
            this.Health = new System.Windows.Forms.Label();
            this.HealthValue = new System.Windows.Forms.Label();
            this.Mana = new System.Windows.Forms.Label();
            this.ManaValue = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.CharLevel = new System.Windows.Forms.Label();
            this.CharLevelValue = new System.Windows.Forms.Label();
            this.MoneyValue = new System.Windows.Forms.Label();
            this.CharStats = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Label();
            this.SelectAction = new System.Windows.Forms.Label();
            this.cboPotion = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(12, 37);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(27, 17);
            this.Health.TabIndex = 0;
            this.Health.Text = "HP";
            this.Health.Click += new System.EventHandler(this.label1_Click);
            // 
            // HealthValue
            // 
            this.HealthValue.AutoSize = true;
            this.HealthValue.Location = new System.Drawing.Point(79, 37);
            this.HealthValue.Name = "HealthValue";
            this.HealthValue.Size = new System.Drawing.Size(59, 17);
            this.HealthValue.TabIndex = 1;
            this.HealthValue.Text = "|||||||||||||||||";
            // 
            // Mana
            // 
            this.Mana.AutoSize = true;
            this.Mana.Location = new System.Drawing.Point(12, 67);
            this.Mana.Name = "Mana";
            this.Mana.Size = new System.Drawing.Size(43, 17);
            this.Mana.TabIndex = 2;
            this.Mana.Text = "Mana";
            // 
            // ManaValue
            // 
            this.ManaValue.AutoSize = true;
            this.ManaValue.Location = new System.Drawing.Point(79, 67);
            this.ManaValue.Name = "ManaValue";
            this.ManaValue.Size = new System.Drawing.Size(59, 17);
            this.ManaValue.TabIndex = 3;
            this.ManaValue.Text = "|||||||||||||||||";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Location = new System.Drawing.Point(12, 98);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(50, 17);
            this.Money.TabIndex = 4;
            this.Money.Text = "Money";
            // 
            // CharLevel
            // 
            this.CharLevel.AutoSize = true;
            this.CharLevel.Location = new System.Drawing.Point(12, 7);
            this.CharLevel.Name = "CharLevel";
            this.CharLevel.Size = new System.Drawing.Size(33, 17);
            this.CharLevel.TabIndex = 5;
            this.CharLevel.Text = "LVL";
            // 
            // CharLevelValue
            // 
            this.CharLevelValue.AutoSize = true;
            this.CharLevelValue.Location = new System.Drawing.Point(79, 7);
            this.CharLevelValue.Name = "CharLevelValue";
            this.CharLevelValue.Size = new System.Drawing.Size(32, 17);
            this.CharLevelValue.TabIndex = 6;
            this.CharLevelValue.Text = "Yes";
            // 
            // MoneyValue
            // 
            this.MoneyValue.AutoSize = true;
            this.MoneyValue.Location = new System.Drawing.Point(79, 98);
            this.MoneyValue.Name = "MoneyValue";
            this.MoneyValue.Size = new System.Drawing.Size(16, 17);
            this.MoneyValue.TabIndex = 7;
            this.MoneyValue.Text = "0";
            // 
            // CharStats
            // 
            this.CharStats.Location = new System.Drawing.Point(181, 9);
            this.CharStats.Name = "CharStats";
            this.CharStats.Size = new System.Drawing.Size(75, 23);
            this.CharStats.TabIndex = 8;
            this.CharStats.Text = "Stats";
            this.CharStats.UseVisualStyleBackColor = true;
            this.CharStats.Click += new System.EventHandler(this.CharStats_Click);
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(708, 9);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(62, 17);
            this.Location.TabIndex = 9;
            this.Location.Text = "Location";
            // 
            // SelectAction
            // 
            this.SelectAction.AutoSize = true;
            this.SelectAction.Location = new System.Drawing.Point(617, 531);
            this.SelectAction.Name = "SelectAction";
            this.SelectAction.Size = new System.Drawing.Size(90, 17);
            this.SelectAction.TabIndex = 10;
            this.SelectAction.Text = "Select Action";
            // 
            // cboPotion
            // 
            this.cboPotion.FormattingEnabled = true;
            this.cboPotion.Location = new System.Drawing.Point(369, 593);
            this.cboPotion.Name = "cboPotion";
            this.cboPotion.Size = new System.Drawing.Size(121, 24);
            this.cboPotion.TabIndex = 11;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 559);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 24);
            this.cboWeapons.TabIndex = 12;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 13;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 14;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 15;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 16;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 17;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 18;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(347, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(100, 96);
            this.rtbMessages.TabIndex = 19;
            this.rtbMessages.Text = "";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(100, 96);
            this.rtbLocation.TabIndex = 20;
            this.rtbLocation.Text = "";
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(240, 150);
            this.dgvQuests.TabIndex = 21;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(240, 150);
            this.dgvInventory.TabIndex = 22;
            // 
            // SimpleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 655);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.cboPotion);
            this.Controls.Add(this.SelectAction);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.CharStats);
            this.Controls.Add(this.MoneyValue);
            this.Controls.Add(this.CharLevelValue);
            this.Controls.Add(this.CharLevel);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.ManaValue);
            this.Controls.Add(this.Mana);
            this.Controls.Add(this.HealthValue);
            this.Controls.Add(this.Health);
            this.Name = "SimpleRPG";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.SimpleRPG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label HealthValue;
        private System.Windows.Forms.Label Mana;
        private System.Windows.Forms.Label ManaValue;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label CharLevel;
        private System.Windows.Forms.Label CharLevelValue;
        private System.Windows.Forms.Label MoneyValue;
        private System.Windows.Forms.Button CharStats;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label SelectAction;
        private System.Windows.Forms.ComboBox cboPotion;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}

