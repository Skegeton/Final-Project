<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpEntree = New System.Windows.Forms.GroupBox()
        Me.grpSide = New System.Windows.Forms.GroupBox()
        Me.grpDrink = New System.Windows.Forms.GroupBox()
        Me.grpDessert = New System.Windows.Forms.GroupBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkRigatoni = New System.Windows.Forms.CheckBox()
        Me.chkLobster = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkSalad = New System.Windows.Forms.CheckBox()
        Me.chkTortilla = New System.Windows.Forms.CheckBox()
        Me.chkRice = New System.Windows.Forms.CheckBox()
        Me.chkWater = New System.Windows.Forms.CheckBox()
        Me.chkSoda = New System.Windows.Forms.CheckBox()
        Me.chkTea = New System.Windows.Forms.CheckBox()
        Me.chkShake = New System.Windows.Forms.CheckBox()
        Me.chkKueh = New System.Windows.Forms.CheckBox()
        Me.chkPie = New System.Windows.Forms.CheckBox()
        Me.grpEntree.SuspendLayout()
        Me.grpSide.SuspendLayout()
        Me.grpDrink.SuspendLayout()
        Me.grpDessert.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'grpEntree
        '
        Me.grpEntree.Controls.Add(Me.chkTuna)
        Me.grpEntree.Controls.Add(Me.chkLobster)
        Me.grpEntree.Controls.Add(Me.chkRigatoni)
        Me.grpEntree.Controls.Add(Me.chkChicken)
        Me.grpEntree.Location = New System.Drawing.Point(29, 74)
        Me.grpEntree.Name = "grpEntree"
        Me.grpEntree.Size = New System.Drawing.Size(247, 170)
        Me.grpEntree.TabIndex = 1
        Me.grpEntree.TabStop = False
        Me.grpEntree.Text = "Entrees"
        '
        'grpSide
        '
        Me.grpSide.Controls.Add(Me.chkRice)
        Me.grpSide.Controls.Add(Me.chkTortilla)
        Me.grpSide.Controls.Add(Me.chkSalad)
        Me.grpSide.Controls.Add(Me.chkFries)
        Me.grpSide.Location = New System.Drawing.Point(29, 261)
        Me.grpSide.Name = "grpSide"
        Me.grpSide.Size = New System.Drawing.Size(247, 165)
        Me.grpSide.TabIndex = 2
        Me.grpSide.TabStop = False
        Me.grpSide.Text = "Sides"
        '
        'grpDrink
        '
        Me.grpDrink.Controls.Add(Me.chkTea)
        Me.grpDrink.Controls.Add(Me.chkSoda)
        Me.grpDrink.Controls.Add(Me.chkWater)
        Me.grpDrink.Location = New System.Drawing.Point(395, 105)
        Me.grpDrink.Name = "grpDrink"
        Me.grpDrink.Size = New System.Drawing.Size(247, 139)
        Me.grpDrink.TabIndex = 3
        Me.grpDrink.TabStop = False
        Me.grpDrink.Text = "Drinks"
        '
        'grpDessert
        '
        Me.grpDessert.Controls.Add(Me.chkPie)
        Me.grpDessert.Controls.Add(Me.chkKueh)
        Me.grpDessert.Controls.Add(Me.chkShake)
        Me.grpDessert.Location = New System.Drawing.Point(395, 292)
        Me.grpDessert.Name = "grpDessert"
        Me.grpDessert.Size = New System.Drawing.Size(247, 134)
        Me.grpDessert.TabIndex = 4
        Me.grpDessert.TabStop = False
        Me.grpDessert.Text = "Desserts"
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(295, 402)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(82, 24)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChicken.Location = New System.Drawing.Point(7, 47)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(146, 22)
        Me.chkChicken.TabIndex = 6
        Me.chkChicken.Text = "Sicilian Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkRigatoni
        '
        Me.chkRigatoni.AutoSize = True
        Me.chkRigatoni.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRigatoni.Location = New System.Drawing.Point(7, 75)
        Me.chkRigatoni.Name = "chkRigatoni"
        Me.chkRigatoni.Size = New System.Drawing.Size(171, 22)
        Me.chkRigatoni.TabIndex = 7
        Me.chkRigatoni.Text = "Parmesan Rigatoni"
        Me.chkRigatoni.UseVisualStyleBackColor = True
        '
        'chkLobster
        '
        Me.chkLobster.AutoSize = True
        Me.chkLobster.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLobster.Location = New System.Drawing.Point(7, 106)
        Me.chkLobster.Name = "chkLobster"
        Me.chkLobster.Size = New System.Drawing.Size(164, 22)
        Me.chkLobster.TabIndex = 8
        Me.chkLobster.Text = "Bohemian Lobster"
        Me.chkLobster.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTuna.Location = New System.Drawing.Point(7, 134)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(228, 22)
        Me.chkTuna.TabIndex = 9
        Me.chkTuna.Text = "Portuguese Tuna Casserole"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFries.Location = New System.Drawing.Point(7, 47)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(119, 22)
        Me.chkFries.TabIndex = 7
        Me.chkFries.Text = "French Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkSalad
        '
        Me.chkSalad.AutoSize = True
        Me.chkSalad.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalad.Location = New System.Drawing.Point(7, 75)
        Me.chkSalad.Name = "chkSalad"
        Me.chkSalad.Size = New System.Drawing.Size(159, 22)
        Me.chkSalad.TabIndex = 8
        Me.chkSalad.Text = "Caesar Side Salad"
        Me.chkSalad.UseVisualStyleBackColor = True
        '
        'chkTortilla
        '
        Me.chkTortilla.AutoSize = True
        Me.chkTortilla.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTortilla.Location = New System.Drawing.Point(7, 103)
        Me.chkTortilla.Name = "chkTortilla"
        Me.chkTortilla.Size = New System.Drawing.Size(155, 22)
        Me.chkTortilla.TabIndex = 9
        Me.chkTortilla.Text = "Tortilla Espanola"
        Me.chkTortilla.UseVisualStyleBackColor = True
        '
        'chkRice
        '
        Me.chkRice.AutoSize = True
        Me.chkRice.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRice.Location = New System.Drawing.Point(7, 131)
        Me.chkRice.Name = "chkRice"
        Me.chkRice.Size = New System.Drawing.Size(105, 22)
        Me.chkRice.TabIndex = 10
        Me.chkRice.Text = "Black Rice"
        Me.chkRice.UseVisualStyleBackColor = True
        '
        'chkWater
        '
        Me.chkWater.AutoSize = True
        Me.chkWater.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWater.Location = New System.Drawing.Point(6, 47)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(74, 22)
        Me.chkWater.TabIndex = 11
        Me.chkWater.Text = "Water"
        Me.chkWater.UseVisualStyleBackColor = True
        '
        'chkSoda
        '
        Me.chkSoda.AutoSize = True
        Me.chkSoda.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoda.Location = New System.Drawing.Point(6, 74)
        Me.chkSoda.Name = "chkSoda"
        Me.chkSoda.Size = New System.Drawing.Size(64, 22)
        Me.chkSoda.TabIndex = 12
        Me.chkSoda.Text = "Soda"
        Me.chkSoda.UseVisualStyleBackColor = True
        '
        'chkTea
        '
        Me.chkTea.AutoSize = True
        Me.chkTea.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTea.Location = New System.Drawing.Point(6, 102)
        Me.chkTea.Name = "chkTea"
        Me.chkTea.Size = New System.Drawing.Size(100, 22)
        Me.chkTea.TabIndex = 13
        Me.chkTea.Text = "Sweet Tea"
        Me.chkTea.UseVisualStyleBackColor = True
        '
        'chkShake
        '
        Me.chkShake.AutoSize = True
        Me.chkShake.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShake.Location = New System.Drawing.Point(6, 47)
        Me.chkShake.Name = "chkShake"
        Me.chkShake.Size = New System.Drawing.Size(199, 22)
        Me.chkShake.TabIndex = 14
        Me.chkShake.Text = "Argentinian Milkshake"
        Me.chkShake.UseVisualStyleBackColor = True
        '
        'chkKueh
        '
        Me.chkKueh.AutoSize = True
        Me.chkKueh.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKueh.Location = New System.Drawing.Point(6, 72)
        Me.chkKueh.Name = "chkKueh"
        Me.chkKueh.Size = New System.Drawing.Size(117, 22)
        Me.chkKueh.TabIndex = 15
        Me.chkKueh.Text = "Kueh Dadar"
        Me.chkKueh.UseVisualStyleBackColor = True
        '
        'chkPie
        '
        Me.chkPie.AutoSize = True
        Me.chkPie.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPie.Location = New System.Drawing.Point(6, 100)
        Me.chkPie.Name = "chkPie"
        Me.chkPie.Size = New System.Drawing.Size(123, 22)
        Me.chkPie.TabIndex = 16
        Me.chkPie.Text = "Banoffee Pie"
        Me.chkPie.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 475)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.grpDessert)
        Me.Controls.Add(Me.grpDrink)
        Me.Controls.Add(Me.grpSide)
        Me.Controls.Add(Me.grpEntree)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(9)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.grpEntree.ResumeLayout(False)
        Me.grpEntree.PerformLayout()
        Me.grpSide.ResumeLayout(False)
        Me.grpSide.PerformLayout()
        Me.grpDrink.ResumeLayout(False)
        Me.grpDrink.PerformLayout()
        Me.grpDessert.ResumeLayout(False)
        Me.grpDessert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpEntree As GroupBox
    Friend WithEvents grpSide As GroupBox
    Friend WithEvents grpDrink As GroupBox
    Friend WithEvents grpDessert As GroupBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents chkChicken As CheckBox
    Friend WithEvents chkLobster As CheckBox
    Friend WithEvents chkRigatoni As CheckBox
    Friend WithEvents chkTuna As CheckBox
    Friend WithEvents chkRice As CheckBox
    Friend WithEvents chkTortilla As CheckBox
    Friend WithEvents chkSalad As CheckBox
    Friend WithEvents chkFries As CheckBox
    Friend WithEvents chkTea As CheckBox
    Friend WithEvents chkSoda As CheckBox
    Friend WithEvents chkWater As CheckBox
    Friend WithEvents chkKueh As CheckBox
    Friend WithEvents chkShake As CheckBox
    Friend WithEvents chkPie As CheckBox
End Class
