using System.Runtime.InteropServices;

namespace ElvUIExtraction;

public partial class Form1 : Form
{
    // Set window as always on top
    static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
    static readonly IntPtr HWND_TOP = new IntPtr(0);
    static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
    const UInt32 SWP_NOSIZE = 0x0001;
    const UInt32 SWP_NOMOVE = 0x0002;
    const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    public Form1()
    {
        InitializeComponent();
    }

    //store folder location 
    private string MainFolder = string.Empty;

    // Form load method
    private void WoW_Prompt(object sender, EventArgs e)
    {
        SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
        };

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            MainFolder = folderBrowserDialog.SelectedPath;
        }
    }

    // OpenFileDialog for Zip File
    private void ElvUI_OFD(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog
        {
            Title = "Select ElvUI Zip File",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            Filter = "zip files (*.zip)|*.zip",

        };

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            ElvUIPath.Text = ofd.FileName;
        }
    }
    // OpenFileDialog for _classic_
    private void _classic_Btn_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog ofd = new FolderBrowserDialog
        {
            InitialDirectory = MainFolder
        };

        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
            _classic_Path.Text = ofd.SelectedPath;
        }
    }
    // OpenFileDialog for _classic_era_
    private void _classic_era_Btn_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog ofd = new FolderBrowserDialog
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
        };

        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
            _classic_era_Path.Text = ofd.SelectedPath;
        }
    }
    // OpenFileDialog for _retail_
    private void _retail_Btn_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog ofd = new FolderBrowserDialog
        {
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
        };

        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
            _retail_Path.Text = ofd.SelectedPath;
        }
    }
    //Extract using System.IO
    private void ExtractBtn_Click(object sender, EventArgs e)
    {
        var zipPath = ElvUIPath.Text;
        var extract_classic_ = _classic_Path.Text;
        var extract_classic_era_ = _classic_era_Path.Text;
        var extract_retail_ = _retail_Path.Text;

        if (_classic_Path.Text.Length == 0)
        {
            // Do Nothing
        }
        else
        {
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extract_classic_, true);
        }

        if (_classic_era_Path.Text.Length == 0)
        {
            // Do Nothing
        }
        else
        {
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extract_classic_era_, true);
        }
        if (_retail_Path.Text.Length == 0)
        {
            // Do Nothing
        }
        else
        {
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extract_retail_, true);
        }
        //Error Handling
        if (ElvUIPath.Text.Length == 0)
        {
            MessageBox.Show("Please Provide ElvUI Zip File");
            return;
        }
    }
}