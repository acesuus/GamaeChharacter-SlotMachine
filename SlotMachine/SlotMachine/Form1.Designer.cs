namespace SlotMachine
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblResult = new Label();
            lblBalance = new Label();
            btnSpin = new Button();
            txtStake = new TextBox();
            timerSpin = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnRestart = new Button();
            comboBoxThemes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(76, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(518, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 160);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(299, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 160);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = SystemColors.ActiveCaption;
            lblResult.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(108, 85);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(74, 38);
            lblResult.TabIndex = 3;
            lblResult.Text = "LOG";
            lblResult.Click += lblResult_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.BackColor = SystemColors.ActiveCaption;
            lblBalance.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(94, 28);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(104, 29);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "label2";
            lblBalance.Click += lblBalance_Click;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = SystemColors.ActiveCaption;
            btnSpin.Location = new Point(321, 379);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(127, 59);
            btnSpin.TabIndex = 5;
            btnSpin.Text = "SPIN";
            btnSpin.UseVisualStyleBackColor = false;
            btnSpin.Click += btnSpin_Click;
            // 
            // txtStake
            // 
            txtStake.BackColor = Color.LightSteelBlue;
            txtStake.Location = new Point(321, 350);
            txtStake.Name = "txtStake";
            txtStake.Size = new Size(127, 23);
            txtStake.TabIndex = 6;
            // 
            // timerSpin
            // 
            timerSpin.Tick += timerSpin_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(361, 315);
            label1.Name = "label1";
            label1.Size = new Size(55, 27);
            label1.TabIndex = 7;
            label1.Text = "Bet";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.ActiveCaption;
            btnRestart.Location = new Point(76, 356);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(149, 65);
            btnRestart.TabIndex = 8;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // comboBoxThemes
            // 
            comboBoxThemes.BackColor = SystemColors.InactiveBorder;
            comboBoxThemes.FormattingEnabled = true;
            comboBoxThemes.Location = new Point(550, 379);
            comboBoxThemes.Name = "comboBoxThemes";
            comboBoxThemes.Size = new Size(92, 23);
            comboBoxThemes.TabIndex = 9;
            comboBoxThemes.SelectedIndexChanged += comboBoxThemes_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxThemes);
            Controls.Add(btnRestart);
            Controls.Add(label1);
            Controls.Add(txtStake);
            Controls.Add(btnSpin);
            Controls.Add(lblBalance);
            Controls.Add(lblResult);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblResult;
        private Label lblBalance;
        private Button btnSpin;
        private TextBox txtStake;
        private System.Windows.Forms.Timer timerSpin;
        private Label label1;
        private Button btnRestart;
        private ComboBox comboBoxThemes;
    }
}
