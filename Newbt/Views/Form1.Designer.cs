namespace Newbt
{
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
                Button("Oke");

            }
            base.Dispose(disposing);
        }

        private void Button(string v)
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            errorProvider1.SetError(label3, resources.GetString("label3.Error"));
            errorProvider1.SetIconAlignment(label3, (ErrorIconAlignment)resources.GetObject("label3.IconAlignment"));
            errorProvider1.SetIconPadding(label3, (int)resources.GetObject("label3.IconPadding"));
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            errorProvider1.SetError(label6, resources.GetString("label6.Error"));
            errorProvider1.SetIconAlignment(label6, (ErrorIconAlignment)resources.GetObject("label6.IconAlignment"));
            errorProvider1.SetIconPadding(label6, (int)resources.GetObject("label6.IconPadding"));
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            errorProvider1.SetError(contextMenuStrip1, resources.GetString("contextMenuStrip1.Error"));
            errorProvider1.SetIconAlignment(contextMenuStrip1, (ErrorIconAlignment)resources.GetObject("contextMenuStrip1.IconAlignment"));
            errorProvider1.SetIconPadding(contextMenuStrip1, (int)resources.GetObject("contextMenuStrip1.IconPadding"));
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(textBox2, resources.GetString("textBox2.Error"));
            errorProvider1.SetIconAlignment(textBox2, (ErrorIconAlignment)resources.GetObject("textBox2.IconAlignment"));
            errorProvider1.SetIconPadding(textBox2, (int)resources.GetObject("textBox2.IconPadding"));
            textBox2.Name = "textBox2";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Cursor = Cursors.Hand;
            errorProvider1.SetError(button3, resources.GetString("button3.Error"));
            errorProvider1.SetIconAlignment(button3, (ErrorIconAlignment)resources.GetObject("button3.IconAlignment"));
            errorProvider1.SetIconPadding(button3, (int)resources.GetObject("button3.IconPadding"));
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            errorProvider1.SetError(linkLabel1, resources.GetString("linkLabel1.Error"));
            errorProvider1.SetIconAlignment(linkLabel1, (ErrorIconAlignment)resources.GetObject("linkLabel1.IconAlignment"));
            errorProvider1.SetIconPadding(linkLabel1, (int)resources.GetObject("linkLabel1.IconPadding"));
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.AliceBlue;
            errorProvider1.SetError(label1, resources.GetString("label1.Error"));
            label1.ForeColor = Color.Purple;
            errorProvider1.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            errorProvider1.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            errorProvider1.SetError(textBox3, resources.GetString("textBox3.Error"));
            errorProvider1.SetIconAlignment(textBox3, (ErrorIconAlignment)resources.GetObject("textBox3.IconAlignment"));
            errorProvider1.SetIconPadding(textBox3, (int)resources.GetObject("textBox3.IconPadding"));
            textBox3.Name = "textBox3";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            errorProvider1.SetError(groupBox1, resources.GetString("groupBox1.Error"));
            errorProvider1.SetIconAlignment(groupBox1, (ErrorIconAlignment)resources.GetObject("groupBox1.IconAlignment"));
            errorProvider1.SetIconPadding(groupBox1, (int)resources.GetObject("groupBox1.IconPadding"));
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            errorProvider1.SetError(label2, resources.GetString("label2.Error"));
            errorProvider1.SetIconAlignment(label2, (ErrorIconAlignment)resources.GetObject("label2.IconAlignment"));
            errorProvider1.SetIconPadding(label2, (int)resources.GetObject("label2.IconPadding"));
            label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private TextBox textBox2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label2;
    }
}