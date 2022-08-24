namespace WFAEntity240822G
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
            this.btnToList = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnDataDiff = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(12, 37);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(79, 26);
            this.btnToList.TabIndex = 0;
            this.btnToList.Text = "ToList";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(12, 69);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(79, 26);
            this.btnTake.TabIndex = 1;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(97, 69);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(79, 26);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(97, 37);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(79, 26);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(182, 69);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(79, 26);
            this.btnContains.TabIndex = 5;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(182, 37);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(79, 26);
            this.btnWhere.TabIndex = 4;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(267, 69);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(79, 26);
            this.btnAny.TabIndex = 7;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(267, 37);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(79, 26);
            this.btnOrderBy.TabIndex = 6;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(607, 37);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(79, 26);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(522, 37);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(79, 26);
            this.btnFirstOrDefault.TabIndex = 10;
            this.btnFirstOrDefault.Text = "FirstOrDefault";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(437, 37);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(79, 26);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(352, 37);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(79, 26);
            this.btnGroupBy.TabIndex = 8;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnDataDiff
            // 
            this.btnDataDiff.Location = new System.Drawing.Point(182, 134);
            this.btnDataDiff.Name = "btnDataDiff";
            this.btnDataDiff.Size = new System.Drawing.Size(79, 26);
            this.btnDataDiff.TabIndex = 14;
            this.btnDataDiff.Text = "DataDiff";
            this.btnDataDiff.UseVisualStyleBackColor = true;
            this.btnDataDiff.Click += new System.EventHandler(this.btnDataDiff_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(97, 134);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(79, 26);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 134);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(79, 26);
            this.btnCount.TabIndex = 12;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Linq To Methods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aggregate Functions";
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(12, 179);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(776, 259);
            this.dgwList.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDataDiff);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnToList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnDataDiff;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwList;
    }
}

