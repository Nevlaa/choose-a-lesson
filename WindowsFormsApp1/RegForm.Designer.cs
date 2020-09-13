namespace WindowsFormsApp1
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chBxSwim = new System.Windows.Forms.CheckBox();
            this.chBxSnorkel = new System.Windows.Forms.CheckBox();
            this.chBxDive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdvanced = new System.Windows.Forms.RadioButton();
            this.radIntermediate = new System.Windows.Forms.RadioButton();
            this.radBeginner = new System.Windows.Forms.RadioButton();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbLessons = new System.Windows.Forms.ComboBox();
            this.lblLessons = new System.Windows.Forms.Label();
            this.lstInstructor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "\" Select Lesson\"";
            // 
            // chBxSwim
            // 
            this.chBxSwim.AutoSize = true;
            this.chBxSwim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxSwim.Location = new System.Drawing.Point(33, 131);
            this.chBxSwim.Name = "chBxSwim";
            this.chBxSwim.Size = new System.Drawing.Size(126, 28);
            this.chBxSwim.TabIndex = 2;
            this.chBxSwim.Text = "Swim -  $50";
            this.chBxSwim.UseVisualStyleBackColor = true;
            this.chBxSwim.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // chBxSnorkel
            // 
            this.chBxSnorkel.AutoSize = true;
            this.chBxSnorkel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxSnorkel.Location = new System.Drawing.Point(33, 175);
            this.chBxSnorkel.Name = "chBxSnorkel";
            this.chBxSnorkel.Size = new System.Drawing.Size(144, 28);
            this.chBxSnorkel.TabIndex = 3;
            this.chBxSnorkel.Text = "Snorkel -  $25";
            this.chBxSnorkel.UseVisualStyleBackColor = true;
            this.chBxSnorkel.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // chBxDive
            // 
            this.chBxDive.AutoSize = true;
            this.chBxDive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxDive.Location = new System.Drawing.Point(33, 219);
            this.chBxDive.Name = "chBxDive";
            this.chBxDive.Size = new System.Drawing.Size(127, 28);
            this.chBxDive.TabIndex = 4;
            this.chBxDive.Text = "Dive -  $100";
            this.chBxDive.UseVisualStyleBackColor = true;
            this.chBxDive.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "**Check all that apply**";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radAdvanced);
            this.groupBox1.Controls.Add(this.radIntermediate);
            this.groupBox1.Controls.Add(this.radBeginner);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(328, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Level";
            // 
            // radAdvanced
            // 
            this.radAdvanced.AutoSize = true;
            this.radAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdvanced.Location = new System.Drawing.Point(7, 120);
            this.radAdvanced.Name = "radAdvanced";
            this.radAdvanced.Size = new System.Drawing.Size(114, 28);
            this.radAdvanced.TabIndex = 2;
            this.radAdvanced.Text = "Advanced";
            this.radAdvanced.UseVisualStyleBackColor = true;
            this.radAdvanced.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radIntermediate
            // 
            this.radIntermediate.AutoSize = true;
            this.radIntermediate.Checked = true;
            this.radIntermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIntermediate.Location = new System.Drawing.Point(7, 76);
            this.radIntermediate.Name = "radIntermediate";
            this.radIntermediate.Size = new System.Drawing.Size(131, 28);
            this.radIntermediate.TabIndex = 1;
            this.radIntermediate.TabStop = true;
            this.radIntermediate.Text = "Intermediate";
            this.radIntermediate.UseVisualStyleBackColor = true;
            this.radIntermediate.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radBeginner
            // 
            this.radBeginner.AutoSize = true;
            this.radBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBeginner.Location = new System.Drawing.Point(7, 32);
            this.radBeginner.Name = "radBeginner";
            this.radBeginner.Size = new System.Drawing.Size(105, 28);
            this.radBeginner.TabIndex = 0;
            this.radBeginner.Text = "Beginner";
            this.radBeginner.UseVisualStyleBackColor = true;
            this.radBeginner.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(120, 32);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(282, 31);
            this.txtBxName.TabIndex = 8;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(306, 282);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 24);
            this.lblMsg.TabIndex = 9;
            // 
            // txtBxResult
            // 
            this.txtBxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxResult.Location = new System.Drawing.Point(37, 485);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(269, 38);
            this.txtBxResult.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(677, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 38);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbLessons
            // 
            this.cmbLessons.BackColor = System.Drawing.Color.White;
            this.cmbLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLessons.FormattingEnabled = true;
            this.cmbLessons.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbLessons.Location = new System.Drawing.Point(33, 338);
            this.cmbLessons.Name = "cmbLessons";
            this.cmbLessons.Size = new System.Drawing.Size(162, 32);
            this.cmbLessons.TabIndex = 12;
            // 
            // lblLessons
            // 
            this.lblLessons.AutoSize = true;
            this.lblLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLessons.Location = new System.Drawing.Point(30, 317);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(165, 18);
            this.lblLessons.TabIndex = 13;
            this.lblLessons.Text = "How many lessons ?";
            // 
            // lstInstructor
            // 
            this.lstInstructor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInstructor.FormattingEnabled = true;
            this.lstInstructor.ItemHeight = 20;
            this.lstInstructor.Items.AddRange(new object[] {
            "",
            "     John Andrews",
            "",
            "     Samantha Jones",
            "",
            "     Beverly Cleary",
            "",
            "     Brian Thompson"});
            this.lstInstructor.Location = new System.Drawing.Point(624, 131);
            this.lstInstructor.Name = "lstInstructor";
            this.lstInstructor.Size = new System.Drawing.Size(185, 204);
            this.lstInstructor.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Instructor";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(867, 535);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstInstructor);
            this.Controls.Add(this.lblLessons);
            this.Controls.Add(this.cmbLessons);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chBxDive);
            this.Controls.Add(this.chBxSnorkel);
            this.Controls.Add(this.chBxSwim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "RegForm";
            this.Text = "Registration Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chBxSwim;
        private System.Windows.Forms.CheckBox chBxSnorkel;
        private System.Windows.Forms.CheckBox chBxDive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdvanced;
        private System.Windows.Forms.RadioButton radIntermediate;
        private System.Windows.Forms.RadioButton radBeginner;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbLessons;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.ListBox lstInstructor;
        private System.Windows.Forms.Label label4;
    }
}

