namespace Memoria_Estatica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.GroupBox gbStaticMemory;
        private System.Windows.Forms.TableLayoutPanel tlpStatic;
        private System.Windows.Forms.Label lblInitialSize;
        private System.Windows.Forms.NumericUpDown nudStaticSize;
        private System.Windows.Forms.Button btnGenerateVector;
        private System.Windows.Forms.Label lblNewSize;
        private System.Windows.Forms.NumericUpDown nudNewSize;
        private System.Windows.Forms.Button btnResizeVector;
        private System.Windows.Forms.Label lblStaticInfo;
        private System.Windows.Forms.ListBox lstVectorEstatico;

        private System.Windows.Forms.GroupBox gbDynamicMemory;
        private System.Windows.Forms.TableLayoutPanel tlpDynamic;
        private System.Windows.Forms.Label lblObjectCount;
        private System.Windows.Forms.NumericUpDown nudDynamicCount;
        private System.Windows.Forms.Button btnCreateInstances;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.Button btnTestReference;
        private System.Windows.Forms.Button btnReleaseAll;
        private System.Windows.Forms.Label lblDynamicInfo;
        private System.Windows.Forms.ListBox lstObjetosHeap;

        private System.Windows.Forms.TableLayoutPanel tlpBenchmark;
        private System.Windows.Forms.Button btnRunBenchmark;
        private System.Windows.Forms.Label lblBenchmarkStatus;

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
            tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            gbStaticMemory = new System.Windows.Forms.GroupBox();
            tlpStatic = new System.Windows.Forms.TableLayoutPanel();
            lblInitialSize = new System.Windows.Forms.Label();
            nudStaticSize = new System.Windows.Forms.NumericUpDown();
            btnGenerateVector = new System.Windows.Forms.Button();
            lblNewSize = new System.Windows.Forms.Label();
            nudNewSize = new System.Windows.Forms.NumericUpDown();
            btnResizeVector = new System.Windows.Forms.Button();
            lblStaticInfo = new System.Windows.Forms.Label();
            lstVectorEstatico = new System.Windows.Forms.ListBox();
            gbDynamicMemory = new System.Windows.Forms.GroupBox();
            tlpDynamic = new System.Windows.Forms.TableLayoutPanel();
            lblObjectCount = new System.Windows.Forms.Label();
            nudDynamicCount = new System.Windows.Forms.NumericUpDown();
            btnCreateInstances = new System.Windows.Forms.Button();
            btnAddInstance = new System.Windows.Forms.Button();
            btnTestReference = new System.Windows.Forms.Button();
            btnReleaseAll = new System.Windows.Forms.Button();
            lblDynamicInfo = new System.Windows.Forms.Label();
            lstObjetosHeap = new System.Windows.Forms.ListBox();
            tlpBenchmark = new System.Windows.Forms.TableLayoutPanel();
            btnRunBenchmark = new System.Windows.Forms.Button();
            lblBenchmarkStatus = new System.Windows.Forms.Label();

            tlpPrincipal.SuspendLayout();
            gbStaticMemory.SuspendLayout();
            tlpStatic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStaticSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewSize).BeginInit();
            gbDynamicMemory.SuspendLayout();
            tlpDynamic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDynamicCount).BeginInit();
            tlpBenchmark.SuspendLayout();
            SuspendLayout();

            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPrincipal.Controls.Add(gbStaticMemory, 0, 0);
            tlpPrincipal.Controls.Add(gbDynamicMemory, 1, 0);
            tlpPrincipal.Controls.Add(tlpBenchmark, 0, 1);
            tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new System.Windows.Forms.Padding(10);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpPrincipal.Size = new System.Drawing.Size(980, 620);
            tlpPrincipal.TabIndex = 0;

            // 
            // gbStaticMemory
            // 
            gbStaticMemory.Controls.Add(tlpStatic);
            gbStaticMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            gbStaticMemory.Location = new System.Drawing.Point(13, 13);
            gbStaticMemory.Name = "gbStaticMemory";
            gbStaticMemory.Size = new System.Drawing.Size(474, 550);
            gbStaticMemory.TabIndex = 0;
            gbStaticMemory.TabStop = false;
            gbStaticMemory.Text = "Static Memory - Vectors and Resizing";

            // 
            // tlpStatic
            // 
            tlpStatic.ColumnCount = 3;
            tlpStatic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpStatic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpStatic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpStatic.Controls.Add(lblInitialSize, 0, 0);
            tlpStatic.Controls.Add(nudStaticSize, 1, 0);
            tlpStatic.Controls.Add(btnGenerateVector, 2, 0);
            tlpStatic.Controls.Add(lblNewSize, 0, 1);
            tlpStatic.Controls.Add(nudNewSize, 1, 1);
            tlpStatic.Controls.Add(btnResizeVector, 2, 1);
            tlpStatic.Controls.Add(lblStaticInfo, 0, 2);
            tlpStatic.Controls.Add(lstVectorEstatico, 0, 3);
            tlpStatic.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpStatic.Location = new System.Drawing.Point(3, 19);
            tlpStatic.Name = "tlpStatic";
            tlpStatic.Padding = new System.Windows.Forms.Padding(6);
            tlpStatic.RowCount = 4;
            tlpStatic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpStatic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpStatic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpStatic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpStatic.Size = new System.Drawing.Size(468, 528);
            tlpStatic.TabIndex = 0;

            // 
            // lblInitialSize
            // 
            lblInitialSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblInitialSize.AutoSize = true;
            lblInitialSize.Location = new System.Drawing.Point(9, 13);
            lblInitialSize.Name = "lblInitialSize";
            lblInitialSize.Size = new System.Drawing.Size(65, 15);
            lblInitialSize.TabIndex = 0;
            lblInitialSize.Text = "Initial size:";

            // 
            // nudStaticSize
            // 
            nudStaticSize.Dock = System.Windows.Forms.DockStyle.Fill;
            nudStaticSize.Location = new System.Drawing.Point(80, 9);
            nudStaticSize.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudStaticSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStaticSize.Name = "nudStaticSize";
            nudStaticSize.Size = new System.Drawing.Size(262, 23);
            nudStaticSize.TabIndex = 1;
            nudStaticSize.ThousandsSeparator = true;
            nudStaticSize.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // 
            // btnGenerateVector
            // 
            btnGenerateVector.AutoSize = true;
            btnGenerateVector.Dock = System.Windows.Forms.DockStyle.Fill;
            btnGenerateVector.Location = new System.Drawing.Point(348, 9);
            btnGenerateVector.Name = "btnGenerateVector";
            btnGenerateVector.Size = new System.Drawing.Size(111, 25);
            btnGenerateVector.TabIndex = 2;
            btnGenerateVector.Text = "Generate Vector";
            btnGenerateVector.UseVisualStyleBackColor = true;
            btnGenerateVector.Click += btnGenerateVector_Click;

            // 
            // lblNewSize
            // 
            lblNewSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblNewSize.AutoSize = true;
            lblNewSize.Location = new System.Drawing.Point(9, 44);
            lblNewSize.Name = "lblNewSize";
            lblNewSize.Size = new System.Drawing.Size(57, 15);
            lblNewSize.TabIndex = 3;
            lblNewSize.Text = "New size:";

            // 
            // nudNewSize
            // 
            nudNewSize.Dock = System.Windows.Forms.DockStyle.Fill;
            nudNewSize.Location = new System.Drawing.Point(80, 40);
            nudNewSize.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudNewSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNewSize.Name = "nudNewSize";
            nudNewSize.Size = new System.Drawing.Size(262, 23);
            nudNewSize.TabIndex = 4;
            nudNewSize.ThousandsSeparator = true;
            nudNewSize.Value = new decimal(new int[] { 20, 0, 0, 0 });

            // 
            // btnResizeVector
            // 
            btnResizeVector.AutoSize = true;
            btnResizeVector.Dock = System.Windows.Forms.DockStyle.Fill;
            btnResizeVector.Location = new System.Drawing.Point(348, 40);
            btnResizeVector.Name = "btnResizeVector";
            btnResizeVector.Size = new System.Drawing.Size(111, 25);
            btnResizeVector.TabIndex = 5;
            btnResizeVector.Text = "Resize";
            btnResizeVector.UseVisualStyleBackColor = true;
            btnResizeVector.Click += btnResizeVector_Click;

            // 
            // lblStaticInfo
            // 
            lblStaticInfo.AutoSize = true;
            tlpStatic.SetColumnSpan(lblStaticInfo, 3);
            lblStaticInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStaticInfo.Location = new System.Drawing.Point(9, 71);
            lblStaticInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblStaticInfo.Name = "lblStaticInfo";
            lblStaticInfo.Size = new System.Drawing.Size(450, 15);
            lblStaticInfo.TabIndex = 6;
            lblStaticInfo.Text = "Status: No vector generated.";

            // 
            // lstVectorEstatico
            // 
            tlpStatic.SetColumnSpan(lstVectorEstatico, 3);
            lstVectorEstatico.Dock = System.Windows.Forms.DockStyle.Fill;
            lstVectorEstatico.FormattingEnabled = true;
            lstVectorEstatico.IntegralHeight = false;
            lstVectorEstatico.Location = new System.Drawing.Point(9, 93);
            lstVectorEstatico.Name = "lstVectorEstatico";
            lstVectorEstatico.Size = new System.Drawing.Size(450, 426);
            lstVectorEstatico.TabIndex = 7;

            // 
            // gbDynamicMemory
            // 
            gbDynamicMemory.Controls.Add(tlpDynamic);
            gbDynamicMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            gbDynamicMemory.Location = new System.Drawing.Point(493, 13);
            gbDynamicMemory.Name = "gbDynamicMemory";
            gbDynamicMemory.Size = new System.Drawing.Size(474, 550);
            gbDynamicMemory.TabIndex = 1;
            gbDynamicMemory.TabStop = false;
            gbDynamicMemory.Text = "Dynamic Memory - Heap Instances";

            // 
            // tlpDynamic
            // 
            tlpDynamic.ColumnCount = 4;
            tlpDynamic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDynamic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.Controls.Add(lblObjectCount, 0, 0);
            tlpDynamic.Controls.Add(nudDynamicCount, 1, 0);
            tlpDynamic.Controls.Add(btnCreateInstances, 2, 0);
            tlpDynamic.Controls.Add(btnAddInstance, 3, 0);
            tlpDynamic.Controls.Add(btnTestReference, 0, 1);
            tlpDynamic.Controls.Add(btnReleaseAll, 2, 1);
            tlpDynamic.Controls.Add(lblDynamicInfo, 0, 2);
            tlpDynamic.Controls.Add(lstObjetosHeap, 0, 3);
            tlpDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpDynamic.Location = new System.Drawing.Point(3, 19);
            tlpDynamic.Name = "tlpDynamic";
            tlpDynamic.Padding = new System.Windows.Forms.Padding(6);
            tlpDynamic.RowCount = 4;
            tlpDynamic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpDynamic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDynamic.Size = new System.Drawing.Size(468, 528);
            tlpDynamic.TabIndex = 0;

            // 
            // lblObjectCount
            // 
            lblObjectCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblObjectCount.AutoSize = true;
            lblObjectCount.Location = new System.Drawing.Point(9, 13);
            lblObjectCount.Name = "lblObjectCount";
            lblObjectCount.Size = new System.Drawing.Size(43, 15);
            lblObjectCount.TabIndex = 0;
            lblObjectCount.Text = "Count:";

            // 
            // nudDynamicCount
            // 
            nudDynamicCount.Dock = System.Windows.Forms.DockStyle.Fill;
            nudDynamicCount.Location = new System.Drawing.Point(58, 9);
            nudDynamicCount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudDynamicCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDynamicCount.Name = "nudDynamicCount";
            nudDynamicCount.Size = new System.Drawing.Size(212, 23);
            nudDynamicCount.TabIndex = 1;
            nudDynamicCount.ThousandsSeparator = true;
            nudDynamicCount.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // 
            // btnCreateInstances
            // 
            btnCreateInstances.AutoSize = true;
            btnCreateInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            btnCreateInstances.Location = new System.Drawing.Point(276, 9);
            btnCreateInstances.Name = "btnCreateInstances";
            btnCreateInstances.Size = new System.Drawing.Size(107, 25);
            btnCreateInstances.TabIndex = 2;
            btnCreateInstances.Text = "Create Instances";
            btnCreateInstances.UseVisualStyleBackColor = true;
            btnCreateInstances.Click += btnCreateInstances_Click;

            // 
            // btnAddInstance
            // 
            btnAddInstance.AutoSize = true;
            btnAddInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAddInstance.Location = new System.Drawing.Point(389, 9);
            btnAddInstance.Name = "btnAddInstance";
            btnAddInstance.Size = new System.Drawing.Size(70, 25);
            btnAddInstance.TabIndex = 3;
            btnAddInstance.Text = "Add +1";
            btnAddInstance.UseVisualStyleBackColor = true;
            btnAddInstance.Click += btnAddInstance_Click;

            // 
            // btnTestReference
            // 
            btnTestReference.AutoSize = true;
            tlpDynamic.SetColumnSpan(btnTestReference, 2);
            btnTestReference.Dock = System.Windows.Forms.DockStyle.Fill;
            btnTestReference.Location = new System.Drawing.Point(9, 40);
            btnTestReference.Name = "btnTestReference";
            btnTestReference.Size = new System.Drawing.Size(261, 25);
            btnTestReference.TabIndex = 4;
            btnTestReference.Text = "Test Heap Reference";
            btnTestReference.UseVisualStyleBackColor = true;
            btnTestReference.Click += btnTestReference_Click;

            // 
            // btnReleaseAll
            // 
            btnReleaseAll.AutoSize = true;
            tlpDynamic.SetColumnSpan(btnReleaseAll, 2);
            btnReleaseAll.Dock = System.Windows.Forms.DockStyle.Fill;
            btnReleaseAll.Location = new System.Drawing.Point(276, 40);
            btnReleaseAll.Name = "btnReleaseAll";
            btnReleaseAll.Size = new System.Drawing.Size(183, 25);
            btnReleaseAll.TabIndex = 5;
            btnReleaseAll.Text = "Release and Run GC";
            btnReleaseAll.UseVisualStyleBackColor = true;
            btnReleaseAll.Click += btnReleaseAll_Click;

            // 
            // lblDynamicInfo
            // 
            lblDynamicInfo.AutoSize = true;
            tlpDynamic.SetColumnSpan(lblDynamicInfo, 4);
            lblDynamicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDynamicInfo.Location = new System.Drawing.Point(9, 71);
            lblDynamicInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lblDynamicInfo.Name = "lblDynamicInfo";
            lblDynamicInfo.Size = new System.Drawing.Size(450, 15);
            lblDynamicInfo.TabIndex = 6;
            lblDynamicInfo.Text = "Status: No active Heap instances.";

            // 
            // lstObjetosHeap
            // 
            tlpDynamic.SetColumnSpan(lstObjetosHeap, 4);
            lstObjetosHeap.Dock = System.Windows.Forms.DockStyle.Fill;
            lstObjetosHeap.FormattingEnabled = true;
            lstObjetosHeap.IntegralHeight = false;
            lstObjetosHeap.Location = new System.Drawing.Point(9, 93);
            lstObjetosHeap.Name = "lstObjetosHeap";
            lstObjetosHeap.Size = new System.Drawing.Size(450, 426);
            lstObjetosHeap.TabIndex = 7;

            // 
            // tlpBenchmark
            // 
            tlpBenchmark.AutoSize = true;
            tlpBenchmark.ColumnCount = 2;
            tlpPrincipal.SetColumnSpan(tlpBenchmark, 2);
            tlpBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpBenchmark.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBenchmark.Controls.Add(btnRunBenchmark, 0, 0);
            tlpBenchmark.Controls.Add(lblBenchmarkStatus, 1, 0);
            tlpBenchmark.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBenchmark.Location = new System.Drawing.Point(13, 569);
            tlpBenchmark.Name = "tlpBenchmark";
            tlpBenchmark.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            tlpBenchmark.RowCount = 1;
            tlpBenchmark.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tlpBenchmark.Size = new System.Drawing.Size(954, 38);
            tlpBenchmark.TabIndex = 2;

            // 
            // btnRunBenchmark
            // 
            btnRunBenchmark.AutoSize = true;
            btnRunBenchmark.Location = new System.Drawing.Point(3, 7);
            btnRunBenchmark.Name = "btnRunBenchmark";
            btnRunBenchmark.Size = new System.Drawing.Size(235, 25);
            btnRunBenchmark.TabIndex = 0;
            btnRunBenchmark.Text = "Run 100,000-Element Comparison";
            btnRunBenchmark.UseVisualStyleBackColor = true;
            btnRunBenchmark.Click += btnRunBenchmark_Click;

            // 
            // lblBenchmarkStatus
            // 
            lblBenchmarkStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBenchmarkStatus.Location = new System.Drawing.Point(244, 4);
            lblBenchmarkStatus.Name = "lblBenchmarkStatus";
            lblBenchmarkStatus.Size = new System.Drawing.Size(707, 34);
            lblBenchmarkStatus.TabIndex = 1;
            lblBenchmarkStatus.Text = "Ready to run clean 100,000-element comparison.";
            lblBenchmarkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(980, 620);
            Controls.Add(tlpPrincipal);
            MinimumSize = new System.Drawing.Size(880, 540);
            Name = "Form1";
            Text = "Practice: Static Memory vs. Dynamic Memory";
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            gbStaticMemory.ResumeLayout(false);
            tlpStatic.ResumeLayout(false);
            tlpStatic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStaticSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewSize).EndInit();
            gbDynamicMemory.ResumeLayout(false);
            tlpDynamic.ResumeLayout(false);
            tlpDynamic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDynamicCount).EndInit();
            tlpBenchmark.ResumeLayout(false);
            tlpBenchmark.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
