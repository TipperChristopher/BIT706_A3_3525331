namespace Assessment3
{
    partial class CustomersMenu
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
            this.btnAdding = new System.Windows.Forms.Button();
            this.btnFinding = new System.Windows.Forms.Button();
            this.btnEditing = new System.Windows.Forms.Button();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdding
            // 
            this.btnAdding.Location = new System.Drawing.Point(12, 33);
            this.btnAdding.Name = "btnAdding";
            this.btnAdding.Size = new System.Drawing.Size(106, 23);
            this.btnAdding.TabIndex = 0;
            this.btnAdding.Text = "Adding Customer";
            this.btnAdding.UseVisualStyleBackColor = true;
            // 
            // btnFinding
            // 
            this.btnFinding.Location = new System.Drawing.Point(12, 100);
            this.btnFinding.Name = "btnFinding";
            this.btnFinding.Size = new System.Drawing.Size(106, 23);
            this.btnFinding.TabIndex = 1;
            this.btnFinding.Text = "Finding Customer";
            this.btnFinding.UseVisualStyleBackColor = true;
            // 
            // btnEditing
            // 
            this.btnEditing.Location = new System.Drawing.Point(12, 165);
            this.btnEditing.Name = "btnEditing";
            this.btnEditing.Size = new System.Drawing.Size(105, 23);
            this.btnEditing.TabIndex = 2;
            this.btnEditing.Text = "Editing Customer";
            this.btnEditing.UseVisualStyleBackColor = true;
            // 
            // btnDeleting
            // 
            this.btnDeleting.Location = new System.Drawing.Point(13, 223);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(105, 23);
            this.btnDeleting.TabIndex = 3;
            this.btnDeleting.Text = "Deleting Customer";
            this.btnDeleting.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(133, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 212);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 286);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDeleting);
            this.Controls.Add(this.btnEditing);
            this.Controls.Add(this.btnFinding);
            this.Controls.Add(this.btnAdding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdding;
        private System.Windows.Forms.Button btnFinding;
        private System.Windows.Forms.Button btnEditing;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.ListBox listBox1;
    }
}

