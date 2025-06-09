namespace RusoFr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelEntree = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManuel = new System.Windows.Forms.Button();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.panelEntree.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntree
            // 
            this.panelEntree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEntree.BackgroundImage")));
            this.panelEntree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEntree.Controls.Add(this.label1);
            this.panelEntree.Controls.Add(this.btnExit);
            this.panelEntree.Controls.Add(this.btnManuel);
            this.panelEntree.Controls.Add(this.btnCommencer);
            this.panelEntree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEntree.ForeColor = System.Drawing.Color.Transparent;
            this.panelEntree.Location = new System.Drawing.Point(0, 0);
            this.panelEntree.Name = "panelEntree";
            this.panelEntree.Size = new System.Drawing.Size(499, 366);
            this.panelEntree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 72);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ради вас видеть!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnExit.Location = new System.Drawing.Point(129, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(251, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnManuel
            // 
            this.btnManuel.BackColor = System.Drawing.Color.Transparent;
            this.btnManuel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnManuel.FlatAppearance.BorderSize = 3;
            this.btnManuel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManuel.Font = new System.Drawing.Font("Monotype Corsiva", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManuel.ForeColor = System.Drawing.Color.Firebrick;
            this.btnManuel.Location = new System.Drawing.Point(129, 187);
            this.btnManuel.Name = "btnManuel";
            this.btnManuel.Size = new System.Drawing.Size(251, 61);
            this.btnManuel.TabIndex = 5;
            this.btnManuel.Text = "Руководство по программе";
            this.btnManuel.UseVisualStyleBackColor = false;
            this.btnManuel.Click += new System.EventHandler(this.btnManuel_Click);
            this.btnManuel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnManuel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnCommencer
            // 
            this.btnCommencer.BackColor = System.Drawing.Color.Transparent;
            this.btnCommencer.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCommencer.FlatAppearance.BorderSize = 3;
            this.btnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCommencer.Font = new System.Drawing.Font("Monotype Corsiva", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCommencer.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCommencer.Location = new System.Drawing.Point(129, 99);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(251, 61);
            this.btnCommencer.TabIndex = 4;
            this.btnCommencer.Text = "Начинать";
            this.btnCommencer.UseVisualStyleBackColor = false;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            this.btnCommencer.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnCommencer.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 366);
            this.Controls.Add(this.panelEntree);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Русско-французский разговорник";
            this.panelEntree.ResumeLayout(false);
            this.panelEntree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManuel;
        private System.Windows.Forms.Button btnCommencer;
    }
}

