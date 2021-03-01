<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelCurrentTime = New System.Windows.Forms.Label()
        Me.LabelNextTime = New System.Windows.Forms.Label()
        Me.LabelMoney = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.LabelFontSize = New System.Windows.Forms.Label()
        Me.TextBoxFontSize = New System.Windows.Forms.TextBox()
        Me.LabelTotalMoney = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxCash = New System.Windows.Forms.TextBox()
        Me.TextBoxWealth = New System.Windows.Forms.TextBox()
        Me.ColumnStockName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPriceChange = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNumberOwned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnSell = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnBuy = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnStockName, Me.ColumnPrice, Me.ColumnPriceChange, Me.ColumnNumberOwned, Me.ColumnValue, Me.ColumnSell, Me.ColumnBuy})
        Me.DataGridView1.Location = New System.Drawing.Point(42, 77)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(955, 815)
        Me.DataGridView1.TabIndex = 0
        '
        'LabelCurrentTime
        '
        Me.LabelCurrentTime.AutoSize = True
        Me.LabelCurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentTime.Location = New System.Drawing.Point(1018, 104)
        Me.LabelCurrentTime.Name = "LabelCurrentTime"
        Me.LabelCurrentTime.Size = New System.Drawing.Size(206, 31)
        Me.LabelCurrentTime.TabIndex = 1
        Me.LabelCurrentTime.Text = "December 2004"
        '
        'LabelNextTime
        '
        Me.LabelNextTime.AutoSize = True
        Me.LabelNextTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNextTime.Location = New System.Drawing.Point(1016, 176)
        Me.LabelNextTime.Name = "LabelNextTime"
        Me.LabelNextTime.Size = New System.Drawing.Size(173, 31)
        Me.LabelNextTime.TabIndex = 2
        Me.LabelNextTime.Text = "Next Time in:"
        '
        'LabelMoney
        '
        Me.LabelMoney.AutoSize = True
        Me.LabelMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMoney.Location = New System.Drawing.Point(97, 23)
        Me.LabelMoney.Name = "LabelMoney"
        Me.LabelMoney.Size = New System.Drawing.Size(188, 31)
        Me.LabelMoney.TabIndex = 3
        Me.LabelMoney.Text = "Cash In Hand:"
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(1022, 306)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(200, 88)
        Me.ButtonStart.TabIndex = 4
        Me.ButtonStart.Text = "Start Game !"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'LabelFontSize
        '
        Me.LabelFontSize.AutoSize = True
        Me.LabelFontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFontSize.Location = New System.Drawing.Point(1018, 451)
        Me.LabelFontSize.Name = "LabelFontSize"
        Me.LabelFontSize.Size = New System.Drawing.Size(204, 31)
        Me.LabelFontSize.TabIndex = 5
        Me.LabelFontSize.Text = "Table Font Size"
        '
        'TextBoxFontSize
        '
        Me.TextBoxFontSize.Location = New System.Drawing.Point(1024, 497)
        Me.TextBoxFontSize.MaxLength = 3
        Me.TextBoxFontSize.Name = "TextBoxFontSize"
        Me.TextBoxFontSize.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxFontSize.TabIndex = 6
        '
        'LabelTotalMoney
        '
        Me.LabelTotalMoney.AutoSize = True
        Me.LabelTotalMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalMoney.Location = New System.Drawing.Point(628, 23)
        Me.LabelTotalMoney.Name = "LabelTotalMoney"
        Me.LabelTotalMoney.Size = New System.Drawing.Size(174, 31)
        Me.LabelTotalMoney.TabIndex = 7
        Me.LabelTotalMoney.Text = "Total Wealth:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(1024, 558)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(122, 29)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Text Bold"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxCash
        '
        Me.TextBoxCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCash.Location = New System.Drawing.Point(305, 23)
        Me.TextBoxCash.Name = "TextBoxCash"
        Me.TextBoxCash.ReadOnly = True
        Me.TextBoxCash.Size = New System.Drawing.Size(245, 38)
        Me.TextBoxCash.TabIndex = 9
        '
        'TextBoxWealth
        '
        Me.TextBoxWealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWealth.Location = New System.Drawing.Point(811, 23)
        Me.TextBoxWealth.Name = "TextBoxWealth"
        Me.TextBoxWealth.ReadOnly = True
        Me.TextBoxWealth.Size = New System.Drawing.Size(245, 38)
        Me.TextBoxWealth.TabIndex = 10
        '
        'ColumnStockName
        '
        Me.ColumnStockName.HeaderText = "Stock"
        Me.ColumnStockName.MaxInputLength = 300
        Me.ColumnStockName.Name = "ColumnStockName"
        Me.ColumnStockName.ReadOnly = True
        Me.ColumnStockName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnPrice
        '
        Me.ColumnPrice.HeaderText = "Price"
        Me.ColumnPrice.MaxInputLength = 8
        Me.ColumnPrice.Name = "ColumnPrice"
        Me.ColumnPrice.ReadOnly = True
        Me.ColumnPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnPriceChange
        '
        Me.ColumnPriceChange.HeaderText = "Price Change"
        Me.ColumnPriceChange.MaxInputLength = 8
        Me.ColumnPriceChange.Name = "ColumnPriceChange"
        Me.ColumnPriceChange.ReadOnly = True
        Me.ColumnPriceChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnNumberOwned
        '
        Me.ColumnNumberOwned.HeaderText = "Shares Held"
        Me.ColumnNumberOwned.MaxInputLength = 8
        Me.ColumnNumberOwned.Name = "ColumnNumberOwned"
        Me.ColumnNumberOwned.ReadOnly = True
        Me.ColumnNumberOwned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnValue
        '
        Me.ColumnValue.HeaderText = "Value Held"
        Me.ColumnValue.Name = "ColumnValue"
        Me.ColumnValue.ReadOnly = True
        Me.ColumnValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ColumnSell
        '
        Me.ColumnSell.HeaderText = "Sell"
        Me.ColumnSell.Name = "ColumnSell"
        Me.ColumnSell.ReadOnly = True
        '
        'ColumnBuy
        '
        Me.ColumnBuy.HeaderText = "Buy"
        Me.ColumnBuy.Name = "ColumnBuy"
        Me.ColumnBuy.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 948)
        Me.Controls.Add(Me.TextBoxWealth)
        Me.Controls.Add(Me.TextBoxCash)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LabelTotalMoney)
        Me.Controls.Add(Me.TextBoxFontSize)
        Me.Controls.Add(Me.LabelFontSize)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.LabelMoney)
        Me.Controls.Add(Me.LabelNextTime)
        Me.Controls.Add(Me.LabelCurrentTime)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "StonksRound"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelCurrentTime As Label
    Friend WithEvents LabelNextTime As Label
    Friend WithEvents LabelMoney As Label
    Friend WithEvents ButtonStart As Button
    Friend WithEvents LabelFontSize As Label
    Friend WithEvents TextBoxFontSize As TextBox
    Friend WithEvents LabelTotalMoney As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxCash As TextBox
    Friend WithEvents TextBoxWealth As TextBox
    Friend WithEvents ColumnStockName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPriceChange As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNumberOwned As DataGridViewTextBoxColumn
    Friend WithEvents ColumnValue As DataGridViewTextBoxColumn
    Friend WithEvents ColumnSell As DataGridViewButtonColumn
    Friend WithEvents ColumnBuy As DataGridViewButtonColumn
End Class
