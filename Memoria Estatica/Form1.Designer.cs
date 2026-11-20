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
            tlpPrincipal = new TableLayoutPanel();
            gbStaticMemory = new GroupBox();
            tlpStatic = new TableLayoutPanel();
            lblInitialSize = new Label();
            nudStaticSize = new NumericUpDown();
            btnGenerateVector = new Button();
            lblNewSize = new Label();
            nudNewSize = new NumericUpDown();
            btnResizeVector = new Button();
            lblStaticInfo = new Label();
            lstVectorEstatico = new ListBox();
            gbDynamicMemory = new GroupBox();
            tlpDynamic = new TableLayoutPanel();
            lblObjectCount = new Label();
            nudDynamicCount = new NumericUpDown();
            btnCreateInstances = new Button();
            btnAddInstance = new Button();
            btnTestReference = new Button();
            btnReleaseAll = new Button();
            lblDynamicInfo = new Label();
            lstObjetosHeap = new ListBox();
            tlpBenchmark = new TableLayoutPanel();
            btnRunBenchmark = new Button();
            lblBenchmarkStatus = new Label();
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
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrincipal.Controls.Add(gbStaticMemory, 0, 0);
            tlpPrincipal.Controls.Add(gbDynamicMemory, 1, 0);
            tlpPrincipal.Controls.Add(tlpBenchmark, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(3, 4, 3, 4);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(11, 13, 11, 13);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.Size = new Size(1120, 827);
            tlpPrincipal.TabIndex = 0;
            // 
            // gbStaticMemory
            // 
            gbStaticMemory.Controls.Add(tlpStatic);
            gbStaticMemory.Dock = DockStyle.Fill;
            gbStaticMemory.Location = new Point(14, 17);
            gbStaticMemory.Margin = new Padding(3, 4, 3, 4);
            gbStaticMemory.Name = "gbStaticMemory";
            gbStaticMemory.Padding = new Padding(3, 4, 3, 4);
            gbStaticMemory.Size = new Size(543, 732);
            gbStaticMemory.TabIndex = 0;
            gbStaticMemory.TabStop = false;
            gbStaticMemory.Text = "Static Memory - Vectors and Resizing";
            // 
            // tlpStatic
            // 
            tlpStatic.ColumnCount = 3;
            tlpStatic.ColumnStyles.Add(new ColumnStyle());
            tlpStatic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpStatic.ColumnStyles.Add(new ColumnStyle());
            tlpStatic.Controls.Add(lblInitialSize, 0, 0);
            tlpStatic.Controls.Add(nudStaticSize, 1, 0);
            tlpStatic.Controls.Add(btnGenerateVector, 2, 0);
            tlpStatic.Controls.Add(lblNewSize, 0, 1);
            tlpStatic.Controls.Add(nudNewSize, 1, 1);
            tlpStatic.Controls.Add(btnResizeVector, 2, 1);
            tlpStatic.Controls.Add(lblStaticInfo, 0, 2);
            tlpStatic.Controls.Add(lstVectorEstatico, 0, 3);
            tlpStatic.Dock = DockStyle.Fill;
            tlpStatic.Location = new Point(3, 24);
            tlpStatic.Margin = new Padding(3, 4, 3, 4);
            tlpStatic.Name = "tlpStatic";
            tlpStatic.Padding = new Padding(7, 8, 7, 8);
            tlpStatic.RowCount = 4;
            tlpStatic.RowStyles.Add(new RowStyle());
            tlpStatic.RowStyles.Add(new RowStyle());
            tlpStatic.RowStyles.Add(new RowStyle());
            tlpStatic.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStatic.Size = new Size(537, 704);
            tlpStatic.TabIndex = 0;
            // 
            // lblInitialSize
            // 
            lblInitialSize.Anchor = AnchorStyles.Left;
            lblInitialSize.AutoSize = true;
            lblInitialSize.Location = new Point(10, 22);
            lblInitialSize.Name = "lblInitialSize";
            lblInitialSize.Size = new Size(78, 20);
            lblInitialSize.TabIndex = 0;
            lblInitialSize.Text = "Initial size:";
            // 
            // nudStaticSize
            // 
            nudStaticSize.Dock = DockStyle.Fill;
            nudStaticSize.Location = new Point(94, 12);
            nudStaticSize.Margin = new Padding(3, 4, 3, 4);
            nudStaticSize.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudStaticSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStaticSize.Name = "nudStaticSize";
            nudStaticSize.Size = new Size(284, 27);
            nudStaticSize.TabIndex = 1;
            nudStaticSize.ThousandsSeparator = true;
            nudStaticSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnGenerateVector
            // 
            btnGenerateVector.AutoSize = true;
            btnGenerateVector.Dock = DockStyle.Fill;
            btnGenerateVector.Location = new Point(384, 12);
            btnGenerateVector.Margin = new Padding(3, 4, 3, 4);
            btnGenerateVector.Name = "btnGenerateVector";
            btnGenerateVector.Size = new Size(143, 40);
            btnGenerateVector.TabIndex = 2;
            btnGenerateVector.Text = "Generate Vector";
            btnGenerateVector.UseVisualStyleBackColor = true;
            btnGenerateVector.Click += btnGenerateVector_Click;
            // 
            // lblNewSize
            // 
            lblNewSize.Anchor = AnchorStyles.Left;
            lblNewSize.AutoSize = true;
            lblNewSize.Location = new Point(10, 70);
            lblNewSize.Name = "lblNewSize";
            lblNewSize.Size = new Size(71, 20);
            lblNewSize.TabIndex = 3;
            lblNewSize.Text = "New size:";
            // 
            // nudNewSize
            // 
            nudNewSize.Dock = DockStyle.Fill;
            nudNewSize.Location = new Point(94, 60);
            nudNewSize.Margin = new Padding(3, 4, 3, 4);
            nudNewSize.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudNewSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNewSize.Name = "nudNewSize";
            nudNewSize.Size = new Size(284, 27);
            nudNewSize.TabIndex = 4;
            nudNewSize.ThousandsSeparator = true;
            nudNewSize.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnResizeVector
            // 
            btnResizeVector.AutoSize = true;
            btnResizeVector.Dock = DockStyle.Fill;
            btnResizeVector.Location = new Point(384, 60);
            btnResizeVector.Margin = new Padding(3, 4, 3, 4);
            btnResizeVector.Name = "btnResizeVector";
            btnResizeVector.Size = new Size(143, 40);
            btnResizeVector.TabIndex = 5;
            btnResizeVector.Text = "Resize";
            btnResizeVector.UseVisualStyleBackColor = true;
            btnResizeVector.Click += btnResizeVector_Click;
            // 
            // lblStaticInfo
            // 
            lblStaticInfo.AutoSize = true;
            tlpStatic.SetColumnSpan(lblStaticInfo, 3);
            lblStaticInfo.Dock = DockStyle.Fill;
            lblStaticInfo.Location = new Point(10, 109);
            lblStaticInfo.Margin = new Padding(3, 5, 3, 5);
            lblStaticInfo.Name = "lblStaticInfo";
            lblStaticInfo.Size = new Size(517, 20);
            lblStaticInfo.TabIndex = 6;
            lblStaticInfo.Text = "Status: No vector generated.";
            // 
            // lstVectorEstatico
            // 
            tlpStatic.SetColumnSpan(lstVectorEstatico, 3);
            lstVectorEstatico.Dock = DockStyle.Fill;
            lstVectorEstatico.FormattingEnabled = true;
            lstVectorEstatico.IntegralHeight = false;
            lstVectorEstatico.Location = new Point(10, 138);
            lstVectorEstatico.Margin = new Padding(3, 4, 3, 4);
            lstVectorEstatico.Name = "lstVectorEstatico";
            lstVectorEstatico.Size = new Size(517, 554);
            lstVectorEstatico.TabIndex = 7;
            // 
            // gbDynamicMemory
            // 
            gbDynamicMemory.Controls.Add(tlpDynamic);
            gbDynamicMemory.Dock = DockStyle.Fill;
            gbDynamicMemory.Location = new Point(563, 17);
            gbDynamicMemory.Margin = new Padding(3, 4, 3, 4);
            gbDynamicMemory.Name = "gbDynamicMemory";
            gbDynamicMemory.Padding = new Padding(3, 4, 3, 4);
            gbDynamicMemory.Size = new Size(543, 732);
            gbDynamicMemory.TabIndex = 1;
            gbDynamicMemory.TabStop = false;
            gbDynamicMemory.Text = "Dynamic Memory - Heap Instances";
            // 
            // tlpDynamic
            // 
            tlpDynamic.ColumnCount = 4;
            tlpDynamic.ColumnStyles.Add(new ColumnStyle());
            tlpDynamic.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDynamic.ColumnStyles.Add(new ColumnStyle());
            tlpDynamic.ColumnStyles.Add(new ColumnStyle());
            tlpDynamic.Controls.Add(lblObjectCount, 0, 0);
            tlpDynamic.Controls.Add(nudDynamicCount, 1, 0);
            tlpDynamic.Controls.Add(btnCreateInstances, 2, 0);
            tlpDynamic.Controls.Add(btnAddInstance, 3, 0);
            tlpDynamic.Controls.Add(btnTestReference, 0, 1);
            tlpDynamic.Controls.Add(btnReleaseAll, 2, 1);
            tlpDynamic.Controls.Add(lblDynamicInfo, 0, 2);
            tlpDynamic.Controls.Add(lstObjetosHeap, 0, 3);
            tlpDynamic.Dock = DockStyle.Fill;
            tlpDynamic.Location = new Point(3, 24);
            tlpDynamic.Margin = new Padding(3, 4, 3, 4);
            tlpDynamic.Name = "tlpDynamic";
            tlpDynamic.Padding = new Padding(7, 8, 7, 8);
            tlpDynamic.RowCount = 4;
            tlpDynamic.RowStyles.Add(new RowStyle());
            tlpDynamic.RowStyles.Add(new RowStyle());
            tlpDynamic.RowStyles.Add(new RowStyle());
            tlpDynamic.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDynamic.Size = new Size(537, 704);
            tlpDynamic.TabIndex = 0;
            // 
            // lblObjectCount
            // 
            lblObjectCount.Anchor = AnchorStyles.Left;
            lblObjectCount.AutoSize = true;
            lblObjectCount.Location = new Point(10, 22);
            lblObjectCount.Name = "lblObjectCount";
            lblObjectCount.Size = new Size(51, 20);
            lblObjectCount.TabIndex = 0;
            lblObjectCount.Text = "Count:";
            // 
            // nudDynamicCount
            // 
            nudDynamicCount.Dock = DockStyle.Fill;
            nudDynamicCount.Location = new Point(67, 12);
            nudDynamicCount.Margin = new Padding(3, 4, 3, 4);
            nudDynamicCount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nudDynamicCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDynamicCount.Name = "nudDynamicCount";
            nudDynamicCount.Size = new Size(223, 27);
            nudDynamicCount.TabIndex = 1;
            nudDynamicCount.ThousandsSeparator = true;
            nudDynamicCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnCreateInstances
            // 
            btnCreateInstances.AutoSize = true;
            btnCreateInstances.Dock = DockStyle.Fill;
            btnCreateInstances.Location = new Point(296, 12);
            btnCreateInstances.Margin = new Padding(3, 4, 3, 4);
            btnCreateInstances.Name = "btnCreateInstances";
            btnCreateInstances.Size = new Size(144, 40);
            btnCreateInstances.TabIndex = 2;
            btnCreateInstances.Text = "Create Instances";
            btnCreateInstances.UseVisualStyleBackColor = true;
            btnCreateInstances.Click += btnCreateInstances_Click;
            // 
            // btnAddInstance
            // 
            btnAddInstance.AutoSize = true;
            btnAddInstance.Dock = DockStyle.Fill;
            btnAddInstance.Location = new Point(446, 12);
            btnAddInstance.Margin = new Padding(3, 4, 3, 4);
            btnAddInstance.Name = "btnAddInstance";
            btnAddInstance.Size = new Size(81, 40);
            btnAddInstance.TabIndex = 3;
            btnAddInstance.Text = "Add +1";
            btnAddInstance.UseVisualStyleBackColor = true;
            btnAddInstance.Click += btnAddInstance_Click;
            // 
            // btnTestReference
            // 
            btnTestReference.AutoSize = true;
            tlpDynamic.SetColumnSpan(btnTestReference, 2);
            btnTestReference.Dock = DockStyle.Fill;
            btnTestReference.Location = new Point(10, 60);
            btnTestReference.Margin = new Padding(3, 4, 3, 4);
            btnTestReference.Name = "btnTestReference";
            btnTestReference.Size = new Size(280, 40);
            btnTestReference.TabIndex = 4;
            btnTestReference.Text = "Test Heap Reference";
            btnTestReference.UseVisualStyleBackColor = true;
            btnTestReference.Click += btnTestReference_Click;
            // 
            // btnReleaseAll
            // 
            btnReleaseAll.AutoSize = true;
            tlpDynamic.SetColumnSpan(btnReleaseAll, 2);
            btnReleaseAll.Dock = DockStyle.Fill;
            btnReleaseAll.Location = new Point(296, 60);
            btnReleaseAll.Margin = new Padding(3, 4, 3, 4);
            btnReleaseAll.Name = "btnReleaseAll";
            btnReleaseAll.Size = new Size(231, 40);
            btnReleaseAll.TabIndex = 5;
            btnReleaseAll.Text = "Release and Run GC";
            btnReleaseAll.UseVisualStyleBackColor = true;
            btnReleaseAll.Click += btnReleaseAll_Click;
            // 
            // lblDynamicInfo
            // 
            lblDynamicInfo.AutoSize = true;
            tlpDynamic.SetColumnSpan(lblDynamicInfo, 4);
            lblDynamicInfo.Dock = DockStyle.Fill;
            lblDynamicInfo.Location = new Point(10, 109);
            lblDynamicInfo.Margin = new Padding(3, 5, 3, 5);
            lblDynamicInfo.Name = "lblDynamicInfo";
            lblDynamicInfo.Size = new Size(517, 20);
            lblDynamicInfo.TabIndex = 6;
            lblDynamicInfo.Text = "Status: No active Heap instances.";
            // 
            // lstObjetosHeap
            // 
            tlpDynamic.SetColumnSpan(lstObjetosHeap, 4);
            lstObjetosHeap.Dock = DockStyle.Fill;
            lstObjetosHeap.FormattingEnabled = true;
            lstObjetosHeap.IntegralHeight = false;
            lstObjetosHeap.Location = new Point(10, 138);
            lstObjetosHeap.Margin = new Padding(3, 4, 3, 4);
            lstObjetosHeap.Name = "lstObjetosHeap";
            lstObjetosHeap.Size = new Size(517, 554);
            lstObjetosHeap.TabIndex = 7;
            // 
            // tlpBenchmark
            // 
            tlpBenchmark.AutoSize = true;
            tlpBenchmark.ColumnCount = 2;
            tlpPrincipal.SetColumnSpan(tlpBenchmark, 2);
            tlpBenchmark.ColumnStyles.Add(new ColumnStyle());
            tlpBenchmark.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBenchmark.Controls.Add(btnRunBenchmark, 0, 0);
            tlpBenchmark.Controls.Add(lblBenchmarkStatus, 1, 0);
            tlpBenchmark.Dock = DockStyle.Fill;
            tlpBenchmark.Location = new Point(14, 757);
            tlpBenchmark.Margin = new Padding(3, 4, 3, 4);
            tlpBenchmark.Name = "tlpBenchmark";
            tlpBenchmark.Padding = new Padding(0, 5, 0, 0);
            tlpBenchmark.RowCount = 1;
            tlpBenchmark.RowStyles.Add(new RowStyle());
            tlpBenchmark.Size = new Size(1092, 53);
            tlpBenchmark.TabIndex = 2;
            // 
            // btnRunBenchmark
            // 
            btnRunBenchmark.AutoSize = true;
            btnRunBenchmark.Location = new Point(3, 9);
            btnRunBenchmark.Margin = new Padding(3, 4, 3, 4);
            btnRunBenchmark.Name = "btnRunBenchmark";
            btnRunBenchmark.Size = new Size(278, 40);
            btnRunBenchmark.TabIndex = 0;
            btnRunBenchmark.Text = "Run 100,000-Element Comparison";
            btnRunBenchmark.UseVisualStyleBackColor = true;
            btnRunBenchmark.Click += btnRunBenchmark_Click;
            // 
            // lblBenchmarkStatus
            // 
            lblBenchmarkStatus.Dock = DockStyle.Fill;
            lblBenchmarkStatus.Location = new Point(287, 5);
            lblBenchmarkStatus.Name = "lblBenchmarkStatus";
            lblBenchmarkStatus.Size = new Size(802, 48);
            lblBenchmarkStatus.TabIndex = 1;
            lblBenchmarkStatus.Text = "Ready to run clean 100,000-element comparison.";
            lblBenchmarkStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 827);
            Controls.Add(tlpPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1003, 704);
            Name = "Form1";
            Text = "Practice: Static Memory vs. Dynamic Memory";
            WindowState = FormWindowState.Maximized;
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
