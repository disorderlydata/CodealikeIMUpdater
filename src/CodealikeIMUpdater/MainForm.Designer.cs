namespace CodealikeIMUpdater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTestCodealike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodealikeUser = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestHipChat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHipChatEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHipChatToken = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUnknown = new System.Windows.Forms.ComboBox();
            this.txtUnknownMsg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCannotInterrupt = new System.Windows.Forms.ComboBox();
            this.txtCannotInterruptMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCanInterrupt = new System.Windows.Forms.ComboBox();
            this.txtCanInterruptMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNoActivity = new System.Windows.Forms.ComboBox();
            this.txtNoActivityMsg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateInterval = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every5MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every10MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every15MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTestCodealike);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodealikeUser);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codealike Settings";
            // 
            // btnTestCodealike
            // 
            this.btnTestCodealike.Location = new System.Drawing.Point(296, 18);
            this.btnTestCodealike.Name = "btnTestCodealike";
            this.btnTestCodealike.Size = new System.Drawing.Size(75, 23);
            this.btnTestCodealike.TabIndex = 2;
            this.btnTestCodealike.Text = "Test";
            this.btnTestCodealike.UseVisualStyleBackColor = true;
            this.btnTestCodealike.Click += new System.EventHandler(this.btnTestCodealike_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // txtCodealikeUser
            // 
            this.txtCodealikeUser.Location = new System.Drawing.Point(101, 20);
            this.txtCodealikeUser.Name = "txtCodealikeUser";
            this.txtCodealikeUser.Size = new System.Drawing.Size(190, 20);
            this.txtCodealikeUser.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestHipChat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHipChatEmail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHipChatToken);
            this.groupBox2.Location = new System.Drawing.Point(13, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HipChat Settings";
            // 
            // btnTestHipChat
            // 
            this.btnTestHipChat.Location = new System.Drawing.Point(298, 20);
            this.btnTestHipChat.Name = "btnTestHipChat";
            this.btnTestHipChat.Size = new System.Drawing.Size(75, 23);
            this.btnTestHipChat.TabIndex = 2;
            this.btnTestHipChat.Text = "Test";
            this.btnTestHipChat.UseVisualStyleBackColor = true;
            this.btnTestHipChat.Click += new System.EventHandler(this.btnTestHipChat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "HipChat Email";
            // 
            // txtHipChatEmail
            // 
            this.txtHipChatEmail.Location = new System.Drawing.Point(101, 47);
            this.txtHipChatEmail.Name = "txtHipChatEmail";
            this.txtHipChatEmail.Size = new System.Drawing.Size(189, 20);
            this.txtHipChatEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HipChat Token";
            // 
            // txtHipChatToken
            // 
            this.txtHipChatToken.Location = new System.Drawing.Point(101, 20);
            this.txtHipChatToken.Name = "txtHipChatToken";
            this.txtHipChatToken.Size = new System.Drawing.Size(190, 20);
            this.txtHipChatToken.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbUnknown);
            this.groupBox3.Controls.Add(this.txtUnknownMsg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbCannotInterrupt);
            this.groupBox3.Controls.Add(this.txtCannotInterruptMsg);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbCanInterrupt);
            this.groupBox3.Controls.Add(this.txtCanInterruptMsg);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbNoActivity);
            this.groupBox3.Controls.Add(this.txtNoActivityMsg);
            this.groupBox3.Location = new System.Drawing.Point(13, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Codealike Status Mapping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Unknown";
            // 
            // cbUnknown
            // 
            this.cbUnknown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnknown.FormattingEnabled = true;
            this.cbUnknown.Location = new System.Drawing.Point(108, 17);
            this.cbUnknown.Name = "cbUnknown";
            this.cbUnknown.Size = new System.Drawing.Size(121, 21);
            this.cbUnknown.TabIndex = 0;
            // 
            // txtUnknownMsg
            // 
            this.txtUnknownMsg.Location = new System.Drawing.Point(235, 19);
            this.txtUnknownMsg.Name = "txtUnknownMsg";
            this.txtUnknownMsg.Size = new System.Drawing.Size(138, 20);
            this.txtUnknownMsg.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cannot Interrupt";
            // 
            // cbCannotInterrupt
            // 
            this.cbCannotInterrupt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCannotInterrupt.FormattingEnabled = true;
            this.cbCannotInterrupt.Location = new System.Drawing.Point(108, 98);
            this.cbCannotInterrupt.Name = "cbCannotInterrupt";
            this.cbCannotInterrupt.Size = new System.Drawing.Size(121, 21);
            this.cbCannotInterrupt.TabIndex = 6;
            // 
            // txtCannotInterruptMsg
            // 
            this.txtCannotInterruptMsg.Location = new System.Drawing.Point(235, 100);
            this.txtCannotInterruptMsg.Name = "txtCannotInterruptMsg";
            this.txtCannotInterruptMsg.Size = new System.Drawing.Size(138, 20);
            this.txtCannotInterruptMsg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Can Interrupt";
            // 
            // cbCanInterrupt
            // 
            this.cbCanInterrupt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCanInterrupt.FormattingEnabled = true;
            this.cbCanInterrupt.Location = new System.Drawing.Point(108, 71);
            this.cbCanInterrupt.Name = "cbCanInterrupt";
            this.cbCanInterrupt.Size = new System.Drawing.Size(121, 21);
            this.cbCanInterrupt.TabIndex = 4;
            // 
            // txtCanInterruptMsg
            // 
            this.txtCanInterruptMsg.Location = new System.Drawing.Point(235, 73);
            this.txtCanInterruptMsg.Name = "txtCanInterruptMsg";
            this.txtCanInterruptMsg.Size = new System.Drawing.Size(138, 20);
            this.txtCanInterruptMsg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "No Activity";
            // 
            // cbNoActivity
            // 
            this.cbNoActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoActivity.FormattingEnabled = true;
            this.cbNoActivity.Location = new System.Drawing.Point(108, 44);
            this.cbNoActivity.Name = "cbNoActivity";
            this.cbNoActivity.Size = new System.Drawing.Size(121, 21);
            this.cbNoActivity.TabIndex = 2;
            // 
            // txtNoActivityMsg
            // 
            this.txtNoActivityMsg.Location = new System.Drawing.Point(235, 46);
            this.txtNoActivityMsg.Name = "txtNoActivityMsg";
            this.txtNoActivityMsg.Size = new System.Drawing.Size(138, 20);
            this.txtNoActivityMsg.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Check status every";
            // 
            // cbUpdateInterval
            // 
            this.cbUpdateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateInterval.FormattingEnabled = true;
            this.cbUpdateInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbUpdateInterval.Location = new System.Drawing.Point(121, 303);
            this.cbUpdateInterval.Name = "cbUpdateInterval";
            this.cbUpdateInterval.Size = new System.Drawing.Size(121, 21);
            this.cbUpdateInterval.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "minutes";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Codealike IM Updater";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuExitItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(113, 54);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disabledToolStripMenuItem,
            this.every5MinutesToolStripMenuItem,
            this.every10MinutesToolStripMenuItem,
            this.every15MinutesToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // disabledToolStripMenuItem
            // 
            this.disabledToolStripMenuItem.Enabled = false;
            this.disabledToolStripMenuItem.Name = "disabledToolStripMenuItem";
            this.disabledToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.disabledToolStripMenuItem.Text = "Disabled";
            this.disabledToolStripMenuItem.Visible = false;
            this.disabledToolStripMenuItem.Click += new System.EventHandler(this.updateIntervalToolStripMenuItem_Click);
            // 
            // every5MinutesToolStripMenuItem
            // 
            this.every5MinutesToolStripMenuItem.Checked = true;
            this.every5MinutesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.every5MinutesToolStripMenuItem.Name = "every5MinutesToolStripMenuItem";
            this.every5MinutesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.every5MinutesToolStripMenuItem.Text = "Every 5 minutes";
            this.every5MinutesToolStripMenuItem.Click += new System.EventHandler(this.updateIntervalToolStripMenuItem_Click);
            // 
            // every10MinutesToolStripMenuItem
            // 
            this.every10MinutesToolStripMenuItem.Name = "every10MinutesToolStripMenuItem";
            this.every10MinutesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.every10MinutesToolStripMenuItem.Text = "Every 10 minutes";
            this.every10MinutesToolStripMenuItem.Click += new System.EventHandler(this.updateIntervalToolStripMenuItem_Click);
            // 
            // every15MinutesToolStripMenuItem
            // 
            this.every15MinutesToolStripMenuItem.Name = "every15MinutesToolStripMenuItem";
            this.every15MinutesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.every15MinutesToolStripMenuItem.Text = "Every 15 minutes";
            this.every15MinutesToolStripMenuItem.Click += new System.EventHandler(this.updateIntervalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // toolStripMenuExitItem
            // 
            this.toolStripMenuExitItem.Name = "toolStripMenuExitItem";
            this.toolStripMenuExitItem.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuExitItem.Text = "Exit";
            this.toolStripMenuExitItem.Click += new System.EventHandler(this.toolStripMenuExitItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 385);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbUpdateInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Settings";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodealikeUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHipChatEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHipChatToken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbNoActivity;
        private System.Windows.Forms.TextBox txtNoActivityMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCannotInterrupt;
        private System.Windows.Forms.TextBox txtCannotInterruptMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCanInterrupt;
        private System.Windows.Forms.TextBox txtCanInterruptMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUpdateInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTestCodealike;
        private System.Windows.Forms.Button btnTestHipChat;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExitItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every5MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every10MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every15MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUnknown;
        private System.Windows.Forms.TextBox txtUnknownMsg;
    }
}

