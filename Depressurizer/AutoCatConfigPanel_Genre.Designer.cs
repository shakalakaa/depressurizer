﻿namespace Depressurizer {
    partial class AutoCatConfigPanel_Genre {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.helpRemoveExisting = new System.Windows.Forms.Label();
            this.helpPrefix = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.tblIgnore = new System.Windows.Forms.TableLayoutPanel();
            this.cmdUncheckAll = new System.Windows.Forms.Button();
            this.cmdCheckAll = new System.Windows.Forms.Button();
            this.lstIgnore = new System.Windows.Forms.ListView();
            this.lblIgnore = new System.Windows.Forms.Label();
            this.chkRemoveExisting = new System.Windows.Forms.CheckBox();
            this.lblMaxCats = new System.Windows.Forms.Label();
            this.numMaxCats = new System.Windows.Forms.NumericUpDown();
            this.grpMain.SuspendLayout();
            this.tblIgnore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCats)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.helpRemoveExisting);
            this.grpMain.Controls.Add(this.helpPrefix);
            this.grpMain.Controls.Add(this.lblPrefix);
            this.grpMain.Controls.Add(this.txtPrefix);
            this.grpMain.Controls.Add(this.tblIgnore);
            this.grpMain.Controls.Add(this.lstIgnore);
            this.grpMain.Controls.Add(this.lblIgnore);
            this.grpMain.Controls.Add(this.chkRemoveExisting);
            this.grpMain.Controls.Add(this.lblMaxCats);
            this.grpMain.Controls.Add(this.numMaxCats);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(588, 442);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Edit Genre AutoCat";
            // 
            // helpRemoveExisting
            // 
            this.helpRemoveExisting.AutoSize = true;
            this.helpRemoveExisting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpRemoveExisting.Location = new System.Drawing.Point(238, 82);
            this.helpRemoveExisting.Name = "helpRemoveExisting";
            this.helpRemoveExisting.Size = new System.Drawing.Size(15, 15);
            this.helpRemoveExisting.TabIndex = 1;
            this.helpRemoveExisting.Text = "?";
            // 
            // helpPrefix
            // 
            this.helpPrefix.AutoSize = true;
            this.helpPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpPrefix.Location = new System.Drawing.Point(238, 22);
            this.helpPrefix.Name = "helpPrefix";
            this.helpPrefix.Size = new System.Drawing.Size(15, 15);
            this.helpPrefix.TabIndex = 11;
            this.helpPrefix.Text = "?";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(25, 22);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "Prefix:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(67, 19);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(165, 20);
            this.txtPrefix.TabIndex = 1;
            // 
            // tblIgnore
            // 
            this.tblIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblIgnore.ColumnCount = 2;
            this.tblIgnore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIgnore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIgnore.Controls.Add(this.cmdUncheckAll, 1, 0);
            this.tblIgnore.Controls.Add(this.cmdCheckAll, 0, 0);
            this.tblIgnore.Location = new System.Drawing.Point(6, 408);
            this.tblIgnore.Name = "tblIgnore";
            this.tblIgnore.RowCount = 1;
            this.tblIgnore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIgnore.Size = new System.Drawing.Size(580, 30);
            this.tblIgnore.TabIndex = 7;
            // 
            // cmdUncheckAll
            // 
            this.cmdUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUncheckAll.Location = new System.Drawing.Point(293, 3);
            this.cmdUncheckAll.Name = "cmdUncheckAll";
            this.cmdUncheckAll.Size = new System.Drawing.Size(284, 23);
            this.cmdUncheckAll.TabIndex = 7;
            this.cmdUncheckAll.Text = "Uncheck All";
            this.cmdUncheckAll.UseVisualStyleBackColor = true;
            this.cmdUncheckAll.Click += new System.EventHandler(this.cmdUncheckAll_Click);
            // 
            // cmdCheckAll
            // 
            this.cmdCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCheckAll.Location = new System.Drawing.Point(3, 3);
            this.cmdCheckAll.Name = "cmdCheckAll";
            this.cmdCheckAll.Size = new System.Drawing.Size(284, 23);
            this.cmdCheckAll.TabIndex = 6;
            this.cmdCheckAll.Text = "Check All";
            this.cmdCheckAll.UseVisualStyleBackColor = true;
            this.cmdCheckAll.Click += new System.EventHandler(this.cmdCheckAll_Click);
            // 
            // lstIgnore
            // 
            this.lstIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIgnore.CheckBoxes = true;
            this.lstIgnore.Location = new System.Drawing.Point(9, 130);
            this.lstIgnore.Name = "lstIgnore";
            this.lstIgnore.Size = new System.Drawing.Size(575, 279);
            this.lstIgnore.TabIndex = 3;
            this.lstIgnore.UseCompatibleStateImageBehavior = false;
            this.lstIgnore.View = System.Windows.Forms.View.List;
            // 
            // lblIgnore
            // 
            this.lblIgnore.AutoSize = true;
            this.lblIgnore.Location = new System.Drawing.Point(6, 114);
            this.lblIgnore.Name = "lblIgnore";
            this.lblIgnore.Size = new System.Drawing.Size(104, 13);
            this.lblIgnore.TabIndex = 2;
            this.lblIgnore.Text = "Categories to ignore:";
            // 
            // chkRemoveExisting
            // 
            this.chkRemoveExisting.AutoSize = true;
            this.chkRemoveExisting.Location = new System.Drawing.Point(46, 82);
            this.chkRemoveExisting.Name = "chkRemoveExisting";
            this.chkRemoveExisting.Size = new System.Drawing.Size(186, 17);
            this.chkRemoveExisting.TabIndex = 0;
            this.chkRemoveExisting.Text = "Remove existing genre categories";
            this.chkRemoveExisting.UseVisualStyleBackColor = true;
            // 
            // lblMaxCats
            // 
            this.lblMaxCats.AutoSize = true;
            this.lblMaxCats.Location = new System.Drawing.Point(64, 47);
            this.lblMaxCats.Name = "lblMaxCats";
            this.lblMaxCats.Size = new System.Drawing.Size(148, 26);
            this.lblMaxCats.TabIndex = 3;
            this.lblMaxCats.Text = "Maximum categories to assign\r\n(0 for unlimited)";
            // 
            // numMaxCats
            // 
            this.numMaxCats.Location = new System.Drawing.Point(6, 50);
            this.numMaxCats.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxCats.Name = "numMaxCats";
            this.numMaxCats.Size = new System.Drawing.Size(52, 20);
            this.numMaxCats.TabIndex = 2;
            this.numMaxCats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxCats.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // AutoCatConfigPanel_Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMain);
            this.Name = "AutoCatConfigPanel_Genre";
            this.Size = new System.Drawing.Size(588, 442);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.tblIgnore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label helpRemoveExisting;
        private System.Windows.Forms.Label helpPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TableLayoutPanel tblIgnore;
        private System.Windows.Forms.Button cmdUncheckAll;
        private System.Windows.Forms.Button cmdCheckAll;
        private System.Windows.Forms.ListView lstIgnore;
        private System.Windows.Forms.Label lblIgnore;
        private System.Windows.Forms.CheckBox chkRemoveExisting;
        private System.Windows.Forms.Label lblMaxCats;
        private System.Windows.Forms.NumericUpDown numMaxCats;
    }
}
