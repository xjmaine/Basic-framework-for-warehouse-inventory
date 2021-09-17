<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashBoard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBoxDispatch = New System.Windows.Forms.PictureBox()
        Me.picBoxExit = New System.Windows.Forms.PictureBox()
        Me.picBoxLogout = New System.Windows.Forms.PictureBox()
        Me.picBoxAddItem = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBoxDispatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxAddItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(958, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.picBoxDispatch)
        Me.Panel1.Controls.Add(Me.picBoxExit)
        Me.Panel1.Controls.Add(Me.picBoxLogout)
        Me.Panel1.Controls.Add(Me.picBoxAddItem)
        Me.Panel1.Location = New System.Drawing.Point(522, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 431)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Exit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Logout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dispatch Item(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Item(s)"
        '
        'picBoxDispatch
        '
        Me.picBoxDispatch.Image = CType(resources.GetObject("picBoxDispatch.Image"), System.Drawing.Image)
        Me.picBoxDispatch.Location = New System.Drawing.Point(201, 3)
        Me.picBoxDispatch.Name = "picBoxDispatch"
        Me.picBoxDispatch.Size = New System.Drawing.Size(179, 161)
        Me.picBoxDispatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxDispatch.TabIndex = 1
        Me.picBoxDispatch.TabStop = False
        '
        'picBoxExit
        '
        Me.picBoxExit.Image = CType(resources.GetObject("picBoxExit.Image"), System.Drawing.Image)
        Me.picBoxExit.Location = New System.Drawing.Point(3, 235)
        Me.picBoxExit.Name = "picBoxExit"
        Me.picBoxExit.Size = New System.Drawing.Size(179, 161)
        Me.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxExit.TabIndex = 1
        Me.picBoxExit.TabStop = False
        '
        'picBoxLogout
        '
        Me.picBoxLogout.Image = CType(resources.GetObject("picBoxLogout.Image"), System.Drawing.Image)
        Me.picBoxLogout.Location = New System.Drawing.Point(201, 235)
        Me.picBoxLogout.Name = "picBoxLogout"
        Me.picBoxLogout.Size = New System.Drawing.Size(179, 161)
        Me.picBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxLogout.TabIndex = 1
        Me.picBoxLogout.TabStop = False
        '
        'picBoxAddItem
        '
        Me.picBoxAddItem.Image = CType(resources.GetObject("picBoxAddItem.Image"), System.Drawing.Image)
        Me.picBoxAddItem.Location = New System.Drawing.Point(7, 3)
        Me.picBoxAddItem.Name = "picBoxAddItem"
        Me.picBoxAddItem.Size = New System.Drawing.Size(179, 161)
        Me.picBoxAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAddItem.TabIndex = 0
        Me.picBoxAddItem.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 431)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(25, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(491, 431)
        Me.Panel3.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.Firebrick
        Me.txtDate.Location = New System.Drawing.Point(634, 54)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(48, 22)
        Me.txtDate.TabIndex = 7
        Me.txtDate.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(139, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(477, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Warehouse Mangement Application ||"
        '
        'dashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(958, 552)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "dashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashBoard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBoxDispatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxAddItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picBoxDispatch As PictureBox
    Friend WithEvents picBoxLogout As PictureBox
    Friend WithEvents picBoxAddItem As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picBoxExit As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDate As Label
    Friend WithEvents Label5 As Label
End Class
