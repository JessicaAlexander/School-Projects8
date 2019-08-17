<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TabBox = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstCheck = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnexitt = New System.Windows.Forms.Button()
        Me.BtnSavee = New System.Windows.Forms.Button()
        Me.lblPayableto = New System.Windows.Forms.Label()
        Me.lblCheckamount = New System.Windows.Forms.Label()
        Me.lblCheckdate = New System.Windows.Forms.Label()
        Me.lblChecknumber = New System.Windows.Forms.Label()
        Me.txtCheckdate = New System.Windows.Forms.TextBox()
        Me.txtCheckamount = New System.Windows.Forms.TextBox()
        Me.txtPayableto = New System.Windows.Forms.TextBox()
        Me.txtChecknumber = New System.Windows.Forms.TextBox()
        Me.TabBox.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(593, 377)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(693, 377)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TabBox
        '
        Me.TabBox.Controls.Add(Me.TabPage1)
        Me.TabBox.Controls.Add(Me.TabPage2)
        Me.TabBox.Location = New System.Drawing.Point(0, 12)
        Me.TabBox.Name = "TabBox"
        Me.TabBox.SelectedIndex = 0
        Me.TabBox.Size = New System.Drawing.Size(800, 432)
        Me.TabBox.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstCheck)
        Me.TabPage1.Controls.Add(Me.MenuStrip1)
        Me.TabPage1.Controls.Add(Me.BtnExit)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 406)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check Recievers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstCheck
        '
        Me.lstCheck.FormattingEnabled = True
        Me.lstCheck.Location = New System.Drawing.Point(6, 30)
        Me.lstCheck.Name = "lstCheck"
        Me.lstCheck.Size = New System.Drawing.Size(778, 342)
        Me.lstCheck.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnexitt)
        Me.TabPage2.Controls.Add(Me.BtnSavee)
        Me.TabPage2.Controls.Add(Me.lblPayableto)
        Me.TabPage2.Controls.Add(Me.lblCheckamount)
        Me.TabPage2.Controls.Add(Me.lblCheckdate)
        Me.TabPage2.Controls.Add(Me.lblChecknumber)
        Me.TabPage2.Controls.Add(Me.txtCheckdate)
        Me.TabPage2.Controls.Add(Me.txtCheckamount)
        Me.TabPage2.Controls.Add(Me.txtPayableto)
        Me.TabPage2.Controls.Add(Me.txtChecknumber)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnexitt
        '
        Me.btnexitt.Location = New System.Drawing.Point(578, 286)
        Me.btnexitt.Name = "btnexitt"
        Me.btnexitt.Size = New System.Drawing.Size(75, 23)
        Me.btnexitt.TabIndex = 17
        Me.btnexitt.Text = "E&xit"
        Me.btnexitt.UseVisualStyleBackColor = True
        '
        'BtnSavee
        '
        Me.BtnSavee.Location = New System.Drawing.Point(478, 286)
        Me.BtnSavee.Name = "BtnSavee"
        Me.BtnSavee.Size = New System.Drawing.Size(75, 23)
        Me.BtnSavee.TabIndex = 16
        Me.BtnSavee.Text = "&Save"
        Me.BtnSavee.UseVisualStyleBackColor = True
        '
        'lblPayableto
        '
        Me.lblPayableto.AutoSize = True
        Me.lblPayableto.Location = New System.Drawing.Point(41, 217)
        Me.lblPayableto.Name = "lblPayableto"
        Me.lblPayableto.Size = New System.Drawing.Size(60, 13)
        Me.lblPayableto.TabIndex = 14
        Me.lblPayableto.Text = "&Payable to:"
        '
        'lblCheckamount
        '
        Me.lblCheckamount.AutoSize = True
        Me.lblCheckamount.Location = New System.Drawing.Point(530, 61)
        Me.lblCheckamount.Name = "lblCheckamount"
        Me.lblCheckamount.Size = New System.Drawing.Size(79, 13)
        Me.lblCheckamount.TabIndex = 12
        Me.lblCheckamount.Text = "Check &amount:"
        '
        'lblCheckdate
        '
        Me.lblCheckdate.AutoSize = True
        Me.lblCheckdate.Location = New System.Drawing.Point(276, 61)
        Me.lblCheckdate.Name = "lblCheckdate"
        Me.lblCheckdate.Size = New System.Drawing.Size(132, 13)
        Me.lblCheckdate.TabIndex = 10
        Me.lblCheckdate.Text = "Check &date (mm/dd/yyyy):"
        '
        'lblChecknumber
        '
        Me.lblChecknumber.AutoSize = True
        Me.lblChecknumber.Location = New System.Drawing.Point(41, 61)
        Me.lblChecknumber.Name = "lblChecknumber"
        Me.lblChecknumber.Size = New System.Drawing.Size(79, 13)
        Me.lblChecknumber.TabIndex = 8
        Me.lblChecknumber.Text = "Check &number:"
        '
        'txtCheckdate
        '
        Me.txtCheckdate.Location = New System.Drawing.Point(276, 77)
        Me.txtCheckdate.Name = "txtCheckdate"
        Me.txtCheckdate.Size = New System.Drawing.Size(100, 20)
        Me.txtCheckdate.TabIndex = 11
        '
        'txtCheckamount
        '
        Me.txtCheckamount.Location = New System.Drawing.Point(530, 77)
        Me.txtCheckamount.Name = "txtCheckamount"
        Me.txtCheckamount.Size = New System.Drawing.Size(100, 20)
        Me.txtCheckamount.TabIndex = 13
        '
        'txtPayableto
        '
        Me.txtPayableto.Location = New System.Drawing.Point(41, 233)
        Me.txtPayableto.Name = "txtPayableto"
        Me.txtPayableto.Size = New System.Drawing.Size(588, 20)
        Me.txtPayableto.TabIndex = 15
        '
        'txtChecknumber
        '
        Me.txtChecknumber.Location = New System.Drawing.Point(41, 77)
        Me.txtChecknumber.Name = "txtChecknumber"
        Me.txtChecknumber.Size = New System.Drawing.Size(100, 20)
        Me.txtChecknumber.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Serenity Photos"
        Me.TabBox.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TabBox As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstCheck As ListBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnexitt As Button
    Friend WithEvents BtnSavee As Button
    Friend WithEvents lblPayableto As Label
    Friend WithEvents lblCheckamount As Label
    Friend WithEvents lblCheckdate As Label
    Friend WithEvents lblChecknumber As Label
    Friend WithEvents txtCheckdate As TextBox
    Friend WithEvents txtCheckamount As TextBox
    Friend WithEvents txtPayableto As TextBox
    Friend WithEvents txtChecknumber As TextBox
End Class
