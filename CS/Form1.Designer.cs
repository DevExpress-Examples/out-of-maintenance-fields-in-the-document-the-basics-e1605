namespace FieldsExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnUpdateField = new System.Windows.Forms.Button();
            this.btnShowFieldCode = new System.Windows.Forms.Button();
            this.btnShowFieldResult = new System.Windows.Forms.Button();
            this.btnModifyFieldCode = new System.Windows.Forms.Button();
            this.btnCreateFieldFromSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(12, 12);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(419, 334);
            this.richEditControl1.TabIndex = 0;
            // 
            // btnAddField
            // 
            this.btnAddField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddField.Location = new System.Drawing.Point(437, 12);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(153, 23);
            this.btnAddField.TabIndex = 1;
            this.btnAddField.Text = "Add field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnUpdateField
            // 
            this.btnUpdateField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateField.Location = new System.Drawing.Point(437, 42);
            this.btnUpdateField.Name = "btnUpdateField";
            this.btnUpdateField.Size = new System.Drawing.Size(153, 23);
            this.btnUpdateField.TabIndex = 2;
            this.btnUpdateField.Text = "Update field";
            this.btnUpdateField.UseVisualStyleBackColor = true;
            this.btnUpdateField.Click += new System.EventHandler(this.btnUpdateField_Click);
            // 
            // btnShowFieldCode
            // 
            this.btnShowFieldCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFieldCode.Location = new System.Drawing.Point(437, 72);
            this.btnShowFieldCode.Name = "btnShowFieldCode";
            this.btnShowFieldCode.Size = new System.Drawing.Size(153, 23);
            this.btnShowFieldCode.TabIndex = 3;
            this.btnShowFieldCode.Text = "Show Field Code";
            this.btnShowFieldCode.UseVisualStyleBackColor = true;
            this.btnShowFieldCode.Click += new System.EventHandler(this.btnShowFieldCode_Click);
            // 
            // btnShowFieldResult
            // 
            this.btnShowFieldResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowFieldResult.Location = new System.Drawing.Point(437, 102);
            this.btnShowFieldResult.Name = "btnShowFieldResult";
            this.btnShowFieldResult.Size = new System.Drawing.Size(153, 23);
            this.btnShowFieldResult.TabIndex = 4;
            this.btnShowFieldResult.Text = "Show Field Result";
            this.btnShowFieldResult.UseVisualStyleBackColor = true;
            this.btnShowFieldResult.Click += new System.EventHandler(this.btnShowFieldResult_Click);
            // 
            // btnModifyFieldCode
            // 
            this.btnModifyFieldCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyFieldCode.Location = new System.Drawing.Point(437, 132);
            this.btnModifyFieldCode.Name = "btnModifyFieldCode";
            this.btnModifyFieldCode.Size = new System.Drawing.Size(153, 23);
            this.btnModifyFieldCode.TabIndex = 5;
            this.btnModifyFieldCode.Text = "Modify field code";
            this.btnModifyFieldCode.UseVisualStyleBackColor = true;
            this.btnModifyFieldCode.Click += new System.EventHandler(this.btnModifyFieldCode_Click);
            // 
            // btnCreateFieldFromSelection
            // 
            this.btnCreateFieldFromSelection.Location = new System.Drawing.Point(437, 162);
            this.btnCreateFieldFromSelection.Name = "btnCreateFieldFromSelection";
            this.btnCreateFieldFromSelection.Size = new System.Drawing.Size(153, 23);
            this.btnCreateFieldFromSelection.TabIndex = 6;
            this.btnCreateFieldFromSelection.Text = "Create field from selection";
            this.btnCreateFieldFromSelection.UseVisualStyleBackColor = true;
            this.btnCreateFieldFromSelection.Click += new System.EventHandler(this.btnCreateFieldFromSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 358);
            this.Controls.Add(this.btnCreateFieldFromSelection);
            this.Controls.Add(this.btnModifyFieldCode);
            this.Controls.Add(this.btnShowFieldResult);
            this.Controls.Add(this.btnShowFieldCode);
            this.Controls.Add(this.btnUpdateField);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.richEditControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnUpdateField;
        private System.Windows.Forms.Button btnShowFieldCode;
        private System.Windows.Forms.Button btnShowFieldResult;
        private System.Windows.Forms.Button btnModifyFieldCode;
        private System.Windows.Forms.Button btnCreateFieldFromSelection;
    }
}

