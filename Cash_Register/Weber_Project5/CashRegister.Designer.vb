<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashRegister
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
        Me.gbRegularMenu = New System.Windows.Forms.GroupBox()
        Me.lstRegularMenu = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.gbCustomerOrder = New System.Windows.Forms.GroupBox()
        Me.lstCustomerOrder = New System.Windows.Forms.ListBox()
        Me.gbKidsMenu = New System.Windows.Forms.GroupBox()
        Me.lstKidsMenu = New System.Windows.Forms.ListBox()
        Me.btnAddReg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddKids = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.gbRegularMenu.SuspendLayout()
        Me.gbCustomerOrder.SuspendLayout()
        Me.gbKidsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegularMenu
        '
        Me.gbRegularMenu.Controls.Add(Me.lstRegularMenu)
        Me.gbRegularMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegularMenu.Location = New System.Drawing.Point(13, 13)
        Me.gbRegularMenu.Name = "gbRegularMenu"
        Me.gbRegularMenu.Size = New System.Drawing.Size(200, 322)
        Me.gbRegularMenu.TabIndex = 0
        Me.gbRegularMenu.TabStop = False
        Me.gbRegularMenu.Text = "Regular Menu"
        '
        'lstRegularMenu
        '
        Me.lstRegularMenu.FormattingEnabled = True
        Me.lstRegularMenu.ItemHeight = 20
        Me.lstRegularMenu.Location = New System.Drawing.Point(7, 26)
        Me.lstRegularMenu.Name = "lstRegularMenu"
        Me.lstRegularMenu.Size = New System.Drawing.Size(187, 284)
        Me.lstRegularMenu.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(13, 341)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 36)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(119, 341)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(94, 36)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'gbCustomerOrder
        '
        Me.gbCustomerOrder.Controls.Add(Me.lstCustomerOrder)
        Me.gbCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCustomerOrder.Location = New System.Drawing.Point(327, 12)
        Me.gbCustomerOrder.Name = "gbCustomerOrder"
        Me.gbCustomerOrder.Size = New System.Drawing.Size(200, 365)
        Me.gbCustomerOrder.TabIndex = 1
        Me.gbCustomerOrder.TabStop = False
        Me.gbCustomerOrder.Text = "Customer Order"
        '
        'lstCustomerOrder
        '
        Me.lstCustomerOrder.FormattingEnabled = True
        Me.lstCustomerOrder.ItemHeight = 20
        Me.lstCustomerOrder.Location = New System.Drawing.Point(7, 26)
        Me.lstCustomerOrder.Name = "lstCustomerOrder"
        Me.lstCustomerOrder.Size = New System.Drawing.Size(187, 324)
        Me.lstCustomerOrder.TabIndex = 0
        '
        'gbKidsMenu
        '
        Me.gbKidsMenu.Controls.Add(Me.lstKidsMenu)
        Me.gbKidsMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbKidsMenu.Location = New System.Drawing.Point(637, 13)
        Me.gbKidsMenu.Name = "gbKidsMenu"
        Me.gbKidsMenu.Size = New System.Drawing.Size(200, 322)
        Me.gbKidsMenu.TabIndex = 1
        Me.gbKidsMenu.TabStop = False
        Me.gbKidsMenu.Text = "Kids Menu"
        '
        'lstKidsMenu
        '
        Me.lstKidsMenu.FormattingEnabled = True
        Me.lstKidsMenu.ItemHeight = 20
        Me.lstKidsMenu.Location = New System.Drawing.Point(7, 26)
        Me.lstKidsMenu.Name = "lstKidsMenu"
        Me.lstKidsMenu.Size = New System.Drawing.Size(187, 284)
        Me.lstKidsMenu.TabIndex = 0
        '
        'btnAddReg
        '
        Me.btnAddReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddReg.Location = New System.Drawing.Point(240, 137)
        Me.btnAddReg.Name = "btnAddReg"
        Me.btnAddReg.Size = New System.Drawing.Size(64, 36)
        Me.btnAddReg.TabIndex = 3
        Me.btnAddReg.Text = ">>"
        Me.btnAddReg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add to Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(544, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Add to Order"
        '
        'btnAddKids
        '
        Me.btnAddKids.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddKids.Location = New System.Drawing.Point(547, 137)
        Me.btnAddKids.Name = "btnAddKids"
        Me.btnAddKids.Size = New System.Drawing.Size(64, 36)
        Me.btnAddKids.TabIndex = 5
        Me.btnAddKids.Text = "<<"
        Me.btnAddKids.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(695, 351)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(136, 26)
        Me.txtTotal.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(641, 354)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total:"
        '
        'frmCashRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 422)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddKids)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddReg)
        Me.Controls.Add(Me.gbKidsMenu)
        Me.Controls.Add(Me.gbCustomerOrder)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.gbRegularMenu)
        Me.Name = "frmCashRegister"
        Me.Text = "Fast-Food Restaurant Cash Register"
        Me.gbRegularMenu.ResumeLayout(False)
        Me.gbCustomerOrder.ResumeLayout(False)
        Me.gbKidsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbRegularMenu As GroupBox
    Friend WithEvents lstRegularMenu As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents gbCustomerOrder As GroupBox
    Friend WithEvents lstCustomerOrder As ListBox
    Friend WithEvents gbKidsMenu As GroupBox
    Friend WithEvents lstKidsMenu As ListBox
    Friend WithEvents btnAddReg As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddKids As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
End Class
