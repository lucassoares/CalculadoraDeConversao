namespace Calc_Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroBox = new System.Windows.Forms.TextBox();
            this.converterParaBinario = new System.Windows.Forms.Button();
            this.converterParaHexa = new System.Windows.Forms.Button();
            this.radioBinario = new System.Windows.Forms.RadioButton();
            this.radioHexadecimal = new System.Windows.Forms.RadioButton();
            this.radioDecimal = new System.Windows.Forms.RadioButton();
            this.converterParaDeci = new System.Windows.Forms.Button();
            this.caixaResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(199, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Numérico";
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(245, 205);
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(396, 20);
            this.numeroBox.TabIndex = 1;
            // 
            // converterParaBinario
            // 
            this.converterParaBinario.FlatAppearance.BorderSize = 0;
            this.converterParaBinario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.converterParaBinario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaBinario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaBinario.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterParaBinario.Location = new System.Drawing.Point(30, 215);
            this.converterParaBinario.Name = "converterParaBinario";
            this.converterParaBinario.Size = new System.Drawing.Size(186, 23);
            this.converterParaBinario.TabIndex = 2;
            this.converterParaBinario.Text = "Converter para binário";
            this.converterParaBinario.UseVisualStyleBackColor = true;
            this.converterParaBinario.Click += new System.EventHandler(this.button1_Click);
            // 
            // converterParaHexa
            // 
            this.converterParaHexa.FlatAppearance.BorderSize = 0;
            this.converterParaHexa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.converterParaHexa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaHexa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaHexa.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterParaHexa.Location = new System.Drawing.Point(28, 291);
            this.converterParaHexa.Name = "converterParaHexa";
            this.converterParaHexa.Size = new System.Drawing.Size(188, 23);
            this.converterParaHexa.TabIndex = 3;
            this.converterParaHexa.Text = "Converter para hexadecimal";
            this.converterParaHexa.UseVisualStyleBackColor = true;
            this.converterParaHexa.Click += new System.EventHandler(this.hexaButton_Click);
            // 
            // radioBinario
            // 
            this.radioBinario.AutoSize = true;
            this.radioBinario.BackColor = System.Drawing.Color.Transparent;
            this.radioBinario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioBinario.Location = new System.Drawing.Point(118, 149);
            this.radioBinario.Name = "radioBinario";
            this.radioBinario.Size = new System.Drawing.Size(74, 19);
            this.radioBinario.TabIndex = 5;
            this.radioBinario.TabStop = true;
            this.radioBinario.Text = "Binário";
            this.radioBinario.UseVisualStyleBackColor = false;
            this.radioBinario.CheckedChanged += new System.EventHandler(this.radioBinario_CheckedChanged);
            // 
            // radioHexadecimal
            // 
            this.radioHexadecimal.AutoSize = true;
            this.radioHexadecimal.BackColor = System.Drawing.Color.Transparent;
            this.radioHexadecimal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHexadecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioHexadecimal.Location = new System.Drawing.Point(211, 149);
            this.radioHexadecimal.Name = "radioHexadecimal";
            this.radioHexadecimal.Size = new System.Drawing.Size(102, 19);
            this.radioHexadecimal.TabIndex = 6;
            this.radioHexadecimal.TabStop = true;
            this.radioHexadecimal.Text = "Hexadecimal";
            this.radioHexadecimal.UseVisualStyleBackColor = false;
            this.radioHexadecimal.CheckedChanged += new System.EventHandler(this.radioHexadecimal_CheckedChanged);
            // 
            // radioDecimal
            // 
            this.radioDecimal.AutoSize = true;
            this.radioDecimal.BackColor = System.Drawing.Color.Transparent;
            this.radioDecimal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioDecimal.Location = new System.Drawing.Point(347, 149);
            this.radioDecimal.Name = "radioDecimal";
            this.radioDecimal.Size = new System.Drawing.Size(74, 19);
            this.radioDecimal.TabIndex = 7;
            this.radioDecimal.TabStop = true;
            this.radioDecimal.Text = "Decimal";
            this.radioDecimal.UseVisualStyleBackColor = false;
            this.radioDecimal.CheckedChanged += new System.EventHandler(this.radioDecimal_CheckedChanged);
            // 
            // converterParaDeci
            // 
            this.converterParaDeci.FlatAppearance.BorderSize = 0;
            this.converterParaDeci.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.converterParaDeci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaDeci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.converterParaDeci.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterParaDeci.Location = new System.Drawing.Point(28, 252);
            this.converterParaDeci.Name = "converterParaDeci";
            this.converterParaDeci.Size = new System.Drawing.Size(186, 23);
            this.converterParaDeci.TabIndex = 8;
            this.converterParaDeci.Text = "Converter para decimal";
            this.converterParaDeci.UseVisualStyleBackColor = true;
            this.converterParaDeci.Click += new System.EventHandler(this.button2_Click);
            // 
            // caixaResultado
            // 
            this.caixaResultado.Location = new System.Drawing.Point(245, 352);
            this.caixaResultado.Name = "caixaResultado";
            this.caixaResultado.Size = new System.Drawing.Size(396, 20);
            this.caixaResultado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione o tipo de número digitado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nexa Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lucas Soares";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Criptografia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textButton
            // 
            this.textButton.AutoSize = true;
            this.textButton.BackColor = System.Drawing.Color.Transparent;
            this.textButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textButton.Location = new System.Drawing.Point(28, 149);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(60, 19);
            this.textButton.TabIndex = 14;
            this.textButton.TabStop = true;
            this.textButton.Text = "Texto";
            this.textButton.UseVisualStyleBackColor = false;
            this.textButton.CheckedChanged += new System.EventHandler(this.textButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 393);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caixaResultado);
            this.Controls.Add(this.converterParaDeci);
            this.Controls.Add(this.radioDecimal);
            this.Controls.Add(this.radioHexadecimal);
            this.Controls.Add(this.radioBinario);
            this.Controls.Add(this.converterParaHexa);
            this.Controls.Add(this.converterParaBinario);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora para conversões";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroBox;
        private System.Windows.Forms.Button converterParaBinario;
        private System.Windows.Forms.Button converterParaHexa;
        private System.Windows.Forms.RadioButton radioBinario;
        private System.Windows.Forms.RadioButton radioHexadecimal;
        private System.Windows.Forms.RadioButton radioDecimal;
        private System.Windows.Forms.Button converterParaDeci;
        private System.Windows.Forms.TextBox caixaResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton textButton;
    }
}

