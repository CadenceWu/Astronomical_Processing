
namespace Astronomical_Processing2
{
    partial class AstroForm
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.ListBoxArrayList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSequential = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonMean = new System.Windows.Forms.Button();
            this.textMean = new System.Windows.Forms.TextBox();
            this.textAverage = new System.Windows.Forms.TextBox();
            this.textRange = new System.Windows.Forms.TextBox();
            this.textMode = new System.Windows.Forms.TextBox();
            this.toolMean = new System.Windows.Forms.ToolTip(this.components);
            this.toolMode = new System.Windows.Forms.ToolTip(this.components);
            this.toolRange = new System.Windows.Forms.ToolTip(this.components);
            this.toolAverage = new System.Windows.Forms.ToolTip(this.components);
            this.toolSequential = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(99, 47);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(103, 20);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearch_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(46, 74);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(74, 21);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(46, 102);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(46, 132);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(46, 162);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(126, 74);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 5;
            this.buttonFill.Text = "Fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(127, 103);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // ListBoxArrayList
            // 
            this.ListBoxArrayList.FormattingEnabled = true;
            this.ListBoxArrayList.Location = new System.Drawing.Point(273, 49);
            this.ListBoxArrayList.Name = "ListBoxArrayList";
            this.ListBoxArrayList.Size = new System.Drawing.Size(235, 342);
            this.ListBoxArrayList.TabIndex = 7;
            this.ListBoxArrayList.SelectedIndexChanged += new System.EventHandler(this.ListBoxArrayList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // buttonSequential
            // 
            this.buttonSequential.Location = new System.Drawing.Point(127, 134);
            this.buttonSequential.Name = "buttonSequential";
            this.buttonSequential.Size = new System.Drawing.Size(74, 21);
            this.buttonSequential.TabIndex = 9;
            this.buttonSequential.Text = "Seq.Search";
            this.toolSequential.SetToolTip(this.buttonSequential, "Checks each variable until a match is found");
            this.buttonSequential.UseVisualStyleBackColor = true;
            this.buttonSequential.Click += new System.EventHandler(this.buttonSequential_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(46, 312);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(74, 21);
            this.buttonAverage.TabIndex = 10;
            this.buttonAverage.Text = "Average";
            this.toolAverage.SetToolTip(this.buttonAverage, "Adding all the numbers together, then dividing by how many variables are in the a" +
        "rray list");
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(47, 285);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(74, 21);
            this.buttonRange.TabIndex = 11;
            this.buttonRange.Text = "Range";
            this.toolRange.SetToolTip(this.buttonRange, "Showing the difference between the max and min value in the array list");
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Location = new System.Drawing.Point(47, 258);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(74, 21);
            this.buttonMode.TabIndex = 12;
            this.buttonMode.Text = "Mode";
            this.toolMode.SetToolTip(this.buttonMode, "Shows the most frequent variable in the array list");
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonMean
            // 
            this.buttonMean.Location = new System.Drawing.Point(47, 231);
            this.buttonMean.Name = "buttonMean";
            this.buttonMean.Size = new System.Drawing.Size(74, 21);
            this.buttonMean.TabIndex = 13;
            this.buttonMean.Text = "Mean";
            this.toolMean.SetToolTip(this.buttonMean, "Adding both the max and min value together and then dividing by 2");
            this.buttonMean.UseVisualStyleBackColor = true;
            this.buttonMean.Click += new System.EventHandler(this.buttonMean_Click);
            // 
            // textMean
            // 
            this.textMean.Location = new System.Drawing.Point(127, 232);
            this.textMean.Name = "textMean";
            this.textMean.ReadOnly = true;
            this.textMean.Size = new System.Drawing.Size(62, 20);
            this.textMean.TabIndex = 14;
            // 
            // textAverage
            // 
            this.textAverage.Location = new System.Drawing.Point(126, 311);
            this.textAverage.Name = "textAverage";
            this.textAverage.ReadOnly = true;
            this.textAverage.Size = new System.Drawing.Size(63, 20);
            this.textAverage.TabIndex = 15;
            // 
            // textRange
            // 
            this.textRange.Location = new System.Drawing.Point(127, 285);
            this.textRange.Name = "textRange";
            this.textRange.ReadOnly = true;
            this.textRange.Size = new System.Drawing.Size(62, 20);
            this.textRange.TabIndex = 16;
            // 
            // textMode
            // 
            this.textMode.Location = new System.Drawing.Point(127, 258);
            this.textMode.Name = "textMode";
            this.textMode.ReadOnly = true;
            this.textMode.Size = new System.Drawing.Size(62, 20);
            this.textMode.TabIndex = 17;
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.textMode);
            this.Controls.Add(this.textRange);
            this.Controls.Add(this.textAverage);
            this.Controls.Add(this.textMean);
            this.Controls.Add(this.buttonMean);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonSequential);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxArrayList);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TextBoxSearch);
            this.Name = "AstroForm";
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox ListBoxArrayList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSequential;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonMean;
        private System.Windows.Forms.TextBox textMean;
        private System.Windows.Forms.TextBox textAverage;
        private System.Windows.Forms.TextBox textRange;
        private System.Windows.Forms.TextBox textMode;
        private System.Windows.Forms.ToolTip toolMean;
        private System.Windows.Forms.ToolTip toolMode;
        private System.Windows.Forms.ToolTip toolRange;
        private System.Windows.Forms.ToolTip toolAverage;
        private System.Windows.Forms.ToolTip toolSequential;
    }
}

