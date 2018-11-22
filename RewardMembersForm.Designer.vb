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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Showcustomers = New System.Windows.Forms.Button()
        Me.gold = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.platinum = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Empoyee = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddToCart_Rewards = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REWARDS"
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
        Me.gold.Location = New System.Drawing.Point(6, 69)
        Me.gold.Name = "gold"
        Me.gold.Size = New System.Drawing.Size(48, 17)
        Me.gold.TabIndex = 5
        Me.gold.Text = "Gold"
        Me.gold.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = " The highest reward! With a one time fee of 100$, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you get a shipping rate of $2" &
    ".50 on any order henceforth! "
        '
        'platinum
        '
        Me.platinum.AutoSize = True
        Me.platinum.Location = New System.Drawing.Point(6, 119)
        Me.platinum.Name = "platinum"
        Me.platinum.Size = New System.Drawing.Size(66, 17)
        Me.platinum.TabIndex = 7
        Me.platinum.Text = "Platinum"
        Me.platinum.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Become a platinum member today! With a one time fee " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of 80$, you get a discount " &
    "rate of 2% " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on any order henceforth!"
        '
        'Empoyee
        '
        Me.Empoyee.AutoSize = True
        Me.Empoyee.Location = New System.Drawing.Point(6, 161)
        Me.Empoyee.Name = "Empoyee"
        Me.Empoyee.Size = New System.Drawing.Size(244, 17)
        Me.Empoyee.TabIndex = 9
        Me.Empoyee.Text = "Employee (can only add if you're an employee)"
        Me.Empoyee.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(355, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "$100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "$80"
        '
        'AddToCart_Rewards
        '
        Me.AddToCart_Rewards.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.AddToCart_Rewards.Location = New System.Drawing.Point(174, 233)
        Me.AddToCart_Rewards.Name = "AddToCart_Rewards"
        Me.AddToCart_Rewards.Size = New System.Drawing.Size(101, 26)
        Me.AddToCart_Rewards.TabIndex = 12
        Me.AddToCart_Rewards.Text = "ADD TO CART"
        Me.AddToCart_Rewards.UseVisualStyleBackColor = True
        '
        'RewardMembersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 314)
        Me.Controls.Add(Me.AddToCart_Rewards)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Empoyee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.platinum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gold)
        Me.Controls.Add(Me.Showcustomers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RewardMembersForm"
        Me.Text = "RewardMembersForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Showcustomers As Button
    Friend WithEvents gold As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents platinum As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Empoyee As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddToCart_Rewards As Button
End Class
