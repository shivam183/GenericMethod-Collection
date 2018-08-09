namespace GenericLinearSearchMethodTestForm
{
    partial class GenericLinearSearchMethodTestForm
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
            this.generatedArrayListBox = new System.Windows.Forms.ListBox();
            this.generatedArrayGroupBox = new System.Windows.Forms.GroupBox();
            this.searchValLbl = new System.Windows.Forms.Label();
            this.searchKeyTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchGrpBox = new System.Windows.Forms.GroupBox();
            this.numOfEleLbl = new System.Windows.Forms.Label();
            this.numOfEleTb = new System.Windows.Forms.TextBox();
            this.generateIntArrayBtn = new System.Windows.Forms.Button();
            this.generateDoubleArrayBtn = new System.Windows.Forms.Button();
            this.generateArrayGrpBox = new System.Windows.Forms.GroupBox();
            this.generatedArrayGroupBox.SuspendLayout();
            this.searchGrpBox.SuspendLayout();
            this.generateArrayGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generatedArrayListBox
            // 
            this.generatedArrayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedArrayListBox.FormattingEnabled = true;
            this.generatedArrayListBox.Location = new System.Drawing.Point(6, 32);
            this.generatedArrayListBox.Name = "generatedArrayListBox";
            this.generatedArrayListBox.Size = new System.Drawing.Size(295, 160);
            this.generatedArrayListBox.TabIndex = 12;
            this.generatedArrayListBox.SelectedIndexChanged += new System.EventHandler(this.generatedArrayListBox_SelectedIndexChanged);
            // 
            // generatedArrayGroupBox
            // 
            this.generatedArrayGroupBox.Controls.Add(this.generatedArrayListBox);
            this.generatedArrayGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedArrayGroupBox.Location = new System.Drawing.Point(313, 21);
            this.generatedArrayGroupBox.Name = "generatedArrayGroupBox";
            this.generatedArrayGroupBox.Size = new System.Drawing.Size(305, 211);
            this.generatedArrayGroupBox.TabIndex = 12;
            this.generatedArrayGroupBox.TabStop = false;
            this.generatedArrayGroupBox.Text = "Generated Array";
            // 
            // searchValLbl
            // 
            this.searchValLbl.AutoSize = true;
            this.searchValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchValLbl.Location = new System.Drawing.Point(3, 34);
            this.searchValLbl.Name = "searchValLbl";
            this.searchValLbl.Size = new System.Drawing.Size(76, 13);
            this.searchValLbl.TabIndex = 0;
            this.searchValLbl.Text = "Search Key:";
            // 
            // searchKeyTb
            // 
            this.searchKeyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKeyTb.Location = new System.Drawing.Point(85, 31);
            this.searchKeyTb.Name = "searchKeyTb";
            this.searchKeyTb.Size = new System.Drawing.Size(145, 20);
            this.searchKeyTb.TabIndex = 2;
            this.searchKeyTb.TextChanged += new System.EventHandler(this.searchKeyTb_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Enabled = false;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(28, 57);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(126, 57);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(92, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchGrpBox
            // 
            this.searchGrpBox.Controls.Add(this.clearBtn);
            this.searchGrpBox.Controls.Add(this.searchBtn);
            this.searchGrpBox.Controls.Add(this.searchKeyTb);
            this.searchGrpBox.Controls.Add(this.searchValLbl);
            this.searchGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGrpBox.Location = new System.Drawing.Point(18, 129);
            this.searchGrpBox.Name = "searchGrpBox";
            this.searchGrpBox.Size = new System.Drawing.Size(277, 93);
            this.searchGrpBox.TabIndex = 3;
            this.searchGrpBox.TabStop = false;
            this.searchGrpBox.Text = "Search";
            // 
            // numOfEleLbl
            // 
            this.numOfEleLbl.AutoSize = true;
            this.numOfEleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfEleLbl.Location = new System.Drawing.Point(6, 34);
            this.numOfEleLbl.Name = "numOfEleLbl";
            this.numOfEleLbl.Size = new System.Drawing.Size(120, 13);
            this.numOfEleLbl.TabIndex = 0;
            this.numOfEleLbl.Text = "Number of Elements";
            // 
            // numOfEleTb
            // 
            this.numOfEleTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfEleTb.Location = new System.Drawing.Point(132, 32);
            this.numOfEleTb.Name = "numOfEleTb";
            this.numOfEleTb.Size = new System.Drawing.Size(145, 20);
            this.numOfEleTb.TabIndex = 1;
            // 
            // generateIntArrayBtn
            // 
            this.generateIntArrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateIntArrayBtn.Location = new System.Drawing.Point(34, 58);
            this.generateIntArrayBtn.Name = "generateIntArrayBtn";
            this.generateIntArrayBtn.Size = new System.Drawing.Size(92, 23);
            this.generateIntArrayBtn.TabIndex = 5;
            this.generateIntArrayBtn.Text = "Int Array";
            this.generateIntArrayBtn.UseVisualStyleBackColor = true;
            this.generateIntArrayBtn.Click += new System.EventHandler(this.generateIntArrayBtn_Click);
            // 
            // generateDoubleArrayBtn
            // 
            this.generateDoubleArrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateDoubleArrayBtn.Location = new System.Drawing.Point(132, 58);
            this.generateDoubleArrayBtn.Name = "generateDoubleArrayBtn";
            this.generateDoubleArrayBtn.Size = new System.Drawing.Size(92, 23);
            this.generateDoubleArrayBtn.TabIndex = 6;
            this.generateDoubleArrayBtn.Text = "Double Array";
            this.generateDoubleArrayBtn.UseVisualStyleBackColor = true;
            this.generateDoubleArrayBtn.Click += new System.EventHandler(this.generateDoubleArrayBtn_Click);
            // 
            // generateArrayGrpBox
            // 
            this.generateArrayGrpBox.Controls.Add(this.generateDoubleArrayBtn);
            this.generateArrayGrpBox.Controls.Add(this.generateIntArrayBtn);
            this.generateArrayGrpBox.Controls.Add(this.numOfEleTb);
            this.generateArrayGrpBox.Controls.Add(this.numOfEleLbl);
            this.generateArrayGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateArrayGrpBox.Location = new System.Drawing.Point(12, 12);
            this.generateArrayGrpBox.Name = "generateArrayGrpBox";
            this.generateArrayGrpBox.Size = new System.Drawing.Size(283, 100);
            this.generateArrayGrpBox.TabIndex = 2;
            this.generateArrayGrpBox.TabStop = false;
            this.generateArrayGrpBox.Text = "Array Generation";
            // 
            // GenericLinearSearchMethodTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 239);
            this.Controls.Add(this.generatedArrayGroupBox);
            this.Controls.Add(this.searchGrpBox);
            this.Controls.Add(this.generateArrayGrpBox);
            this.Name = "GenericLinearSearchMethodTestForm";
            this.Text = "Generic Linear Search Method";
            this.generatedArrayGroupBox.ResumeLayout(false);
            this.searchGrpBox.ResumeLayout(false);
            this.searchGrpBox.PerformLayout();
            this.generateArrayGrpBox.ResumeLayout(false);
            this.generateArrayGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox generatedArrayListBox;
        private System.Windows.Forms.GroupBox generatedArrayGroupBox;
        private System.Windows.Forms.Label searchValLbl;
        private System.Windows.Forms.TextBox searchKeyTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox searchGrpBox;
        private System.Windows.Forms.Label numOfEleLbl;
        private System.Windows.Forms.TextBox numOfEleTb;
        private System.Windows.Forms.Button generateIntArrayBtn;
        private System.Windows.Forms.Button generateDoubleArrayBtn;
        private System.Windows.Forms.GroupBox generateArrayGrpBox;
    }
}

