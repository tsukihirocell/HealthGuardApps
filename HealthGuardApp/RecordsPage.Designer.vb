﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordsPage))
        RoundedTextBox1 = New RoundedTextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        RoundedPanel1 = New RoundedPanel()
        Label7 = New Label()
        CirclePictureBox2 = New CirclePictureBox()
        Label11 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        RoundedPanel2 = New RoundedPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel1.SuspendLayout()
        CType(CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        RoundedPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' RoundedTextBox1
        ' 
        RoundedTextBox1.BackColor = SystemColors.ButtonFace
        RoundedTextBox1.Location = New Point(11, 6)
        RoundedTextBox1.Name = "RoundedTextBox1"
        RoundedTextBox1.PlaceholderText = "Search"
        RoundedTextBox1.Size = New Size(245, 23)
        RoundedTextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonFace
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(315, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 18)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(35, 88)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' RoundedPanel1
        ' 
        RoundedPanel1.Controls.Add(Label7)
        RoundedPanel1.Controls.Add(CirclePictureBox2)
        RoundedPanel1.Controls.Add(Label11)
        RoundedPanel1.Controls.Add(Label8)
        RoundedPanel1.Controls.Add(Label10)
        RoundedPanel1.Controls.Add(Label9)
        RoundedPanel1.CornerRadius = 20
        RoundedPanel1.Location = New Point(35, 197)
        RoundedPanel1.Name = "RoundedPanel1"
        RoundedPanel1.Size = New Size(324, 102)
        RoundedPanel1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(130, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 15)
        Label7.TabIndex = 19
        Label7.Text = "Sex"
        ' 
        ' CirclePictureBox2
        ' 
        CirclePictureBox2.BackColor = SystemColors.Control
        CirclePictureBox2.BorderRadius = 20
        CirclePictureBox2.Image = CType(resources.GetObject("CirclePictureBox2.Image"), Image)
        CirclePictureBox2.Location = New Point(13, 14)
        CirclePictureBox2.Name = "CirclePictureBox2"
        CirclePictureBox2.Size = New Size(84, 72)
        CirclePictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        CirclePictureBox2.TabIndex = 8
        CirclePictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F)
        Label11.Location = New Point(159, 31)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 15)
        Label11.TabIndex = 15
        Label11.Text = "LastName"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(104, 54)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 15)
        Label8.TabIndex = 18
        Label8.Text = "Age"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F)
        Label10.Location = New Point(101, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 15)
        Label10.TabIndex = 16
        Label10.Text = "FirstName"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(134, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 17
        Label9.Text = "MiddleName"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(-11, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(422, 68)
        Panel1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 16)
        Label3.TabIndex = 5
        Label3.Text = "MENU"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(24, 14)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(48, -11)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(142, 90)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' RoundedPanel2
        ' 
        RoundedPanel2.Controls.Add(RoundedTextBox1)
        RoundedPanel2.Controls.Add(PictureBox1)
        RoundedPanel2.CornerRadius = 20
        RoundedPanel2.Location = New Point(24, 142)
        RoundedPanel2.Name = "RoundedPanel2"
        RoundedPanel2.Size = New Size(348, 34)
        RoundedPanel2.TabIndex = 9
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(400, 750)
        Controls.Add(RoundedPanel2)
        Controls.Add(Panel1)
        Controls.Add(RoundedPanel1)
        Controls.Add(PictureBox2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "RecordsPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RecordsPage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel1.ResumeLayout(False)
        RoundedPanel1.PerformLayout()
        CType(CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        RoundedPanel2.ResumeLayout(False)
        RoundedPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedTextBox1 As RoundedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents CirclePictureBox1 As CirclePictureBox
    Friend WithEvents CirclePictureBox2 As CirclePictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
End Class
