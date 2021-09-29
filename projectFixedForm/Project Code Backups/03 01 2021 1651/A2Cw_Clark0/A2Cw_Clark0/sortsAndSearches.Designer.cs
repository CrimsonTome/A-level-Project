using System;

namespace A2Cw_Clark0
{
    partial class sortsAndSearches
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.lblArraySize = new System.Windows.Forms.Label();
            this.lblArrayData = new System.Windows.Forms.Label();
            this.btnArrayHelp = new System.Windows.Forms.Button();
            this.btnDrawBars = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.txtSearchData = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblhelp = new System.Windows.Forms.Label();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowSteps = new System.Windows.Forms.Label();
            this.chkShowSteps = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(565, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(234, 124);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(325, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 124);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Yellow;
            this.txtInput.Location = new System.Drawing.Point(129, 197);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(324, 26);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.Color.Black;
            this.lblInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.Yellow;
            this.lblInput.Location = new System.Drawing.Point(27, 108);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(765, 18);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "If you are using your own data please enter it below then press start when ready " +
    "or if using random numbers just press start";
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.Gray;
            this.btnShowList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.ForeColor = System.Drawing.Color.Yellow;
            this.btnShowList.Location = new System.Drawing.Point(129, 229);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(108, 39);
            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "Show list";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.BackColor = System.Drawing.Color.Gray;
            this.btnAddNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumber.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddNumber.Location = new System.Drawing.Point(243, 229);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(158, 39);
            this.btnAddNumber.TabIndex = 5;
            this.btnAddNumber.Text = "Add number to list";
            this.btnAddNumber.UseVisualStyleBackColor = false;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // txtArraySize
            // 
            this.txtArraySize.BackColor = System.Drawing.Color.White;
            this.txtArraySize.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArraySize.ForeColor = System.Drawing.Color.Yellow;
            this.txtArraySize.Location = new System.Drawing.Point(129, 165);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArraySize.Size = new System.Drawing.Size(324, 26);
            this.txtArraySize.TabIndex = 6;
            this.txtArraySize.TextChanged += new System.EventHandler(this.txtArraySize_TextChanged);
            // 
            // lblArraySize
            // 
            this.lblArraySize.AutoSize = true;
            this.lblArraySize.BackColor = System.Drawing.Color.Black;
            this.lblArraySize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArraySize.ForeColor = System.Drawing.Color.Yellow;
            this.lblArraySize.Location = new System.Drawing.Point(29, 168);
            this.lblArraySize.Name = "lblArraySize";
            this.lblArraySize.Size = new System.Drawing.Size(94, 23);
            this.lblArraySize.TabIndex = 7;
            this.lblArraySize.Text = "Array size:";
            // 
            // lblArrayData
            // 
            this.lblArrayData.AutoSize = true;
            this.lblArrayData.BackColor = System.Drawing.Color.Black;
            this.lblArrayData.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrayData.ForeColor = System.Drawing.Color.Yellow;
            this.lblArrayData.Location = new System.Drawing.Point(26, 196);
            this.lblArrayData.Name = "lblArrayData";
            this.lblArrayData.Size = new System.Drawing.Size(97, 23);
            this.lblArrayData.TabIndex = 8;
            this.lblArrayData.Text = "Array data:";
            // 
            // btnArrayHelp
            // 
            this.btnArrayHelp.BackColor = System.Drawing.Color.Gray;
            this.btnArrayHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayHelp.ForeColor = System.Drawing.Color.Yellow;
            this.btnArrayHelp.Location = new System.Drawing.Point(30, 285);
            this.btnArrayHelp.Name = "btnArrayHelp";
            this.btnArrayHelp.Size = new System.Drawing.Size(121, 124);
            this.btnArrayHelp.TabIndex = 10;
            this.btnArrayHelp.Text = "Array config help";
            this.btnArrayHelp.UseVisualStyleBackColor = false;
            this.btnArrayHelp.Click += new System.EventHandler(this.btnArrayHelp_Click);
            // 
            // btnDrawBars
            // 
            this.btnDrawBars.BackColor = System.Drawing.Color.Gray;
            this.btnDrawBars.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawBars.ForeColor = System.Drawing.Color.Yellow;
            this.btnDrawBars.Location = new System.Drawing.Point(157, 285);
            this.btnDrawBars.Name = "btnDrawBars";
            this.btnDrawBars.Size = new System.Drawing.Size(162, 124);
            this.btnDrawBars.TabIndex = 11;
            this.btnDrawBars.Text = "Draw bars";
            this.btnDrawBars.UseVisualStyleBackColor = false;
            this.btnDrawBars.Click += new System.EventHandler(this.btnDrawBars_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.BackColor = System.Drawing.Color.Gray;
            this.btnBubbleSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubbleSort.ForeColor = System.Drawing.Color.Yellow;
            this.btnBubbleSort.Location = new System.Drawing.Point(26, 12);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(118, 81);
            this.btnBubbleSort.TabIndex = 12;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = false;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.BackColor = System.Drawing.Color.Gray;
            this.btnLinearSearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinearSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnLinearSearch.Location = new System.Drawing.Point(538, 12);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(118, 81);
            this.btnLinearSearch.TabIndex = 13;
            this.btnLinearSearch.Text = "Linear search";
            this.btnLinearSearch.UseVisualStyleBackColor = false;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // txtSearchData
            // 
            this.txtSearchData.BackColor = System.Drawing.Color.White;
            this.txtSearchData.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchData.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchData.Location = new System.Drawing.Point(565, 169);
            this.txtSearchData.Name = "txtSearchData";
            this.txtSearchData.Size = new System.Drawing.Size(100, 23);
            this.txtSearchData.TabIndex = 14;
            this.txtSearchData.TextChanged += new System.EventHandler(this.txtSearchData_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(459, 165);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 23);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search data:";
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.BackColor = System.Drawing.Color.Black;
            this.lblhelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhelp.ForeColor = System.Drawing.Color.Yellow;
            this.lblhelp.Location = new System.Drawing.Point(23, 126);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(428, 18);
            this.lblhelp.TabIndex = 16;
            this.lblhelp.Text = "Put your number in array size box and press start for a random array";
            this.lblhelp.Click += new System.EventHandler(this.lblhelp_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.BackColor = System.Drawing.Color.Gray;
            this.btnInsertionSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertionSort.ForeColor = System.Drawing.Color.Yellow;
            this.btnInsertionSort.Location = new System.Drawing.Point(150, 12);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(118, 81);
            this.btnInsertionSort.TabIndex = 17;
            this.btnInsertionSort.Text = "Insertion sort";
            this.btnInsertionSort.UseVisualStyleBackColor = false;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.BackColor = System.Drawing.Color.Gray;
            this.btnMergeSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeSort.ForeColor = System.Drawing.Color.Yellow;
            this.btnMergeSort.Location = new System.Drawing.Point(274, 12);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(118, 81);
            this.btnMergeSort.TabIndex = 18;
            this.btnMergeSort.Text = "Merge sort";
            this.btnMergeSort.UseVisualStyleBackColor = false;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.BackColor = System.Drawing.Color.Gray;
            this.btnQuickSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuickSort.Location = new System.Drawing.Point(398, 12);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(118, 81);
            this.btnQuickSort.TabIndex = 19;
            this.btnQuickSort.Text = "Quick sort";
            this.btnQuickSort.UseVisualStyleBackColor = false;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.BackColor = System.Drawing.Color.Gray;
            this.btnBinarySearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinarySearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnBinarySearch.Location = new System.Drawing.Point(662, 12);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(118, 81);
            this.btnBinarySearch.TabIndex = 20;
            this.btnBinarySearch.Text = "Binary search";
            this.btnBinarySearch.UseVisualStyleBackColor = false;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // lblShowSteps
            // 
            this.lblShowSteps.AutoSize = true;
            this.lblShowSteps.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSteps.ForeColor = System.Drawing.Color.Yellow;
            this.lblShowSteps.Location = new System.Drawing.Point(459, 202);
            this.lblShowSteps.Name = "lblShowSteps";
            this.lblShowSteps.Size = new System.Drawing.Size(100, 23);
            this.lblShowSteps.TabIndex = 22;
            this.lblShowSteps.Text = "Show steps?";
            this.lblShowSteps.Click += new System.EventHandler(this.lblShowSteps_Click);
            // 
            // chkShowSteps
            // 
            this.chkShowSteps.AutoSize = true;
            this.chkShowSteps.Location = new System.Drawing.Point(576, 209);
            this.chkShowSteps.Name = "chkShowSteps";
            this.chkShowSteps.Size = new System.Drawing.Size(80, 17);
            this.chkShowSteps.TabIndex = 23;
            this.chkShowSteps.Text = "checkBox1";
            this.chkShowSteps.UseVisualStyleBackColor = true;
            this.chkShowSteps.CheckedChanged += new System.EventHandler(this.chkShowSteps_CheckedChanged);
            // 
            // sortsAndSearches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkShowSteps);
            this.Controls.Add(this.lblShowSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchData);
            this.Controls.Add(this.btnLinearSearch);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnDrawBars);
            this.Controls.Add(this.btnArrayHelp);
            this.Controls.Add(this.lblArrayData);
            this.Controls.Add(this.lblArraySize);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "sortsAndSearches";
            this.Text = "Sorts and Searches";
            this.Load += new System.EventHandler(this.sortsAndSearches_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Label lblArraySize;
        private System.Windows.Forms.Label lblArrayData;
        private System.Windows.Forms.Button btnArrayHelp;
        private System.Windows.Forms.Button btnDrawBars;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.TextBox txtSearchData;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblhelp;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowSteps;
        private System.Windows.Forms.CheckBox chkShowSteps;
    }
}

