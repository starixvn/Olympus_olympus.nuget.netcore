
namespace MessagePackTools
{
    partial class MainForm
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
            this.SourceCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddCamelCaseKeyButton = new System.Windows.Forms.Button();
            this.RemoveKeyButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceCodeTextBox
            // 
            this.SourceCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceCodeTextBox.Location = new System.Drawing.Point(0, 0);
            this.SourceCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SourceCodeTextBox.Multiline = true;
            this.SourceCodeTextBox.Name = "SourceCodeTextBox";
            this.SourceCodeTextBox.Size = new System.Drawing.Size(1309, 1055);
            this.SourceCodeTextBox.TabIndex = 0;
            // 
            // AddCamelCaseKeyButton
            // 
            this.AddCamelCaseKeyButton.Location = new System.Drawing.Point(3, 4);
            this.AddCamelCaseKeyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCamelCaseKeyButton.Name = "AddCamelCaseKeyButton";
            this.AddCamelCaseKeyButton.Size = new System.Drawing.Size(173, 31);
            this.AddCamelCaseKeyButton.TabIndex = 1;
            this.AddCamelCaseKeyButton.Text = "Add Camel Case Key";
            this.AddCamelCaseKeyButton.UseVisualStyleBackColor = true;
            this.AddCamelCaseKeyButton.Click += new System.EventHandler(this.AddCamelCaseKeyButtonClick);
            // 
            // RemoveKeyButton
            // 
            this.RemoveKeyButton.Location = new System.Drawing.Point(193, 4);
            this.RemoveKeyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveKeyButton.Name = "RemoveKeyButton";
            this.RemoveKeyButton.Size = new System.Drawing.Size(173, 31);
            this.RemoveKeyButton.TabIndex = 2;
            this.RemoveKeyButton.Text = "Remove Key";
            this.RemoveKeyButton.UseVisualStyleBackColor = true;
            this.RemoveKeyButton.Click += new System.EventHandler(this.RemoveKeyButtonClick);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.RemoveKeyButton);
            this.ControlPanel.Controls.Add(this.AddCamelCaseKeyButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.Location = new System.Drawing.Point(0, 930);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1309, 125);
            this.ControlPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 1055);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.SourceCodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MessagePack Tools";
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceCodeTextBox;
        private System.Windows.Forms.Button AddCamelCaseKeyButton;
        private System.Windows.Forms.Button RemoveKeyButton;
        private System.Windows.Forms.Panel ControlPanel;
    }
}

