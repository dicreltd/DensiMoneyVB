<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonBuy = New System.Windows.Forms.Button()
        Me.buttonCharge = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.textBoxMoney = New System.Windows.Forms.TextBox()
        Me.labelPoint = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.labelKingaku = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonBuy
        '
        Me.buttonBuy.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonBuy.Location = New System.Drawing.Point(160, 144)
        Me.buttonBuy.Name = "buttonBuy"
        Me.buttonBuy.Size = New System.Drawing.Size(100, 41)
        Me.buttonBuy.TabIndex = 16
        Me.buttonBuy.Text = "購入"
        Me.buttonBuy.UseVisualStyleBackColor = True
        '
        'buttonCharge
        '
        Me.buttonCharge.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.buttonCharge.Location = New System.Drawing.Point(40, 143)
        Me.buttonCharge.Name = "buttonCharge"
        Me.buttonCharge.Size = New System.Drawing.Size(100, 41)
        Me.buttonCharge.TabIndex = 15
        Me.buttonCharge.Text = "チャージ"
        Me.buttonCharge.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label6.Location = New System.Drawing.Point(204, 98)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(29, 20)
        Me.label6.TabIndex = 14
        Me.label6.Text = "円"
        '
        'textBoxMoney
        '
        Me.textBoxMoney.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textBoxMoney.Location = New System.Drawing.Point(83, 96)
        Me.textBoxMoney.Name = "textBoxMoney"
        Me.textBoxMoney.Size = New System.Drawing.Size(100, 27)
        Me.textBoxMoney.TabIndex = 13
        '
        'labelPoint
        '
        Me.labelPoint.AutoSize = True
        Me.labelPoint.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.labelPoint.Location = New System.Drawing.Point(90, 51)
        Me.labelPoint.Name = "labelPoint"
        Me.labelPoint.Size = New System.Drawing.Size(36, 20)
        Me.labelPoint.TabIndex = 12
        Me.labelPoint.Text = "0pt"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(16, 51)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 20)
        Me.label3.TabIndex = 11
        Me.label3.Text = "ポイント"
        '
        'labelKingaku
        '
        Me.labelKingaku.AutoSize = True
        Me.labelKingaku.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.labelKingaku.Location = New System.Drawing.Point(90, 9)
        Me.labelKingaku.Name = "labelKingaku"
        Me.labelKingaku.Size = New System.Drawing.Size(39, 20)
        Me.labelKingaku.TabIndex = 10
        Me.labelKingaku.Text = "0円"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 20)
        Me.label1.TabIndex = 9
        Me.label1.Text = "残金"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 210)
        Me.Controls.Add(Me.buttonBuy)
        Me.Controls.Add(Me.buttonCharge)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.textBoxMoney)
        Me.Controls.Add(Me.labelPoint)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.labelKingaku)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "電子マネー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents buttonBuy As Button
    Private WithEvents buttonCharge As Button
    Private WithEvents label6 As Label
    Private WithEvents textBoxMoney As TextBox
    Private WithEvents labelPoint As Label
    Private WithEvents label3 As Label
    Private WithEvents labelKingaku As Label
    Private WithEvents label1 As Label
End Class
