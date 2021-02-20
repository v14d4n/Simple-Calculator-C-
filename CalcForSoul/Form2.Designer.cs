namespace CalcForSoul
{
    partial class Form2
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
            this.KubButton = new System.Windows.Forms.Button();
            this.ParalButton = new System.Windows.Forms.Button();
            this.PParalButton = new System.Windows.Forms.Button();
            this.PrismButton = new System.Windows.Forms.Button();
            this.PiramidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KubButton
            // 
            this.KubButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.KubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KubButton.Location = new System.Drawing.Point(12, 12);
            this.KubButton.Name = "KubButton";
            this.KubButton.Size = new System.Drawing.Size(238, 55);
            this.KubButton.TabIndex = 3;
            this.KubButton.Text = "Куб";
            this.KubButton.UseMnemonic = false;
            this.KubButton.UseVisualStyleBackColor = false;
            this.KubButton.Click += new System.EventHandler(this.KubButton_Click);
            // 
            // ParalButton
            // 
            this.ParalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParalButton.Location = new System.Drawing.Point(12, 73);
            this.ParalButton.Name = "ParalButton";
            this.ParalButton.Size = new System.Drawing.Size(238, 55);
            this.ParalButton.TabIndex = 4;
            this.ParalButton.Text = "Параллелепипед";
            this.ParalButton.UseMnemonic = false;
            this.ParalButton.UseVisualStyleBackColor = false;
            this.ParalButton.Click += new System.EventHandler(this.ParalButton_Click);
            // 
            // PParalButton
            // 
            this.PParalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PParalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PParalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PParalButton.Location = new System.Drawing.Point(12, 134);
            this.PParalButton.Name = "PParalButton";
            this.PParalButton.Size = new System.Drawing.Size(238, 55);
            this.PParalButton.TabIndex = 5;
            this.PParalButton.Text = "П.Параллелепипед";
            this.PParalButton.UseMnemonic = false;
            this.PParalButton.UseVisualStyleBackColor = false;
            this.PParalButton.Click += new System.EventHandler(this.PParalButton_Click);
            // 
            // PrismButton
            // 
            this.PrismButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrismButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrismButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrismButton.Location = new System.Drawing.Point(12, 195);
            this.PrismButton.Name = "PrismButton";
            this.PrismButton.Size = new System.Drawing.Size(238, 55);
            this.PrismButton.TabIndex = 6;
            this.PrismButton.Text = "Призма";
            this.PrismButton.UseMnemonic = false;
            this.PrismButton.UseVisualStyleBackColor = false;
            this.PrismButton.Click += new System.EventHandler(this.PrismButton_Click);
            // 
            // PiramidButton
            // 
            this.PiramidButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PiramidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PiramidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PiramidButton.Location = new System.Drawing.Point(12, 256);
            this.PiramidButton.Name = "PiramidButton";
            this.PiramidButton.Size = new System.Drawing.Size(238, 55);
            this.PiramidButton.TabIndex = 7;
            this.PiramidButton.Text = "Пирамида";
            this.PiramidButton.UseMnemonic = false;
            this.PiramidButton.UseVisualStyleBackColor = false;
            this.PiramidButton.Click += new System.EventHandler(this.PiramidButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 324);
            this.Controls.Add(this.PiramidButton);
            this.Controls.Add(this.PrismButton);
            this.Controls.Add(this.PParalButton);
            this.Controls.Add(this.ParalButton);
            this.Controls.Add(this.KubButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Формулы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KubButton;
        private System.Windows.Forms.Button ParalButton;
        private System.Windows.Forms.Button PParalButton;
        private System.Windows.Forms.Button PrismButton;
        private System.Windows.Forms.Button PiramidButton;
    }
}