namespace winformsapp;

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
        FormLabel();
        LabelText();
        TextInput();
        enterBTN();
        exitBTN();
        // checkBox("đúng", 255 , 13);
        // checkBox("sai", 255 , 35);
    }
    void FormLabel(){
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "loveCode";
    }
    void TextInput(){
        TextBox nameInput = new TextBox();
        nameInput.Location = new Point(188,90);
        nameInput.Multiline = true;
        nameInput.Name = "Name Input";
        nameInput.Size = new Size(246,23);
        nameInput.TabIndex = 0;
        this.Controls.Add(nameInput);
    }
    void exitBTN(){
        Button exitBTN = new Button();
        exitBTN.Location = new Point(255,255);
        exitBTN.Text = "exit";
        exitBTN.AutoSize = true;
        exitBTN.Padding = new Padding(10);
        exitBTN.BackColor = Color.Red;
        exitBTN.Font = new Font("French Script MT", 24);
        this.Controls.Add(exitBTN);        
    }
    void enterBTN(){
        Button enterBTN = new Button();
        enterBTN.Location = new Point(255,108);
        enterBTN.Text = "enter";
        enterBTN.AutoSize = true;
        enterBTN.Padding = new Padding(8);
        enterBTN.BackColor = Color.Blue;
        enterBTN.Font = new Font("French Script MT", 24);
        this.Controls.Add(enterBTN);
    }
    void LabelText(){
        Label lb = new Label();
        lb.Location = new Point(243, 80);
        lb.Text = "Select post";
        this.Controls.Add(lb);

        ListBox lstbox = new ListBox();
        lstbox.Location = new Point(300, 104);
        lstbox.Visible = false;
        lstbox.Items.Add("Intern");
        lstbox.Items.Add("Software Engineer");
        lstbox.Items.Add("Project Manager");
        lstbox.Items.Add("HR");
        this.Controls.Add(lstbox);
    }
    void checkBox(string nameCheck,int LocationNum1, int LocationNum2){
        CheckBox checkBox = new CheckBox();
        checkBox.AutoCheck = true;
        checkBox.Text = nameCheck;
        checkBox.Location =new Point (LocationNum1, LocationNum2);
        this.Controls.Add(checkBox);
    }
    #endregion
}
