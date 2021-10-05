﻿
namespace P4_code
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prefrencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByAssigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByArtifactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefrencesToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.requirementToolStripMenuItem,
            this.designToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prefrencesToolStripMenuItem
            // 
            this.prefrencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectToolStripMenuItem,
            this.createProjectToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.removeProjectToolStripMenuItem});
            this.prefrencesToolStripMenuItem.Name = "prefrencesToolStripMenuItem";
            this.prefrencesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prefrencesToolStripMenuItem.Text = "Prefrences";
            // 
            // selectProjectToolStripMenuItem
            // 
            this.selectProjectToolStripMenuItem.Name = "selectProjectToolStripMenuItem";
            this.selectProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectProjectToolStripMenuItem.Text = "Select Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createProjectToolStripMenuItem.Text = "Create Project";
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyProjectToolStripMenuItem.Text = "Modify Project";
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.issueToolStripMenuItem.Text = "Issue";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countByAssigneeToolStripMenuItem,
            this.listByAssigneeToolStripMenuItem,
            this.countByArtifactToolStripMenuItem,
            this.listByArtifactToolStripMenuItem,
            this.countByDateRangeToolStripMenuItem,
            this.listByDateRangeToolStripMenuItem,
            this.trendByDateRangeToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // countByAssigneeToolStripMenuItem
            // 
            this.countByAssigneeToolStripMenuItem.Name = "countByAssigneeToolStripMenuItem";
            this.countByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByAssigneeToolStripMenuItem.Text = "Count by Assignee";
            // 
            // listByAssigneeToolStripMenuItem
            // 
            this.listByAssigneeToolStripMenuItem.Name = "listByAssigneeToolStripMenuItem";
            this.listByAssigneeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByAssigneeToolStripMenuItem.Text = "List by Assignee";
            // 
            // countByArtifactToolStripMenuItem
            // 
            this.countByArtifactToolStripMenuItem.Name = "countByArtifactToolStripMenuItem";
            this.countByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByArtifactToolStripMenuItem.Text = "Count by Artifact";
            // 
            // listByArtifactToolStripMenuItem
            // 
            this.listByArtifactToolStripMenuItem.Name = "listByArtifactToolStripMenuItem";
            this.listByArtifactToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByArtifactToolStripMenuItem.Text = "List by Artifact";
            // 
            // countByDateRangeToolStripMenuItem
            // 
            this.countByDateRangeToolStripMenuItem.Name = "countByDateRangeToolStripMenuItem";
            this.countByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countByDateRangeToolStripMenuItem.Text = "Count by Date Range";
            // 
            // listByDateRangeToolStripMenuItem
            // 
            this.listByDateRangeToolStripMenuItem.Name = "listByDateRangeToolStripMenuItem";
            this.listByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listByDateRangeToolStripMenuItem.Text = "List by Date Range";
            // 
            // trendByDateRangeToolStripMenuItem
            // 
            this.trendByDateRangeToolStripMenuItem.Name = "trendByDateRangeToolStripMenuItem";
            this.trendByDateRangeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.trendByDateRangeToolStripMenuItem.Text = "Trend by Date Range";
            // 
            // requirementToolStripMenuItem
            // 
            this.requirementToolStripMenuItem.Name = "requirementToolStripMenuItem";
            this.requirementToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.requirementToolStripMenuItem.Text = "Requirement";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prefrencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByAssigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByArtifactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}