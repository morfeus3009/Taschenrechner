
namespace Uebung
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
            this.txtInOut = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCalcRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInOut
            // 
            this.txtInOut.Location = new System.Drawing.Point(12, 30);
            this.txtInOut.Name = "txtInOut";
            this.txtInOut.Size = new System.Drawing.Size(249, 23);
            this.txtInOut.TabIndex = 0;
            this.txtInOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInOut_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(12, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(115, 133);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(43, 41);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRes.Location = new System.Drawing.Point(218, 133);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(43, 41);
            this.btnRes.TabIndex = 3;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(12, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(43, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.Location = new System.Drawing.Point(12, 243);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(249, 41);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "berechne";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCalcRes
            // 
            this.txtCalcRes.Location = new System.Drawing.Point(12, 214);
            this.txtCalcRes.Name = "txtCalcRes";
            this.txtCalcRes.Size = new System.Drawing.Size(249, 23);
            this.txtCalcRes.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 293);
            this.Controls.Add(this.txtCalcRes);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtCalcRes;
    }
}

