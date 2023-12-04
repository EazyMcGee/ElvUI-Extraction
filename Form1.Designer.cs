namespace ElvUIExtraction;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        ElvUIPath = new TextBox();
        _classic_Path = new TextBox();
        _classic_era_Path = new TextBox();
        _retail_Path = new TextBox();
        button1 = new Button();
        _classic_Btn = new Button();
        _classic_era_Btn = new Button();
        _retail_Btn = new Button();
        ExtractBtn = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // ElvUIPath
        // 
        ElvUIPath.Location = new Point(103, 50);
        ElvUIPath.Name = "ElvUIPath";
        ElvUIPath.Size = new Size(149, 23);
        ElvUIPath.TabIndex = 0;
        // 
        // _classic_Path
        // 
        _classic_Path.Location = new Point(103, 100);
        _classic_Path.Name = "_classic_Path";
        _classic_Path.Size = new Size(149, 23);
        _classic_Path.TabIndex = 1;
        // 
        // _classic_era_Path
        // 
        _classic_era_Path.Location = new Point(103, 151);
        _classic_era_Path.Name = "_classic_era_Path";
        _classic_era_Path.Size = new Size(149, 23);
        _classic_era_Path.TabIndex = 2;
        // 
        // _retail_Path
        // 
        _retail_Path.Location = new Point(103, 200);
        _retail_Path.Name = "_retail_Path";
        _retail_Path.Size = new Size(149, 23);
        _retail_Path.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(258, 50);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 4;
        button1.Text = "Browse...";
        button1.UseVisualStyleBackColor = true;
        button1.Click += ElvUI_OFD;
        // 
        // _classic_Btn
        // 
        _classic_Btn.Location = new Point(258, 100);
        _classic_Btn.Name = "_classic_Btn";
        _classic_Btn.Size = new Size(75, 23);
        _classic_Btn.TabIndex = 5;
        _classic_Btn.Text = "Browse...";
        _classic_Btn.UseVisualStyleBackColor = true;
        _classic_Btn.Click += _classic_Btn_Click;
        // 
        // _classic_era_Btn
        // 
        _classic_era_Btn.Location = new Point(258, 150);
        _classic_era_Btn.Name = "_classic_era_Btn";
        _classic_era_Btn.Size = new Size(75, 23);
        _classic_era_Btn.TabIndex = 6;
        _classic_era_Btn.Text = "Browse...";
        _classic_era_Btn.UseVisualStyleBackColor = true;
        _classic_era_Btn.Click += _classic_era_Btn_Click;
        // 
        // _retail_Btn
        // 
        _retail_Btn.Location = new Point(258, 200);
        _retail_Btn.Name = "_retail_Btn";
        _retail_Btn.Size = new Size(75, 23);
        _retail_Btn.TabIndex = 7;
        _retail_Btn.Text = "Browse...";
        _retail_Btn.UseVisualStyleBackColor = true;
        _retail_Btn.Click += _retail_Btn_Click;
        // 
        // ExtractBtn
        // 
        ExtractBtn.Location = new Point(133, 263);
        ExtractBtn.Name = "ExtractBtn";
        ExtractBtn.Size = new Size(75, 23);
        ExtractBtn.TabIndex = 8;
        ExtractBtn.Text = "Extract";
        ExtractBtn.UseVisualStyleBackColor = true;
        ExtractBtn.Click += ExtractBtn_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 54);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 9;
        label1.Text = "ElvUI Zip";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(27, 104);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 10;
        label2.Text = "_classic_";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 154);
        label3.Name = "label3";
        label3.Size = new Size(72, 15);
        label3.TabIndex = 11;
        label3.Text = "_classic_era_";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(27, 204);
        label4.Name = "label4";
        label4.Size = new Size(43, 15);
        label4.TabIndex = 12;
        label4.Text = "_retail_";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(374, 340);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ExtractBtn);
        Controls.Add(_retail_Btn);
        Controls.Add(_classic_era_Btn);
        Controls.Add(_classic_Btn);
        Controls.Add(button1);
        Controls.Add(_retail_Path);
        Controls.Add(_classic_era_Path);
        Controls.Add(_classic_Path);
        Controls.Add(ElvUIPath);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Form1";
        Load += WoW_Prompt;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox ElvUIPath;
    private TextBox _classic_Path;
    private TextBox _classic_era_Path;
    private TextBox _retail_Path;
    private Button button1;
    private Button _classic_Btn;
    private Button _classic_era_Btn;
    private Button _retail_Btn;
    private Button ExtractBtn;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
}
