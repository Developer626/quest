﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IfEditor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IfEditor))
        Me.ctlSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ctlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdAddElse = New System.Windows.Forms.ToolStripSplitButton()
        Me.AddElseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddElseIfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctlChild = New AxeSoftware.Quest.IfEditorChild()
        Me.ctlSplitContainer.Panel1.SuspendLayout()
        Me.ctlSplitContainer.SuspendLayout()
        Me.ctlToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctlSplitContainer
        '
        Me.ctlSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.ctlSplitContainer.Name = "ctlSplitContainer"
        Me.ctlSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ctlSplitContainer.Panel1
        '
        Me.ctlSplitContainer.Panel1.Controls.Add(Me.ctlChild)
        Me.ctlSplitContainer.Panel1MinSize = 0
        Me.ctlSplitContainer.Panel2Collapsed = True
        Me.ctlSplitContainer.Panel2MinSize = 0
        Me.ctlSplitContainer.Size = New System.Drawing.Size(435, 278)
        Me.ctlSplitContainer.SplitterDistance = 160
        Me.ctlSplitContainer.TabIndex = 4
        '
        'ctlToolStrip
        '
        Me.ctlToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ctlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAddElse})
        Me.ctlToolStrip.Location = New System.Drawing.Point(0, 278)
        Me.ctlToolStrip.Name = "ctlToolStrip"
        Me.ctlToolStrip.Size = New System.Drawing.Size(435, 25)
        Me.ctlToolStrip.TabIndex = 5
        Me.ctlToolStrip.Text = "ToolStrip1"
        '
        'cmdAddElse
        '
        Me.cmdAddElse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdAddElse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddElseToolStripMenuItem, Me.AddElseIfToolStripMenuItem})
        Me.cmdAddElse.Image = CType(resources.GetObject("cmdAddElse.Image"), System.Drawing.Image)
        Me.cmdAddElse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddElse.Name = "cmdAddElse"
        Me.cmdAddElse.Size = New System.Drawing.Size(68, 22)
        Me.cmdAddElse.Text = "Add Else"
        '
        'AddElseToolStripMenuItem
        '
        Me.AddElseToolStripMenuItem.Name = "AddElseToolStripMenuItem"
        Me.AddElseToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AddElseToolStripMenuItem.Text = "Add Else"
        '
        'AddElseIfToolStripMenuItem
        '
        Me.AddElseIfToolStripMenuItem.Name = "AddElseIfToolStripMenuItem"
        Me.AddElseIfToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AddElseIfToolStripMenuItem.Text = "Add Else If"
        '
        'ctlChild
        '
        Me.ctlChild.Controller = Nothing
        Me.ctlChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlChild.ElseIfMode = False
        Me.ctlChild.Location = New System.Drawing.Point(0, 0)
        Me.ctlChild.Name = "ctlChild"
        Me.ctlChild.Size = New System.Drawing.Size(435, 278)
        Me.ctlChild.TabIndex = 0
        '
        'IfEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ctlSplitContainer)
        Me.Controls.Add(Me.ctlToolStrip)
        Me.Name = "IfEditor"
        Me.Size = New System.Drawing.Size(435, 303)
        Me.ctlSplitContainer.Panel1.ResumeLayout(False)
        Me.ctlSplitContainer.ResumeLayout(False)
        Me.ctlToolStrip.ResumeLayout(False)
        Me.ctlToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctlSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents ctlChild As AxeSoftware.Quest.IfEditorChild
    Friend WithEvents ctlToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAddElse As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AddElseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddElseIfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
