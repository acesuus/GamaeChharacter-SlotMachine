namespace GameCharacterWinForms
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.listBoxCharacters = new System.Windows.Forms.ListBox();
            this.battleLog = new System.Windows.Forms.ListBox();
            this.btnAddCharacter = new System.Windows.Forms.Button();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttack.Image = ((System.Drawing.Image)(resources.GetObject("btnAttack.Image")));
            this.btnAttack.Location = new System.Drawing.Point(1212, 314);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(137, 47);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Thistle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(733, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.Thistle;
            this.txtLevel.Location = new System.Drawing.Point(733, 113);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(130, 20);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // txtHealth
            // 
            this.txtHealth.BackColor = System.Drawing.Color.Thistle;
            this.txtHealth.Location = new System.Drawing.Point(733, 143);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(130, 20);
            this.txtHealth.TabIndex = 3;
            // 
            // txtMana
            // 
            this.txtMana.BackColor = System.Drawing.Color.Thistle;
            this.txtMana.Location = new System.Drawing.Point(733, 237);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(130, 20);
            this.txtMana.TabIndex = 4;
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.Color.Thistle;
            this.txtStrength.Location = new System.Drawing.Point(733, 203);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(130, 20);
            this.txtStrength.TabIndex = 5;
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.BackColor = System.Drawing.Color.Thistle;
            this.txtIntelligence.Location = new System.Drawing.Point(733, 263);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(130, 20);
            this.txtIntelligence.TabIndex = 6;
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.BackColor = System.Drawing.Color.Thistle;
            this.txtCharacterDetails.Location = new System.Drawing.Point(945, 85);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(243, 196);
            this.txtCharacterDetails.TabIndex = 8;
            this.txtCharacterDetails.Text = "Character details will appear here.";
            this.txtCharacterDetails.TextChanged += new System.EventHandler(this.txtCharacterDetails_TextChanged);
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.BackColor = System.Drawing.Color.Thistle;
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            ""});
            this.cmbCharacterType.Location = new System.Drawing.Point(733, 172);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(130, 21);
            this.cmbCharacterType.TabIndex = 9;
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterType_SelectedIndexChanged_1);
            // 
            // listBoxCharacters
            // 
            this.listBoxCharacters.BackColor = System.Drawing.Color.Thistle;
            this.listBoxCharacters.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCharacters.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBoxCharacters.FormattingEnabled = true;
            this.listBoxCharacters.ItemHeight = 22;
            this.listBoxCharacters.Location = new System.Drawing.Point(304, 276);
            this.listBoxCharacters.Name = "listBoxCharacters";
            this.listBoxCharacters.Size = new System.Drawing.Size(253, 224);
            this.listBoxCharacters.TabIndex = 10;
            this.listBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.listBoxCharacters_SelectedIndexChanged);
            // 
            // battleLog
            // 
            this.battleLog.BackColor = System.Drawing.Color.Thistle;
            this.battleLog.FormattingEnabled = true;
            this.battleLog.Location = new System.Drawing.Point(945, 314);
            this.battleLog.Name = "battleLog";
            this.battleLog.Size = new System.Drawing.Size(243, 186);
            this.battleLog.TabIndex = 11;
            this.battleLog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAddCharacter
            // 
            this.btnAddCharacter.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCharacter.BackgroundImage")));
            this.btnAddCharacter.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCharacter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCharacter.Location = new System.Drawing.Point(669, 304);
            this.btnAddCharacter.Name = "btnAddCharacter";
            this.btnAddCharacter.Size = new System.Drawing.Size(165, 38);
            this.btnAddCharacter.TabIndex = 12;
            this.btnAddCharacter.Text = "Add Character";
            this.btnAddCharacter.UseVisualStyleBackColor = false;
            this.btnAddCharacter.Click += new System.EventHandler(this.btnAddCharacter_Click_1);
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectCharacter.BackgroundImage")));
            this.btnSelectCharacter.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCharacter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSelectCharacter.Location = new System.Drawing.Point(669, 395);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(165, 38);
            this.btnSelectCharacter.TabIndex = 13;
            this.btnSelectCharacter.Text = "Select Character";
            this.btnSelectCharacter.UseVisualStyleBackColor = false;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click_1);
            // 
            // btnDefend
            // 
            this.btnDefend.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDefend.Image = ((System.Drawing.Image)(resources.GetObject("btnDefend.Image")));
            this.btnDefend.Location = new System.Drawing.Point(1212, 386);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(137, 47);
            this.btnDefend.TabIndex = 14;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click_1);
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLevelUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLevelUp.Image")));
            this.btnLevelUp.Location = new System.Drawing.Point(1212, 453);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(137, 47);
            this.btnLevelUp.TabIndex = 15;
            this.btnLevelUp.Text = "Level Up";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(630, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(630, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Level";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(630, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Health";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(630, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(630, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Strength";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(630, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(630, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Intelligence";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(617, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 40);
            this.label8.TabIndex = 23;
            this.label8.Text = "Game Character";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Thistle;
            this.label9.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(336, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "CHARACTERS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1615, 672);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.btnAddCharacter);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.listBoxCharacters);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAttack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.ListBox listBoxCharacters;
        private System.Windows.Forms.ListBox battleLog;
        private System.Windows.Forms.Button btnAddCharacter;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnLevelUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

