namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.AX = new System.Windows.Forms.Label();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.Label();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.Label();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.DX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AX_source = new System.Windows.Forms.RadioButton();
            this.BX_source = new System.Windows.Forms.RadioButton();
            this.CX_source = new System.Windows.Forms.RadioButton();
            this.DX_source = new System.Windows.Forms.RadioButton();
            this.SOURCE = new System.Windows.Forms.GroupBox();
            this.DESTINATION = new System.Windows.Forms.GroupBox();
            this.AX_destination = new System.Windows.Forms.RadioButton();
            this.DX_destination = new System.Windows.Forms.RadioButton();
            this.BX_destination = new System.Windows.Forms.RadioButton();
            this.CX_destination = new System.Windows.Forms.RadioButton();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.SOURCE.SuspendLayout();
            this.DESTINATION.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(329, 67);
            this.textBoxAX.MaxLength = 5;
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAX.TabIndex = 0;
            this.textBoxAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAX_KeyPress);
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Location = new System.Drawing.Point(288, 70);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(21, 13);
            this.AX.TabIndex = 1;
            this.AX.Text = "AX";
            this.AX.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(329, 93);
            this.textBoxBX.MaxLength = 5;
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(100, 20);
            this.textBoxBX.TabIndex = 2;
            this.textBoxBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBX_KeyPress);
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Location = new System.Drawing.Point(288, 96);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(21, 13);
            this.BX.TabIndex = 3;
            this.BX.Text = "BX";
            this.BX.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(329, 119);
            this.textBoxCX.MaxLength = 5;
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCX.TabIndex = 4;
            this.textBoxCX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCX_KeyPress);
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Location = new System.Drawing.Point(288, 122);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(21, 13);
            this.CX.TabIndex = 5;
            this.CX.Text = "CX";
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(329, 145);
            this.textBoxDX.MaxLength = 5;
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(100, 20);
            this.textBoxDX.TabIndex = 6;
            this.textBoxDX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDX_KeyPress);
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Location = new System.Drawing.Point(288, 148);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(22, 13);
            this.DX.TabIndex = 7;
            this.DX.Text = "DX";
            this.DX.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(177, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "SOURCE";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DESTINATION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AX_source
            // 
            this.AX_source.AutoSize = true;
            this.AX_source.Location = new System.Drawing.Point(6, 19);
            this.AX_source.Name = "AX_source";
            this.AX_source.Size = new System.Drawing.Size(39, 17);
            this.AX_source.TabIndex = 18;
            this.AX_source.TabStop = true;
            this.AX_source.Text = "AX";
            this.AX_source.UseVisualStyleBackColor = true;
            this.AX_source.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BX_source
            // 
            this.BX_source.AutoSize = true;
            this.BX_source.Location = new System.Drawing.Point(6, 42);
            this.BX_source.Name = "BX_source";
            this.BX_source.Size = new System.Drawing.Size(39, 17);
            this.BX_source.TabIndex = 19;
            this.BX_source.TabStop = true;
            this.BX_source.Text = "BX";
            this.BX_source.UseVisualStyleBackColor = true;
            // 
            // CX_source
            // 
            this.CX_source.AutoSize = true;
            this.CX_source.Location = new System.Drawing.Point(6, 65);
            this.CX_source.Name = "CX_source";
            this.CX_source.Size = new System.Drawing.Size(39, 17);
            this.CX_source.TabIndex = 20;
            this.CX_source.TabStop = true;
            this.CX_source.Text = "CX";
            this.CX_source.UseVisualStyleBackColor = true;
            // 
            // DX_source
            // 
            this.DX_source.AutoSize = true;
            this.DX_source.Location = new System.Drawing.Point(6, 86);
            this.DX_source.Name = "DX_source";
            this.DX_source.Size = new System.Drawing.Size(40, 17);
            this.DX_source.TabIndex = 21;
            this.DX_source.TabStop = true;
            this.DX_source.Text = "DX";
            this.DX_source.UseVisualStyleBackColor = true;
            // 
            // SOURCE
            // 
            this.SOURCE.Controls.Add(this.AX_source);
            this.SOURCE.Controls.Add(this.DX_source);
            this.SOURCE.Controls.Add(this.BX_source);
            this.SOURCE.Controls.Add(this.CX_source);
            this.SOURCE.Location = new System.Drawing.Point(103, 249);
            this.SOURCE.Name = "SOURCE";
            this.SOURCE.Size = new System.Drawing.Size(200, 109);
            this.SOURCE.TabIndex = 22;
            this.SOURCE.TabStop = false;
            this.SOURCE.Text = "SOURCE";
            // 
            // DESTINATION
            // 
            this.DESTINATION.Controls.Add(this.AX_destination);
            this.DESTINATION.Controls.Add(this.DX_destination);
            this.DESTINATION.Controls.Add(this.BX_destination);
            this.DESTINATION.Controls.Add(this.CX_destination);
            this.DESTINATION.Location = new System.Drawing.Point(417, 249);
            this.DESTINATION.Name = "DESTINATION";
            this.DESTINATION.Size = new System.Drawing.Size(200, 109);
            this.DESTINATION.TabIndex = 23;
            this.DESTINATION.TabStop = false;
            this.DESTINATION.Text = "DESTINATION";
            // 
            // AX_destination
            // 
            this.AX_destination.AutoSize = true;
            this.AX_destination.Location = new System.Drawing.Point(6, 19);
            this.AX_destination.Name = "AX_destination";
            this.AX_destination.Size = new System.Drawing.Size(39, 17);
            this.AX_destination.TabIndex = 18;
            this.AX_destination.TabStop = true;
            this.AX_destination.Text = "AX";
            this.AX_destination.UseVisualStyleBackColor = true;
            // 
            // DX_destination
            // 
            this.DX_destination.AutoSize = true;
            this.DX_destination.Location = new System.Drawing.Point(6, 86);
            this.DX_destination.Name = "DX_destination";
            this.DX_destination.Size = new System.Drawing.Size(40, 17);
            this.DX_destination.TabIndex = 21;
            this.DX_destination.TabStop = true;
            this.DX_destination.Text = "DX";
            this.DX_destination.UseVisualStyleBackColor = true;
            // 
            // BX_destination
            // 
            this.BX_destination.AutoSize = true;
            this.BX_destination.Location = new System.Drawing.Point(6, 42);
            this.BX_destination.Name = "BX_destination";
            this.BX_destination.Size = new System.Drawing.Size(39, 17);
            this.BX_destination.TabIndex = 19;
            this.BX_destination.TabStop = true;
            this.BX_destination.Text = "BX";
            this.BX_destination.UseVisualStyleBackColor = true;
            // 
            // CX_destination
            // 
            this.CX_destination.AutoSize = true;
            this.CX_destination.Location = new System.Drawing.Point(6, 65);
            this.CX_destination.Name = "CX_destination";
            this.CX_destination.Size = new System.Drawing.Size(39, 17);
            this.CX_destination.TabIndex = 20;
            this.CX_destination.TabStop = true;
            this.CX_destination.Text = "CX";
            this.CX_destination.UseVisualStyleBackColor = true;
            // 
            // SUBMIT
            // 
            this.SUBMIT.Location = new System.Drawing.Point(329, 386);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(75, 23);
            this.SUBMIT.TabIndex = 24;
            this.SUBMIT.Text = "submit";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.DESTINATION);
            this.Controls.Add(this.SOURCE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.AX);
            this.Controls.Add(this.textBoxAX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SOURCE.ResumeLayout(false);
            this.SOURCE.PerformLayout();
            this.DESTINATION.ResumeLayout(false);
            this.DESTINATION.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAX;
        private System.Windows.Forms.Label AX;
        private System.Windows.Forms.TextBox textBoxBX;
        private System.Windows.Forms.Label BX;
        private System.Windows.Forms.TextBox textBoxCX;
        private System.Windows.Forms.Label CX;
        private System.Windows.Forms.TextBox textBoxDX;
        private System.Windows.Forms.Label DX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AX_source;
        private System.Windows.Forms.RadioButton BX_source;
        private System.Windows.Forms.RadioButton CX_source;
        private System.Windows.Forms.RadioButton DX_source;
        private System.Windows.Forms.GroupBox SOURCE;
        private System.Windows.Forms.GroupBox DESTINATION;
        private System.Windows.Forms.RadioButton AX_destination;
        private System.Windows.Forms.RadioButton DX_destination;
        private System.Windows.Forms.RadioButton BX_destination;
        private System.Windows.Forms.RadioButton CX_destination;
        private System.Windows.Forms.Button SUBMIT;
    }
}

