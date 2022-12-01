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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAX = new System.Windows.Forms.TextBox();
            this.AX = new System.Windows.Forms.Label();
            this.textBoxBX = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.Label();
            this.textBoxCX = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.Label();
            this.textBoxDX = new System.Windows.Forms.TextBox();
            this.DX = new System.Windows.Forms.Label();
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
            this.reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AXmove = new System.Windows.Forms.RadioButton();
            this.DXmove = new System.Windows.Forms.RadioButton();
            this.CXmove = new System.Windows.Forms.RadioButton();
            this.BXmove = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AXmove1 = new System.Windows.Forms.RadioButton();
            this.DXmove1 = new System.Windows.Forms.RadioButton();
            this.BXmove1 = new System.Windows.Forms.RadioButton();
            this.CXmove1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SOURCE.SuspendLayout();
            this.DESTINATION.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAX
            // 
            this.textBoxAX.Location = new System.Drawing.Point(103, 127);
            this.textBoxAX.MaxLength = 5;
            this.textBoxAX.Name = "textBoxAX";
            this.textBoxAX.Size = new System.Drawing.Size(128, 20);
            this.textBoxAX.TabIndex = 0;
            this.textBoxAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAX_KeyPress);
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AX.Location = new System.Drawing.Point(53, 125);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(31, 20);
            this.AX.TabIndex = 1;
            this.AX.Text = "AX";
            this.AX.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBX
            // 
            this.textBoxBX.Location = new System.Drawing.Point(103, 153);
            this.textBoxBX.MaxLength = 5;
            this.textBoxBX.Name = "textBoxBX";
            this.textBoxBX.Size = new System.Drawing.Size(128, 20);
            this.textBoxBX.TabIndex = 2;
            this.textBoxBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBX_KeyPress);
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BX.Location = new System.Drawing.Point(53, 151);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(31, 20);
            this.BX.TabIndex = 3;
            this.BX.Text = "BX";
            this.BX.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxCX
            // 
            this.textBoxCX.Location = new System.Drawing.Point(103, 179);
            this.textBoxCX.MaxLength = 5;
            this.textBoxCX.Name = "textBoxCX";
            this.textBoxCX.Size = new System.Drawing.Size(128, 20);
            this.textBoxCX.TabIndex = 4;
            this.textBoxCX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCX_KeyPress);
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CX.Location = new System.Drawing.Point(53, 177);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(31, 20);
            this.CX.TabIndex = 5;
            this.CX.Text = "CX";
            // 
            // textBoxDX
            // 
            this.textBoxDX.Location = new System.Drawing.Point(103, 205);
            this.textBoxDX.MaxLength = 5;
            this.textBoxDX.Name = "textBoxDX";
            this.textBoxDX.Size = new System.Drawing.Size(128, 20);
            this.textBoxDX.TabIndex = 6;
            this.textBoxDX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDX_KeyPress);
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DX.Location = new System.Drawing.Point(53, 203);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(32, 20);
            this.DX.TabIndex = 7;
            this.DX.Text = "DX";
            this.DX.Click += new System.EventHandler(this.label1_Click_2);
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
            this.SOURCE.Location = new System.Drawing.Point(288, 86);
            this.SOURCE.Name = "SOURCE";
            this.SOURCE.Size = new System.Drawing.Size(173, 109);
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
            this.DESTINATION.Location = new System.Drawing.Point(593, 86);
            this.DESTINATION.Name = "DESTINATION";
            this.DESTINATION.Size = new System.Drawing.Size(173, 109);
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
            this.SUBMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SUBMIT.Location = new System.Drawing.Point(467, 130);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(120, 38);
            this.SUBMIT.TabIndex = 24;
            this.SUBMIT.Text = "EXCHANGE";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(57, 249);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(174, 23);
            this.reset.TabIndex = 25;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AXmove);
            this.groupBox1.Controls.Add(this.DXmove);
            this.groupBox1.Controls.Add(this.CXmove);
            this.groupBox1.Controls.Add(this.BXmove);
            this.groupBox1.Location = new System.Drawing.Point(288, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 109);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SOURCE";
            // 
            // AXmove
            // 
            this.AXmove.AutoSize = true;
            this.AXmove.Location = new System.Drawing.Point(7, 19);
            this.AXmove.Name = "AXmove";
            this.AXmove.Size = new System.Drawing.Size(39, 17);
            this.AXmove.TabIndex = 31;
            this.AXmove.TabStop = true;
            this.AXmove.Text = "AX";
            this.AXmove.UseVisualStyleBackColor = true;
            // 
            // DXmove
            // 
            this.DXmove.AutoSize = true;
            this.DXmove.Location = new System.Drawing.Point(7, 86);
            this.DXmove.Name = "DXmove";
            this.DXmove.Size = new System.Drawing.Size(40, 17);
            this.DXmove.TabIndex = 34;
            this.DXmove.TabStop = true;
            this.DXmove.Text = "DX";
            this.DXmove.UseVisualStyleBackColor = true;
            // 
            // CXmove
            // 
            this.CXmove.AutoSize = true;
            this.CXmove.Location = new System.Drawing.Point(7, 65);
            this.CXmove.Name = "CXmove";
            this.CXmove.Size = new System.Drawing.Size(39, 17);
            this.CXmove.TabIndex = 33;
            this.CXmove.TabStop = true;
            this.CXmove.Text = "CX";
            this.CXmove.UseVisualStyleBackColor = true;
            // 
            // BXmove
            // 
            this.BXmove.AutoSize = true;
            this.BXmove.Location = new System.Drawing.Point(7, 42);
            this.BXmove.Name = "BXmove";
            this.BXmove.Size = new System.Drawing.Size(39, 17);
            this.BXmove.TabIndex = 32;
            this.BXmove.TabStop = true;
            this.BXmove.Text = "BX";
            this.BXmove.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AXmove1);
            this.groupBox2.Controls.Add(this.DXmove1);
            this.groupBox2.Controls.Add(this.BXmove1);
            this.groupBox2.Controls.Add(this.CXmove1);
            this.groupBox2.Location = new System.Drawing.Point(593, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 109);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESTINATION";
            // 
            // AXmove1
            // 
            this.AXmove1.AutoSize = true;
            this.AXmove1.Location = new System.Drawing.Point(7, 19);
            this.AXmove1.Name = "AXmove1";
            this.AXmove1.Size = new System.Drawing.Size(39, 17);
            this.AXmove1.TabIndex = 22;
            this.AXmove1.TabStop = true;
            this.AXmove1.Text = "AX";
            this.AXmove1.UseVisualStyleBackColor = true;
            // 
            // DXmove1
            // 
            this.DXmove1.AutoSize = true;
            this.DXmove1.Location = new System.Drawing.Point(7, 86);
            this.DXmove1.Name = "DXmove1";
            this.DXmove1.Size = new System.Drawing.Size(40, 17);
            this.DXmove1.TabIndex = 25;
            this.DXmove1.TabStop = true;
            this.DXmove1.Text = "DX";
            this.DXmove1.UseVisualStyleBackColor = true;
            // 
            // BXmove1
            // 
            this.BXmove1.AutoSize = true;
            this.BXmove1.Location = new System.Drawing.Point(7, 42);
            this.BXmove1.Name = "BXmove1";
            this.BXmove1.Size = new System.Drawing.Size(39, 17);
            this.BXmove1.TabIndex = 23;
            this.BXmove1.TabStop = true;
            this.BXmove1.Text = "BX";
            this.BXmove1.UseVisualStyleBackColor = true;
            // 
            // CXmove1
            // 
            this.CXmove1.AutoSize = true;
            this.CXmove1.Location = new System.Drawing.Point(7, 65);
            this.CXmove1.Name = "CXmove1";
            this.CXmove1.Size = new System.Drawing.Size(39, 17);
            this.CXmove1.TabIndex = 24;
            this.CXmove1.TabStop = true;
            this.CXmove1.Text = "CX";
            this.CXmove1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(467, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "MOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "8086-simulator";
            this.label1.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test.Properties.Resources.processor;
            this.pictureBox1.Location = new System.Drawing.Point(86, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.SUBMIT);
            this.Controls.Add(this.DESTINATION);
            this.Controls.Add(this.SOURCE);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.textBoxDX);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.textBoxCX);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.textBoxBX);
            this.Controls.Add(this.AX);
            this.Controls.Add(this.textBoxAX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.SOURCE.ResumeLayout(false);
            this.SOURCE.PerformLayout();
            this.DESTINATION.ResumeLayout(false);
            this.DESTINATION.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AXmove;
        private System.Windows.Forms.RadioButton DXmove;
        private System.Windows.Forms.RadioButton CXmove;
        private System.Windows.Forms.RadioButton BXmove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AXmove1;
        private System.Windows.Forms.RadioButton DXmove1;
        private System.Windows.Forms.RadioButton BXmove1;
        private System.Windows.Forms.RadioButton CXmove1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

