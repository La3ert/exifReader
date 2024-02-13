namespace ExifReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bttn_Change_Orientation = new System.Windows.Forms.Button();
            this.bttn_Change_Model = new System.Windows.Forms.Button();
            this.bttn_Change_Date = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.bttn_Change_Make = new System.Windows.Forms.Button();
            this.txtBox_ChangeOrientation = new System.Windows.Forms.TextBox();
            this.txtBox_ChangeMake = new System.Windows.Forms.TextBox();
            this.txtBox_ChangeModel = new System.Windows.Forms.TextBox();
            this.txtBox_ChangeDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(100, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 68);
            this.label3.TabIndex = 3;
            this.label3.Text = "Picture taken on";
            // 
            // lblMake
            // 
            this.lblMake.Location = new System.Drawing.Point(297, 122);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(138, 68);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "make";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(297, 190);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(138, 68);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "model";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(297, 258);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(138, 68);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "date";
            // 
            // bttn_Change_Orientation
            // 
            this.bttn_Change_Orientation.Location = new System.Drawing.Point(500, 309);
            this.bttn_Change_Orientation.Name = "bttn_Change_Orientation";
            this.bttn_Change_Orientation.Size = new System.Drawing.Size(194, 51);
            this.bttn_Change_Orientation.TabIndex = 7;
            this.bttn_Change_Orientation.Text = "Change Orientation";
            this.bttn_Change_Orientation.UseVisualStyleBackColor = true;
            this.bttn_Change_Orientation.Click += new System.EventHandler(this.bttn_Change_Orientation_Click);
            // 
            // bttn_Change_Model
            // 
            this.bttn_Change_Model.Location = new System.Drawing.Point(500, 173);
            this.bttn_Change_Model.Name = "bttn_Change_Model";
            this.bttn_Change_Model.Size = new System.Drawing.Size(194, 51);
            this.bttn_Change_Model.TabIndex = 8;
            this.bttn_Change_Model.Text = "Change Model";
            this.bttn_Change_Model.UseVisualStyleBackColor = true;
            this.bttn_Change_Model.Click += new System.EventHandler(this.bttn_Change_Model_Click);
            // 
            // bttn_Change_Date
            // 
            this.bttn_Change_Date.Location = new System.Drawing.Point(500, 241);
            this.bttn_Change_Date.Name = "bttn_Change_Date";
            this.bttn_Change_Date.Size = new System.Drawing.Size(194, 51);
            this.bttn_Change_Date.TabIndex = 9;
            this.bttn_Change_Date.Text = "Change Date";
            this.bttn_Change_Date.UseVisualStyleBackColor = true;
            this.bttn_Change_Date.Click += new System.EventHandler(this.bttn_Change_Date_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(100, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 68);
            this.label4.TabIndex = 10;
            this.label4.Text = "Orientation";
            // 
            // lblOrientation
            // 
            this.lblOrientation.Location = new System.Drawing.Point(297, 326);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(138, 68);
            this.lblOrientation.TabIndex = 11;
            this.lblOrientation.Text = "orientation";
            // 
            // bttn_Change_Make
            // 
            this.bttn_Change_Make.Location = new System.Drawing.Point(500, 105);
            this.bttn_Change_Make.Name = "bttn_Change_Make";
            this.bttn_Change_Make.Size = new System.Drawing.Size(194, 51);
            this.bttn_Change_Make.TabIndex = 12;
            this.bttn_Change_Make.Text = "Change Make";
            this.bttn_Change_Make.UseVisualStyleBackColor = true;
            this.bttn_Change_Make.Click += new System.EventHandler(this.bttn_Change_Make_Click);
            // 
            // txtBox_ChangeOrientation
            // 
            this.txtBox_ChangeOrientation.Location = new System.Drawing.Point(536, 351);
            this.txtBox_ChangeOrientation.Name = "txtBox_ChangeOrientation";
            this.txtBox_ChangeOrientation.Size = new System.Drawing.Size(126, 22);
            this.txtBox_ChangeOrientation.TabIndex = 13;
            // 
            // txtBox_ChangeMake
            // 
            this.txtBox_ChangeMake.Location = new System.Drawing.Point(536, 145);
            this.txtBox_ChangeMake.Name = "txtBox_ChangeMake";
            this.txtBox_ChangeMake.Size = new System.Drawing.Size(126, 22);
            this.txtBox_ChangeMake.TabIndex = 14;
            // 
            // txtBox_ChangeModel
            // 
            this.txtBox_ChangeModel.Location = new System.Drawing.Point(536, 213);
            this.txtBox_ChangeModel.Name = "txtBox_ChangeModel";
            this.txtBox_ChangeModel.Size = new System.Drawing.Size(126, 22);
            this.txtBox_ChangeModel.TabIndex = 15;
            // 
            // txtBox_ChangeDate
            // 
            this.txtBox_ChangeDate.Location = new System.Drawing.Point(536, 281);
            this.txtBox_ChangeDate.Name = "txtBox_ChangeDate";
            this.txtBox_ChangeDate.Size = new System.Drawing.Size(126, 22);
            this.txtBox_ChangeDate.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_ChangeDate);
            this.Controls.Add(this.txtBox_ChangeModel);
            this.Controls.Add(this.txtBox_ChangeMake);
            this.Controls.Add(this.txtBox_ChangeOrientation);
            this.Controls.Add(this.bttn_Change_Make);
            this.Controls.Add(this.lblOrientation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttn_Change_Date);
            this.Controls.Add(this.bttn_Change_Model);
            this.Controls.Add(this.bttn_Change_Orientation);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBox_ChangeDate;

        private System.Windows.Forms.TextBox txtBox_ChangeModel;

        private System.Windows.Forms.TextBox txtBox_ChangeMake;

        private System.Windows.Forms.TextBox txtBox_ChangeOrientation;

        private System.Windows.Forms.TextBox txtBox_ChageOrientation;

        private System.Windows.Forms.Button bttn_Change_Make;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrientation;

        private System.Windows.Forms.Button bttn_Change_Orientation;
        private System.Windows.Forms.Button bttn_Change_Model;
        private System.Windows.Forms.Button bttn_Change_Date;

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMake;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}