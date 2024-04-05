namespace Adenuis_Com
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            portLabel = new Label();
            portBox = new ComboBox();
            receivedLabel = new Label();
            sendTextBox = new TextBox();
            clearBtn = new Button();
            sendLabel = new Label();
            receivedTextBox = new TextBox();
            sendBtn = new Button();
            loggerLabel = new Label();
            SuspendLayout();
            // 
            // portLabel
            // 
            resources.ApplyResources(portLabel, "portLabel");
            portLabel.BackColor = Color.Transparent;
            portLabel.Name = "portLabel";
            // 
            // portBox
            // 
            resources.ApplyResources(portBox, "portBox");
            portBox.FormattingEnabled = true;
            portBox.Name = "portBox";
            portBox.Sorted = true;
            portBox.TextChanged += GetPortBoxPort;
            // 
            // receivedLabel
            // 
            resources.ApplyResources(receivedLabel, "receivedLabel");
            receivedLabel.BackColor = Color.Transparent;
            receivedLabel.Name = "receivedLabel";
            // 
            // sendTextBox
            // 
            resources.ApplyResources(sendTextBox, "sendTextBox");
            sendTextBox.BackColor = Color.White;
            sendTextBox.Name = "sendTextBox";
            // 
            // clearBtn
            // 
            resources.ApplyResources(clearBtn, "clearBtn");
            clearBtn.BackColor = SystemColors.Control;
            clearBtn.ForeColor = Color.Black;
            clearBtn.Name = "clearBtn";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // sendLabel
            // 
            resources.ApplyResources(sendLabel, "sendLabel");
            sendLabel.BackColor = Color.Transparent;
            sendLabel.Name = "sendLabel";
            // 
            // receivedTextBox
            // 
            resources.ApplyResources(receivedTextBox, "receivedTextBox");
            receivedTextBox.BackColor = Color.White;
            receivedTextBox.Name = "receivedTextBox";
            // 
            // sendBtn
            // 
            resources.ApplyResources(sendBtn, "sendBtn");
            sendBtn.BackColor = Color.RoyalBlue;
            sendBtn.ForeColor = Color.White;
            sendBtn.Name = "sendBtn";
            sendBtn.UseVisualStyleBackColor = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // loggerLabel
            // 
            resources.ApplyResources(loggerLabel, "loggerLabel");
            loggerLabel.BackColor = Color.Transparent;
            loggerLabel.Name = "loggerLabel";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AllowDrop = true;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(loggerLabel);
            Controls.Add(sendBtn);
            Controls.Add(receivedTextBox);
            Controls.Add(sendLabel);
            Controls.Add(clearBtn);
            Controls.Add(sendTextBox);
            Controls.Add(receivedLabel);
            Controls.Add(portBox);
            Controls.Add(portLabel);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Main";
            FormClosed += Main_FormClosed;
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label portLabel;
        private ComboBox portBox;
        private Label receivedLabel;
        private TextBox sendTextBox;
        private Button clearBtn;
        private Label sendLabel;
        private TextBox receivedTextBox;
        private Button sendBtn;
        private Label loggerLabel;
    }
}
