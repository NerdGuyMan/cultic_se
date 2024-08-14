
namespace Cultic_SE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerHP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.weapon = new System.Windows.Forms.NumericUpDown();
            this.offhandWeapon = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.playerImbues = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.weaponParts = new System.Windows.Forms.NumericUpDown();
            this.gameDiff = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.playerEquip = new System.Windows.Forms.NumericUpDown();
            this.saveFileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.playerAmmo = new System.Windows.Forms.ListBox();
            this.playerMaxAmmo = new System.Windows.Forms.ListBox();
            this.unlockUpgrades = new System.Windows.Forms.CheckBox();
            this.maxAmmo = new System.Windows.Forms.CheckBox();
            this.isCustom = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.playerHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offhandWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImbues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerEquip)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerHP
            // 
            this.playerHP.Location = new System.Drawing.Point(94, 53);
            this.playerHP.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.playerHP.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(189, 20);
            this.playerHP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Health:";
            // 
            // weapon
            // 
            this.weapon.Location = new System.Drawing.Point(652, 154);
            this.weapon.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.weapon.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(45, 20);
            this.weapon.TabIndex = 3;
            this.weapon.Visible = false;
            // 
            // offhandWeapon
            // 
            this.offhandWeapon.Location = new System.Drawing.Point(652, 180);
            this.offhandWeapon.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.offhandWeapon.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.offhandWeapon.Name = "offhandWeapon";
            this.offhandWeapon.Size = new System.Drawing.Size(45, 20);
            this.offhandWeapon.TabIndex = 5;
            this.offhandWeapon.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HP Imbues:";
            // 
            // playerImbues
            // 
            this.playerImbues.Location = new System.Drawing.Point(94, 80);
            this.playerImbues.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.playerImbues.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.playerImbues.Name = "playerImbues";
            this.playerImbues.Size = new System.Drawing.Size(189, 20);
            this.playerImbues.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Weapon Parts:";
            // 
            // weaponParts
            // 
            this.weaponParts.Location = new System.Drawing.Point(94, 106);
            this.weaponParts.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.weaponParts.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.weaponParts.Name = "weaponParts";
            this.weaponParts.Size = new System.Drawing.Size(189, 20);
            this.weaponParts.TabIndex = 9;
            // 
            // gameDiff
            // 
            this.gameDiff.FormattingEnabled = true;
            this.gameDiff.Items.AddRange(new object[] {
            "Casual",
            "Standard",
            "Hard",
            "Very Hard",
            "Extreme"});
            this.gameDiff.Location = new System.Drawing.Point(94, 130);
            this.gameDiff.Name = "gameDiff";
            this.gameDiff.Size = new System.Drawing.Size(189, 21);
            this.gameDiff.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Difficulty:";
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "SAV files|*.sav";
            this.fileDialog.Title = "Load Cultic Save:";
            // 
            // playerEquip
            // 
            this.playerEquip.Location = new System.Drawing.Point(652, 206);
            this.playerEquip.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.playerEquip.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.playerEquip.Name = "playerEquip";
            this.playerEquip.Size = new System.Drawing.Size(45, 20);
            this.playerEquip.TabIndex = 13;
            this.playerEquip.Visible = false;
            // 
            // saveFileName
            // 
            this.saveFileName.Location = new System.Drawing.Point(94, 27);
            this.saveFileName.Name = "saveFileName";
            this.saveFileName.Size = new System.Drawing.Size(331, 20);
            this.saveFileName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Save Name:";
            // 
            // playerAmmo
            // 
            this.playerAmmo.FormattingEnabled = true;
            this.playerAmmo.Location = new System.Drawing.Point(289, 56);
            this.playerAmmo.Name = "playerAmmo";
            this.playerAmmo.Size = new System.Drawing.Size(65, 121);
            this.playerAmmo.TabIndex = 17;
            // 
            // playerMaxAmmo
            // 
            this.playerMaxAmmo.FormattingEnabled = true;
            this.playerMaxAmmo.Location = new System.Drawing.Point(360, 56);
            this.playerMaxAmmo.Name = "playerMaxAmmo";
            this.playerMaxAmmo.Size = new System.Drawing.Size(65, 121);
            this.playerMaxAmmo.TabIndex = 19;
            // 
            // unlockUpgrades
            // 
            this.unlockUpgrades.AutoSize = true;
            this.unlockUpgrades.Location = new System.Drawing.Point(94, 157);
            this.unlockUpgrades.Name = "unlockUpgrades";
            this.unlockUpgrades.Size = new System.Drawing.Size(123, 17);
            this.unlockUpgrades.TabIndex = 21;
            this.unlockUpgrades.Text = "Unlock All Upgrades";
            this.unlockUpgrades.UseVisualStyleBackColor = true;
            // 
            // maxAmmo
            // 
            this.maxAmmo.AutoSize = true;
            this.maxAmmo.Location = new System.Drawing.Point(205, 180);
            this.maxAmmo.Name = "maxAmmo";
            this.maxAmmo.Size = new System.Drawing.Size(78, 17);
            this.maxAmmo.TabIndex = 22;
            this.maxAmmo.Text = "Max Ammo";
            this.maxAmmo.UseVisualStyleBackColor = true;
            // 
            // isCustom
            // 
            this.isCustom.AutoSize = true;
            this.isCustom.Location = new System.Drawing.Point(94, 180);
            this.isCustom.Name = "isCustom";
            this.isCustom.Size = new System.Drawing.Size(92, 17);
            this.isCustom.TabIndex = 23;
            this.isCustom.Text = "Custom Game";
            this.isCustom.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.saveButton,
            this.aboutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadButton
            // 
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(45, 20);
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(43, 20);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 207);
            this.Controls.Add(this.playerMaxAmmo);
            this.Controls.Add(this.playerAmmo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveFileName);
            this.Controls.Add(this.playerEquip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameDiff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weaponParts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerImbues);
            this.Controls.Add(this.offhandWeapon);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerHP);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.isCustom);
            this.Controls.Add(this.maxAmmo);
            this.Controls.Add(this.unlockUpgrades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultic Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.playerHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offhandWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImbues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerEquip)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown playerHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown weapon;
        private System.Windows.Forms.NumericUpDown offhandWeapon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown playerImbues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown weaponParts;
        private System.Windows.Forms.ComboBox gameDiff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.NumericUpDown playerEquip;
        private System.Windows.Forms.TextBox saveFileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox playerAmmo;
        private System.Windows.Forms.ListBox playerMaxAmmo;
        private System.Windows.Forms.CheckBox unlockUpgrades;
        private System.Windows.Forms.CheckBox maxAmmo;
        private System.Windows.Forms.CheckBox isCustom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
    }
}

