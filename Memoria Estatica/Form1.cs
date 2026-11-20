namespace Memoria_Estatica
{
    public partial class Form1 : Form
    {
        private readonly StaticMemoryManager _staticManager = new();
        private readonly DynamicMemoryManager _dynamicManager = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateVector_Click(object? sender, EventArgs e)
        {
            int size = (int)nudStaticSize.Value;
            StaticMemoryResult result = _staticManager.GenerateVector(size);

            lblStaticInfo.Text =
                $"Size: {result.CurrentSize:N0} | Memory: {result.EstimatedMemoryBytes:N0} B | " +
                $"Time: {result.ElapsedMilliseconds:F4} ms | Block Ref: 0x{result.BlockReferenceCode:X8}";

            UpdateList(lstVectorEstatico, _staticManager.GetPreview());
        }

        private void btnResizeVector_Click(object? sender, EventArgs e)
        {
            int newSize = (int)nudNewSize.Value;
            StaticMemoryResult result = _staticManager.ResizeVector(newSize);
            string blockState = result.BlockReallocated ? "New contiguous block" : "Same block";

            lblStaticInfo.Text =
                $"Size: {result.CurrentSize:N0} | Memory: {result.EstimatedMemoryBytes:N0} B | " +
                $"Time: {result.ElapsedMilliseconds:F4} ms | Ref: 0x{result.BlockReferenceCode:X8} ({blockState})";

            UpdateList(lstVectorEstatico, _staticManager.GetPreview());
        }

        private void btnCreateInstances_Click(object? sender, EventArgs e)
        {
            int count = (int)nudDynamicCount.Value;
            DynamicMemoryResult result = _dynamicManager.CreateInstances(count);

            lblDynamicInfo.Text =
                $"Instances: {result.ActiveInstances:N0} | Heap: {result.HeapMemoryBytes:N0} B | " +
                $"Time: {result.ElapsedMilliseconds:F4} ms";

            UpdateList(lstObjetosHeap, _dynamicManager.GetPreview());
        }

        private void btnAddInstance_Click(object? sender, EventArgs e)
        {
            DynamicMemoryResult result = _dynamicManager.AddInstance();

            lblDynamicInfo.Text =
                $"Instances: {result.ActiveInstances:N0} | Heap: {result.HeapMemoryBytes:N0} B | " +
                $"Time: {result.ElapsedMilliseconds:F4} ms";

            UpdateList(lstObjetosHeap, _dynamicManager.GetPreview());
        }

        private void btnTestReference_Click(object? sender, EventArgs e)
        {
            int selectedIndex = lstObjetosHeap.SelectedIndex >= 0 ? lstObjetosHeap.SelectedIndex : 0;
            DynamicMemoryResult result = _dynamicManager.TestReference(selectedIndex);

            lblDynamicInfo.Text = result.Message;
            UpdateList(lstObjetosHeap, _dynamicManager.GetPreview());
        }

        private void btnReleaseAll_Click(object? sender, EventArgs e)
        {
            DynamicMemoryResult result = _dynamicManager.ReleaseAllAndCollect();

            lblDynamicInfo.Text = result.Message;
            UpdateList(lstObjetosHeap, _dynamicManager.GetPreview());
        }

        private async void btnRunBenchmark_Click(object? sender, EventArgs e)
        {
            const int staticInitialElements = 50000;
            const int benchmarkElements = 100000;

            SetBenchmarkControlsEnabled(false);

            _staticManager.Clear();
            _dynamicManager.ReleaseAllAndCollect();
            lstVectorEstatico.Items.Clear();
            lstObjetosHeap.Items.Clear();

            lblStaticInfo.Text = "Status: Running 100,000-element static benchmark...";
            lblDynamicInfo.Text = "Status: Running 100,000-element dynamic benchmark...";
            lblBenchmarkStatus.Text = "Running clean 100,000-element comparison...";

            try
            {
                StaticMemoryResult staticResult =
                    await _staticManager.RunBenchmarkAsync(staticInitialElements, benchmarkElements);

                DynamicMemoryResult dynamicResult =
                    await _dynamicManager.RunBenchmarkAsync(benchmarkElements, 256);

                lblStaticInfo.Text =
                    $"Benchmark (50k->100k): {staticResult.CurrentSize:N0} | Memory: {staticResult.EstimatedMemoryBytes:N0} B | " +
                    $"Time: {staticResult.ElapsedMilliseconds:F4} ms | Ref: 0x{staticResult.BlockReferenceCode:X8}";

                lblDynamicInfo.Text =
                    $"Benchmark (100k): {dynamicResult.ActiveInstances:N0} | Heap Delta: {dynamicResult.MemoryDeltaBytes:N0} B | " +
                    $"Time: {dynamicResult.ElapsedMilliseconds:F4} ms";

                UpdateList(lstVectorEstatico, _staticManager.GetPreview());
                UpdateList(lstObjetosHeap, _dynamicManager.GetPreview());

                lblBenchmarkStatus.Text =
                    $"Comparison finished. Static (100k): {staticResult.ElapsedMilliseconds:F3} ms | " +
                    $"Dynamic (100k): {dynamicResult.ElapsedMilliseconds:F3} ms";
            }
            finally
            {
                SetBenchmarkControlsEnabled(true);
            }
        }

        private void SetBenchmarkControlsEnabled(bool enabled)
        {
            btnRunBenchmark.Enabled = enabled;
            btnGenerateVector.Enabled = enabled;
            btnResizeVector.Enabled = enabled;
            btnCreateInstances.Enabled = enabled;
            btnAddInstance.Enabled = enabled;
            btnTestReference.Enabled = enabled;
            btnReleaseAll.Enabled = enabled;
        }

        private static void UpdateList(ListBox listBox, IReadOnlyList<string> items)
        {
            listBox.BeginUpdate();
            try
            {
                listBox.Items.Clear();
                foreach (string item in items)
                {
                    listBox.Items.Add(item);
                }
            }
            finally
            {
                listBox.EndUpdate();
            }
        }
    }
}
