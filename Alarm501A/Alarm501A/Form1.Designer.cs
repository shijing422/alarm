
namespace Alarm501A
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
            this.components = new System.ComponentModel.Container();
            this.exEdit = new System.Windows.Forms.Button();
            this.exAdd = new System.Windows.Forms.Button();
            this.exSnooze = new System.Windows.Forms.Button();
            this.exStop = new System.Windows.Forms.Button();
            this.exAlarmList = new System.Windows.Forms.ListView();
            this.exTimer = new System.Windows.Forms.DateTimePicker();
            this.exAlarmON = new System.Windows.Forms.CheckBox();
            this.exCancel = new System.Windows.Forms.Button();
            this.exSet = new System.Windows.Forms.Button();
            this.exRunTimer = new System.Windows.Forms.Timer(this.components);
            this.exSnoozeTimer = new System.Windows.Forms.Timer(this.components);
            this.exAlarmTurnOff = new System.Windows.Forms.Timer(this.components);
            this.exAlarming = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exEdit
            // 
            this.exEdit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exEdit.Location = new System.Drawing.Point(12, 33);
            this.exEdit.Name = "exEdit";
            this.exEdit.Size = new System.Drawing.Size(123, 58);
            this.exEdit.TabIndex = 0;
            this.exEdit.Text = "Edit";
            this.exEdit.UseVisualStyleBackColor = true;
            this.exEdit.Click += new System.EventHandler(this.exEdit_Click);
            // 
            // exAdd
            // 
            this.exAdd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exAdd.Location = new System.Drawing.Point(200, 33);
            this.exAdd.Name = "exAdd";
            this.exAdd.Size = new System.Drawing.Size(123, 58);
            this.exAdd.TabIndex = 1;
            this.exAdd.Text = "+";
            this.exAdd.UseVisualStyleBackColor = true;
            this.exAdd.Click += new System.EventHandler(this.exAdd_Click);
            // 
            // exSnooze
            // 
            this.exSnooze.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exSnooze.Location = new System.Drawing.Point(12, 286);
            this.exSnooze.Name = "exSnooze";
            this.exSnooze.Size = new System.Drawing.Size(123, 58);
            this.exSnooze.TabIndex = 2;
            this.exSnooze.Text = "Snooze";
            this.exSnooze.UseVisualStyleBackColor = true;
            this.exSnooze.Click += new System.EventHandler(this.exSnooze_Click);
            // 
            // exStop
            // 
            this.exStop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exStop.Location = new System.Drawing.Point(200, 286);
            this.exStop.Name = "exStop";
            this.exStop.Size = new System.Drawing.Size(123, 58);
            this.exStop.TabIndex = 3;
            this.exStop.Text = "Stop";
            this.exStop.UseVisualStyleBackColor = true;
            this.exStop.Click += new System.EventHandler(this.exStop_Click);
            // 
            // exAlarmList
            // 
            this.exAlarmList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exAlarmList.HideSelection = false;
            this.exAlarmList.Location = new System.Drawing.Point(393, 39);
            this.exAlarmList.Name = "exAlarmList";
            this.exAlarmList.Size = new System.Drawing.Size(373, 184);
            this.exAlarmList.TabIndex = 4;
            this.exAlarmList.UseCompatibleStateImageBehavior = false;
            this.exAlarmList.View = System.Windows.Forms.View.List;
            // 
            // exTimer
            // 
            this.exTimer.CustomFormat = "hh:mm:ss tt";
            this.exTimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.exTimer.Location = new System.Drawing.Point(392, 248);
            this.exTimer.Name = "exTimer";
            this.exTimer.Size = new System.Drawing.Size(300, 23);
            this.exTimer.TabIndex = 5;
            // 
            // exAlarmON
            // 
            this.exAlarmON.AutoSize = true;
            this.exAlarmON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exAlarmON.Location = new System.Drawing.Point(706, 248);
            this.exAlarmON.Name = "exAlarmON";
            this.exAlarmON.Size = new System.Drawing.Size(44, 19);
            this.exAlarmON.TabIndex = 6;
            this.exAlarmON.Text = "ON";
            this.exAlarmON.UseVisualStyleBackColor = true;
            // 
            // exCancel
            // 
            this.exCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exCancel.Location = new System.Drawing.Point(394, 285);
            this.exCancel.Name = "exCancel";
            this.exCancel.Size = new System.Drawing.Size(128, 58);
            this.exCancel.TabIndex = 7;
            this.exCancel.Text = "Cancel";
            this.exCancel.UseVisualStyleBackColor = true;
            this.exCancel.Click += new System.EventHandler(this.exCancel_Click);
            // 
            // exSet
            // 
            this.exSet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exSet.Location = new System.Drawing.Point(600, 286);
            this.exSet.Name = "exSet";
            this.exSet.Size = new System.Drawing.Size(128, 58);
            this.exSet.TabIndex = 8;
            this.exSet.Text = "Set";
            this.exSet.UseVisualStyleBackColor = true;
            this.exSet.Click += new System.EventHandler(this.exSet_Click);
            // 
            // exRunTimer
            // 
            this.exRunTimer.Tick += new System.EventHandler(this.exRunTimer_Tick);
            // 
            // exSnoozeTimer
            // 
            this.exSnoozeTimer.Tick += new System.EventHandler(this.exSnoozeTimer_Tick);
            // 
            // exAlarmTurnOff
            // 
            this.exAlarmTurnOff.Tick += new System.EventHandler(this.exAlarmTurnOff_Tick);
            // 
            // exAlarming
            // 
            this.exAlarming.AutoSize = true;
            this.exAlarming.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exAlarming.Location = new System.Drawing.Point(65, 153);
            this.exAlarming.Name = "exAlarming";
            this.exAlarming.Size = new System.Drawing.Size(154, 32);
            this.exAlarming.TabIndex = 9;
            this.exAlarming.Text = "Running......";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exAlarming);
            this.Controls.Add(this.exSet);
            this.Controls.Add(this.exCancel);
            this.Controls.Add(this.exAlarmON);
            this.Controls.Add(this.exTimer);
            this.Controls.Add(this.exAlarmList);
            this.Controls.Add(this.exStop);
            this.Controls.Add(this.exSnooze);
            this.Controls.Add(this.exAdd);
            this.Controls.Add(this.exEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Alarm501";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exEdit;
        private System.Windows.Forms.Button exAdd;
        private System.Windows.Forms.Button exSnooze;
        private System.Windows.Forms.Button exStop;
        private System.Windows.Forms.ListView exAlarmList;
        private System.Windows.Forms.DateTimePicker exTimer;
        private System.Windows.Forms.CheckBox exAlarmON;
        private System.Windows.Forms.Button exCancel;
        private System.Windows.Forms.Button exSet;
        private System.Windows.Forms.Timer exRunTimer;
        private System.Windows.Forms.Timer exSnoozeTimer;
        private System.Windows.Forms.Timer exAlarmTurnOff;
        private System.Windows.Forms.Label exAlarming;
    }
}

