namespace SIAOD_18_19_20;

public partial class Form1 : Form
{
    private const int DATAGRID1_3_ROWS = 1;
    private const int DATAGRID2_ROWS = 4;
    private const int DATAGRID_COLUMNS = 15;
    private const int WIDTH = 50;
    private const int HEIGHT = 30;
    private const int MAX_ELEMENTS = 15;


    private int[] A;
    private Random rnd;
    
    public Form1()
    {
        InitializeComponent();
     
        dataGridView1.ColumnHeadersVisible = false;
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.RowCount = DATAGRID1_3_ROWS;
        dataGridView1.ColumnCount = DATAGRID_COLUMNS;

        dataGridView1.ScrollBars = ScrollBars.None;
        
        dataGridView1.ReadOnly = true;
        dataGridView1.Rows[0].Height = HEIGHT;
        for (int i = 0; i < DATAGRID_COLUMNS; i++)
        {
            dataGridView1.Columns[i].Width = WIDTH;
        }
        
        dataGridView2.ColumnHeadersVisible = false;
        dataGridView2.RowHeadersVisible = false;
        dataGridView2.RowCount = DATAGRID2_ROWS;
        dataGridView2.ColumnCount = DATAGRID_COLUMNS;
        dataGridView2.ScrollBars = ScrollBars.None;
        dataGridView2.ReadOnly = true;
        for (int i = 0; i < DATAGRID_COLUMNS; i++)
        {
            dataGridView2.Columns[i].Width = WIDTH;
        }
        for (int i = 0; i < DATAGRID2_ROWS; i++)
        {
            dataGridView2.Rows[i].Height = HEIGHT;
        }

        dataGridView3.ColumnHeadersVisible = false;
        dataGridView3.RowHeadersVisible = false;
        dataGridView3.RowCount = DATAGRID1_3_ROWS;
        dataGridView3.ColumnCount = DATAGRID_COLUMNS;
        dataGridView3.ScrollBars = ScrollBars.None;
        dataGridView3.ReadOnly = true;
        dataGridView3.Rows[0].Height = HEIGHT;
        for (int i = 0; i < DATAGRID_COLUMNS; i++)
        {
            dataGridView3.Columns[i].Width = WIDTH;
        }
        
        A = new int[MAX_ELEMENTS];
        rnd = new Random();
    }

    private void exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void createQueue_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < MAX_ELEMENTS; i++)
        {
            A[i] = rnd.Next(10, 100);
        }

        clearTabs();
        ShowArrayAndQueue();
    }

    private void ShowArrayAndQueue()
    {
        for (int i = 0; i < MAX_ELEMENTS; i++)
        {
            dataGridView1.Rows[0].Cells[i].Value = A[i];
        }
        Print();
    }
    
    private void Print()
    {
        int index = 0;
        for (int level = 0; level < 4; level++)
        {
            int elements = (int)Math.Pow(2, level);
            int step = 8 >> level;
            int col = step - 1;

            for (int i = 0; i < elements && index < 15; i++)
            {
                if (A[index] != 0)
                    dataGridView2.Rows[level].Cells[col].Value = A[index];

                col += step * 2;
                index++;
            }
        }
    }

    private void getMax_Click(object sender, EventArgs e)
    {
        int last = findLastIndexElement();
        if (last < 0) return;

        int max = A[0];

        for (int i = 0; i < MAX_ELEMENTS; i++)
        {
            if (dataGridView3.Rows[0].Cells[i].Value == null)
            {
                dataGridView3.Rows[0].Cells[i].Value = max;
                break;
            }
        }

        A[0] = A[last];
        A[last] = 0;

        clearTabs();
        ShowArrayAndQueue();
    }

    private int findLastIndexElement()
    {
        for (int i = MAX_ELEMENTS-1; i >= 0; i--)
        {
            if (A[i] == 0)
                continue;
            return i;
        }

        return -1;
    }

    private void clearTabs()
    {
        for (int r = 0; r < DATAGRID2_ROWS; r++)
            for (int c = 0; c < DATAGRID_COLUMNS; c++)
                dataGridView2.Rows[r].Cells[c].Value = null;
    }

    private void clearQueue_Click(object sender, EventArgs e)
    {
        clearTabs();
        for (int i = 0; i < MAX_ELEMENTS; i++)
            dataGridView3.Rows[0].Cells[i].Value = null;
        for (int i = 0; i < MAX_ELEMENTS; i++)
            dataGridView1.Rows[0].Cells[i].Value = null;
    }

    private void addNew_Click(object sender, EventArgs e)
    {
        int lastIndex = findLastIndexElement();

        if (lastIndex == MAX_ELEMENTS - 1)
            return;

        int newIndex = lastIndex + 1;

        A[newIndex] = (int)newNum.Value;

        ShowArrayAndQueue();

        for (int i = MAX_ELEMENTS - 1; i >= 0; i--)
            if (dataGridView3.Rows[0].Cells[i].Value != null)
            {
                dataGridView3.Rows[0].Cells[i].Value = null;
                break;
            }
    }
    
    private void heapUp(int k)
    {
        while (k > 0 && A[(k - 1) / 2] < A[k])
        {
            (A[k], A[(k - 1) / 2]) = (A[(k - 1) / 2], A[k]);

            k = (k - 1) / 2;
        }
    }

    private void heapDown(int k, int N)
    {
        while (2 * k + 1 < N)
        {
            int j = 2 * k + 1;

            if (j + 1 < N && A[j] < A[j + 1])
                j++;

            if (A[k] >= A[j])
                break;

            (A[k], A[j]) = (A[j], A[k]);
            k = j;
        }
    }

    private void changePriority_Click(object sender, EventArgs e)
    {
        int index = (int)numericUpDown2.Value;
        int newPriority = (int)numericUpDown3.Value;

        if (index < 0 || index >= MAX_ELEMENTS)
            return;

        if (A[index] == 0)
            return;

        A[index] = newPriority;

        clearTabs();
        ShowArrayAndQueue();
    }
}