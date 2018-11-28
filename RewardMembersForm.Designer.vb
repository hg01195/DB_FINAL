<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RewardMembersForm
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
        Me.Showcustomers = New System.Windows.Forms.Button()
        Me.gold = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.platinum = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddToCart_Rewards = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Showcustomers
        '
        Me.Showcustomers.AccessibleName = "showcustomers"
        Me.Showcustomers.Location = New System.Drawing.Point(189, 313)
        Me.Showcustomers.Name = "Showcustomers"
        Me.Showcustomers.Size = New System.Drawing.Size(75, 23)
        Me.Showcustomers.TabIndex = 2
        Me.Showcustomers.Text = "SHOW"
        Me.Showcustomers.UseVisualStyleBackColor = True
        '
        'gold
        '
        Me.gold.AutoSize = True
        Me.gold.Location = New System.Drawing.Point(6, 26)
        Me.gold.Name = "gold"
        Me.gold.Size = New System.Drawing.Size(48, 17)
        Me.gold.TabIndex = 5
        Me.gold.Text = "Gold"
        Me.gold.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = " The highest reward! With a one time fee of 100$, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you get a shipping rate of $2" &
    ".50 on any order henceforth! "
        '
        'platinum
        '
        Me.platinum.AutoSize = True
        Me.platinum.Location = New System.Drawing.Point(6, 76)
        Me.platinum.Name = "platinum"
        Me.platinum.Size = New System.Drawing.Size(66, 17)
        Me.platinum.TabIndex = 7
        Me.platinum.Text = "Platinum"
        Me.platinum.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Become a platinum member today! With a one time fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of 80$, you get a discount " &
    "rate of 2% " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on any order henceforth!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(355, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "$100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "$80"
        '
        'AddToCart_Rewards
        '
        Me.AddToCart_Rewards.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.AddToCart_Rewards.Location = New System.Drawing.Point(136, 157)
        Me.AddToCart_Rewards.Name = "AddToCart_Rewards"
        Me.AddToCart_Rewards.Size = New System.Drawing.Size(101, 26)
        Me.AddToCart_Rewards.TabIndex = 12
        Me.AddToCart_Rewards.Text = "ADD TO CART"
        Me.AddToCart_Rewards.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(154, 188)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RewardMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 228)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddToCart_Rewards)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.platinum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gold)
        Me.Controls.Add(Me.Showcustomers)
        Me.Name = "RewardMembersForm"
        Me.Text = "RewardMembersForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Showcustomers As Button
    Friend WithEvents gold As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents platinum As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddToCart_Rewards As Button
    Friend WithEvents Button1 As Button
End Class
