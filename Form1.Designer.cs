namespace Kwerendy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLoad = new Button();
            grid1 = new DataGridView();
            btnRegistrations = new Button();
            butGenerate = new Button();
            btnSignature = new Button();
            menuStrip1 = new MenuStrip();
            ustawieniaToolStripMenuItem = new ToolStripMenuItem();
            daneArchiwumToolStripMenuItem = new ToolStripMenuItem();
            daneUżytkownikaToolStripMenuItem = new ToolStripMenuItem();
            statusLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)grid1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.FlatAppearance.BorderColor = Color.White;
            btnLoad.Font = new Font("Segoe UI", 20F);
            btnLoad.Location = new Point(12, 41);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(225, 63);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wybierz plik";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // grid1
            // 
            grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid1.Location = new Point(505, 41);
            grid1.Margin = new Padding(3, 4, 3, 4);
            grid1.Name = "grid1";
            grid1.RowHeadersWidth = 51;
            grid1.Size = new Size(919, 709);
            grid1.TabIndex = 2;
            // 
            // btnRegistrations
            // 
            btnRegistrations.Font = new Font("Segoe UI", 15F);
            btnRegistrations.Location = new Point(12, 161);
            btnRegistrations.Margin = new Padding(3, 4, 3, 4);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(225, 63);
            btnRegistrations.TabIndex = 3;
            btnRegistrations.Text = "Tylko rejestracje";
            btnRegistrations.UseVisualStyleBackColor = true;
            btnRegistrations.Click += btnRegistrations_Click;
            // 
            // butGenerate
            // 
            butGenerate.Font = new Font("Segoe UI", 15F);
            butGenerate.Location = new Point(12, 303);
            butGenerate.Margin = new Padding(3, 4, 3, 4);
            butGenerate.Name = "butGenerate";
            butGenerate.Size = new Size(225, 63);
            butGenerate.TabIndex = 4;
            butGenerate.Text = "Generuj";
            butGenerate.UseVisualStyleBackColor = true;
            butGenerate.Click += butGenerate_Click;
            // 
            // btnSignature
            // 
            btnSignature.Font = new Font("Segoe UI", 15F);
            btnSignature.Location = new Point(12, 232);
            btnSignature.Margin = new Padding(3, 4, 3, 4);
            btnSignature.Name = "btnSignature";
            btnSignature.Size = new Size(225, 63);
            btnSignature.TabIndex = 5;
            btnSignature.Text = "Podpis";
            btnSignature.UseVisualStyleBackColor = true;
            btnSignature.Click += btnSignature_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ustawieniaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1504, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // ustawieniaToolStripMenuItem
            // 
            ustawieniaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daneArchiwumToolStripMenuItem, daneUżytkownikaToolStripMenuItem });
            ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            ustawieniaToolStripMenuItem.Size = new Size(95, 24);
            ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // daneArchiwumToolStripMenuItem
            // 
            daneArchiwumToolStripMenuItem.Name = "daneArchiwumToolStripMenuItem";
            daneArchiwumToolStripMenuItem.Size = new Size(212, 26);
            daneArchiwumToolStripMenuItem.Text = "Dane archiwum";
            daneArchiwumToolStripMenuItem.Click += daneArchiwumToolStripMenuItem_Click;
            // 
            // daneUżytkownikaToolStripMenuItem
            // 
            daneUżytkownikaToolStripMenuItem.Name = "daneUżytkownikaToolStripMenuItem";
            daneUżytkownikaToolStripMenuItem.Size = new Size(212, 26);
            daneUżytkownikaToolStripMenuItem.Text = "Dane użytkownika";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F);
            statusLabel.Location = new Point(12, 108);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(206, 28);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Kliknij aby wybrać plik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1504, 865);
            Controls.Add(statusLabel);
            Controls.Add(btnSignature);
            Controls.Add(butGenerate);
            Controls.Add(btnRegistrations);
            Controls.Add(grid1);
            Controls.Add(btnLoad);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grid1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private DataGridView grid1;
        private Button btnRegistrations;
        private Button butGenerate;
        private Button btnSignature;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ustawieniaToolStripMenuItem;
        private ToolStripMenuItem daneArchiwumToolStripMenuItem;
        private ToolStripMenuItem daneUżytkownikaToolStripMenuItem;
        private Label statusLabel;
    }
}
