
namespace Laboratorium_1
{
    partial class Form
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
            this.coordBox = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.controlBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coordBox
            // 
            this.coordBox.Location = new System.Drawing.Point(644, 29);
            this.coordBox.Name = "coordBox";
            this.coordBox.Size = new System.Drawing.Size(227, 20);
            this.coordBox.TabIndex = 0;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(610, 535);
            this.Panel.TabIndex = 1;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.Panel.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.Panel.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Errors";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(644, 527);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(227, 20);
            this.ErrorBox.TabIndex = 4;
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(644, 79);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(227, 20);
            this.controlBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Control State";
            // 
            // mouseBox
            // 
            this.mouseBox.Location = new System.Drawing.Point(644, 128);
            this.mouseBox.Name = "mouseBox";
            this.mouseBox.Size = new System.Drawing.Size(227, 20);
            this.mouseBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mouse button pressed";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mouseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.coordBox);
            this.KeyPreview = true;
            this.Name = "Form";
            this.Text = "Mouse Events";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coordBox;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.TextBox controlBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mouseBox;
        private System.Windows.Forms.Label label4;
    }
}

