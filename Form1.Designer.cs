namespace Skrot
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
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aDDomainToolStripMenuItem = new ToolStripMenuItem();
            webPageToolStripMenuItem = new ToolStripMenuItem();
            addAFileLocationToolStripMenuItem = new ToolStripMenuItem();
            installersToolStripMenuItem = new ToolStripMenuItem();
            installerToolStripMenuItem = new ToolStripMenuItem();
            launcherToolStripMenuItem = new ToolStripMenuItem();
            addAPowershellScriptToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            uRLsToolStripMenuItem = new ToolStripMenuItem();
            filesAndFoldersToolStripMenuItem = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            scriptsToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            analyzeToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem, viewToolStripMenuItem, testToolStripMenuItem, analyzeToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(840, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(37, 20);
            helpToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(114, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDDomainToolStripMenuItem, webPageToolStripMenuItem, addAFileLocationToolStripMenuItem, installersToolStripMenuItem, addAPowershellScriptToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(39, 20);
            aboutToolStripMenuItem.Text = "Edit";
            // 
            // aDDomainToolStripMenuItem
            // 
            aDDomainToolStripMenuItem.Name = "aDDomainToolStripMenuItem";
            aDDomainToolStripMenuItem.Size = new Size(198, 22);
            aDDomainToolStripMenuItem.Text = "Configure AD Domain";
            // 
            // webPageToolStripMenuItem
            // 
            webPageToolStripMenuItem.Name = "webPageToolStripMenuItem";
            webPageToolStripMenuItem.Size = new Size(198, 22);
            webPageToolStripMenuItem.Text = "Add a Web Page";
            // 
            // addAFileLocationToolStripMenuItem
            // 
            addAFileLocationToolStripMenuItem.Name = "addAFileLocationToolStripMenuItem";
            addAFileLocationToolStripMenuItem.Size = new Size(198, 22);
            addAFileLocationToolStripMenuItem.Text = "Add a File Location";
            // 
            // installersToolStripMenuItem
            // 
            installersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { installerToolStripMenuItem, launcherToolStripMenuItem });
            installersToolStripMenuItem.Name = "installersToolStripMenuItem";
            installersToolStripMenuItem.Size = new Size(198, 22);
            installersToolStripMenuItem.Text = "Add an Application";
            // 
            // installerToolStripMenuItem
            // 
            installerToolStripMenuItem.Name = "installerToolStripMenuItem";
            installerToolStripMenuItem.Size = new Size(180, 22);
            installerToolStripMenuItem.Text = "Installer";
            // 
            // launcherToolStripMenuItem
            // 
            launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            launcherToolStripMenuItem.Size = new Size(180, 22);
            launcherToolStripMenuItem.Text = "Launcher";
            launcherToolStripMenuItem.Click += launcherToolStripMenuItem_Click;
            // 
            // addAPowershellScriptToolStripMenuItem
            // 
            addAPowershellScriptToolStripMenuItem.Name = "addAPowershellScriptToolStripMenuItem";
            addAPowershellScriptToolStripMenuItem.Size = new Size(198, 22);
            addAPowershellScriptToolStripMenuItem.Text = "Add a Powershell Script";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, uRLsToolStripMenuItem, filesAndFoldersToolStripMenuItem, applicationsToolStripMenuItem, scriptsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(88, 20);
            viewToolStripMenuItem.Text = "View/Launch";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(161, 22);
            toolStripMenuItem1.Text = "Active Directory";
            // 
            // uRLsToolStripMenuItem
            // 
            uRLsToolStripMenuItem.Name = "uRLsToolStripMenuItem";
            uRLsToolStripMenuItem.Size = new Size(161, 22);
            uRLsToolStripMenuItem.Text = "URLs";
            // 
            // filesAndFoldersToolStripMenuItem
            // 
            filesAndFoldersToolStripMenuItem.Name = "filesAndFoldersToolStripMenuItem";
            filesAndFoldersToolStripMenuItem.Size = new Size(161, 22);
            filesAndFoldersToolStripMenuItem.Text = "Files and Folders";
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(161, 22);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // scriptsToolStripMenuItem
            // 
            scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            scriptsToolStripMenuItem.Size = new Size(161, 22);
            scriptsToolStripMenuItem.Text = "Scripts";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(39, 20);
            testToolStripMenuItem.Text = "Test";
            // 
            // analyzeToolStripMenuItem
            // 
            analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            analyzeToolStripMenuItem.Size = new Size(60, 20);
            analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(44, 20);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 356);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Skrot";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem analyzeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aDDomainToolStripMenuItem;
        private ToolStripMenuItem webPageToolStripMenuItem;
        private ToolStripMenuItem addAFileLocationToolStripMenuItem;
        private ToolStripMenuItem installersToolStripMenuItem;
        private ToolStripMenuItem installerToolStripMenuItem;
        private ToolStripMenuItem launcherToolStripMenuItem;
        private ToolStripMenuItem addAPowershellScriptToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem uRLsToolStripMenuItem;
        private ToolStripMenuItem filesAndFoldersToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem scriptsToolStripMenuItem;
    }
}