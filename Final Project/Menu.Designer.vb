<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.radTuna = New System.Windows.Forms.RadioButton()
        Me.radLobster = New System.Windows.Forms.RadioButton()
        Me.radRigatoni = New System.Windows.Forms.RadioButton()
        Me.radChicken = New System.Windows.Forms.RadioButton()
        Me.grpSide = New System.Windows.Forms.GroupBox()
        Me.radRice = New System.Windows.Forms.RadioButton()
        Me.radTortilla = New System.Windows.Forms.RadioButton()
        Me.radSalad = New System.Windows.Forms.RadioButton()
        Me.radFries = New System.Windows.Forms.RadioButton()
        Me.grpDrink = New System.Windows.Forms.GroupBox()
        Me.radTea = New System.Windows.Forms.RadioButton()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.grpDessert = New System.Windows.Forms.GroupBox()
        Me.radPie = New System.Windows.Forms.RadioButton()
        Me.radKueh = New System.Windows.Forms.RadioButton()
        Me.radShake = New System.Windows.Forms.RadioButton()
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
        Me.grpEntree.Controls.Add(Me.radTuna)
        Me.grpEntree.Controls.Add(Me.radLobster)
        Me.grpEntree.Controls.Add(Me.radRigatoni)
        Me.grpEntree.Controls.Add(Me.radChicken)
        Me.grpEntree.Location = New System.Drawing.Point(29, 74)
        Me.grpEntree.Name = "grpEntree"
        Me.grpEntree.Size = New System.Drawing.Size(247, 170)
        Me.grpEntree.TabIndex = 1
        Me.grpEntree.TabStop = False
        Me.grpEntree.Text = "Entrees"
        '
        'radTuna
        '
        Me.radTuna.AutoSize = True
        Me.radTuna.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTuna.Location = New System.Drawing.Point(6, 133)
        Me.radTuna.Name = "radTuna"
        Me.radTuna.Size = New System.Drawing.Size(227, 22)
        Me.radTuna.TabIndex = 3
        Me.radTuna.TabStop = True
        Me.radTuna.Text = "Portuguese Tuna Casserole"
        Me.radTuna.UseVisualStyleBackColor = True
        '
        'radLobster
        '
        Me.radLobster.AutoSize = True
        Me.radLobster.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLobster.Location = New System.Drawing.Point(6, 105)
        Me.radLobster.Name = "radLobster"
        Me.radLobster.Size = New System.Drawing.Size(163, 22)
        Me.radLobster.TabIndex = 2
        Me.radLobster.TabStop = True
        Me.radLobster.Text = "Bohemian Lobster"
        Me.radLobster.UseVisualStyleBackColor = True
        '
        'radRigatoni
        '
        Me.radRigatoni.AutoSize = True
        Me.radRigatoni.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRigatoni.Location = New System.Drawing.Point(7, 77)
        Me.radRigatoni.Name = "radRigatoni"
        Me.radRigatoni.Size = New System.Drawing.Size(170, 22)
        Me.radRigatoni.TabIndex = 1
        Me.radRigatoni.TabStop = True
        Me.radRigatoni.Text = "Parmesan Rigatoni"
        Me.radRigatoni.UseVisualStyleBackColor = True
        '
        'radChicken
        '
        Me.radChicken.AutoSize = True
        Me.radChicken.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radChicken.Location = New System.Drawing.Point(7, 48)
        Me.radChicken.Name = "radChicken"
        Me.radChicken.Size = New System.Drawing.Size(149, 22)
        Me.radChicken.TabIndex = 0
        Me.radChicken.TabStop = True
        Me.radChicken.Text = "Sicilian Chicken "
        Me.radChicken.UseVisualStyleBackColor = True
        '
        'grpSide
        '
        Me.grpSide.Controls.Add(Me.radRice)
        Me.grpSide.Controls.Add(Me.radTortilla)
        Me.grpSide.Controls.Add(Me.radSalad)
        Me.grpSide.Controls.Add(Me.radFries)
        Me.grpSide.Location = New System.Drawing.Point(29, 261)
        Me.grpSide.Name = "grpSide"
        Me.grpSide.Size = New System.Drawing.Size(247, 165)
        Me.grpSide.TabIndex = 2
        Me.grpSide.TabStop = False
        Me.grpSide.Text = "Sides"
        '
        'radRice
        '
        Me.radRice.AutoSize = True
        Me.radRice.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRice.Location = New System.Drawing.Point(6, 131)
        Me.radRice.Name = "radRice"
        Me.radRice.Size = New System.Drawing.Size(104, 22)
        Me.radRice.TabIndex = 7
        Me.radRice.TabStop = True
        Me.radRice.Text = "Black Rice"
        Me.radRice.UseVisualStyleBackColor = True
        '
        'radTortilla
        '
        Me.radTortilla.AutoSize = True
        Me.radTortilla.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTortilla.Location = New System.Drawing.Point(7, 103)
        Me.radTortilla.Name = "radTortilla"
        Me.radTortilla.Size = New System.Drawing.Size(154, 22)
        Me.radTortilla.TabIndex = 6
        Me.radTortilla.TabStop = True
        Me.radTortilla.Text = "Tortilla Espanola"
        Me.radTortilla.UseVisualStyleBackColor = True
        '
        'radSalad
        '
        Me.radSalad.AutoSize = True
        Me.radSalad.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSalad.Location = New System.Drawing.Point(6, 75)
        Me.radSalad.Name = "radSalad"
        Me.radSalad.Size = New System.Drawing.Size(158, 22)
        Me.radSalad.TabIndex = 5
        Me.radSalad.TabStop = True
        Me.radSalad.Text = "Caesar Side Salad"
        Me.radSalad.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFries.Location = New System.Drawing.Point(7, 47)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(118, 22)
        Me.radFries.TabIndex = 4
        Me.radFries.TabStop = True
        Me.radFries.Text = "French Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'grpDrink
        '
        Me.grpDrink.Controls.Add(Me.radTea)
        Me.grpDrink.Controls.Add(Me.radSoda)
        Me.grpDrink.Controls.Add(Me.radWater)
        Me.grpDrink.Location = New System.Drawing.Point(395, 105)
        Me.grpDrink.Name = "grpDrink"
        Me.grpDrink.Size = New System.Drawing.Size(247, 139)
        Me.grpDrink.TabIndex = 3
        Me.grpDrink.TabStop = False
        Me.grpDrink.Text = "Drinks"
        '
        'radTea
        '
        Me.radTea.AutoSize = True
        Me.radTea.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTea.Location = New System.Drawing.Point(6, 102)
        Me.radTea.Name = "radTea"
        Me.radTea.Size = New System.Drawing.Size(99, 22)
        Me.radTea.TabIndex = 10
        Me.radTea.TabStop = True
        Me.radTea.Text = "Sweet Tea"
        Me.radTea.UseVisualStyleBackColor = True
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSoda.Location = New System.Drawing.Point(6, 74)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(63, 22)
        Me.radSoda.TabIndex = 9
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "Soda"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWater.Location = New System.Drawing.Point(6, 47)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(73, 22)
        Me.radWater.TabIndex = 8
        Me.radWater.TabStop = True
        Me.radWater.Text = "Water"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'grpDessert
        '
        Me.grpDessert.Controls.Add(Me.radPie)
        Me.grpDessert.Controls.Add(Me.radKueh)
        Me.grpDessert.Controls.Add(Me.radShake)
        Me.grpDessert.Location = New System.Drawing.Point(395, 292)
        Me.grpDessert.Name = "grpDessert"
        Me.grpDessert.Size = New System.Drawing.Size(247, 134)
        Me.grpDessert.TabIndex = 4
        Me.grpDessert.TabStop = False
        Me.grpDessert.Text = "Desserts"
        '
        'radPie
        '
        Me.radPie.AutoSize = True
        Me.radPie.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPie.Location = New System.Drawing.Point(6, 100)
        Me.radPie.Name = "radPie"
        Me.radPie.Size = New System.Drawing.Size(122, 22)
        Me.radPie.TabIndex = 13
        Me.radPie.TabStop = True
        Me.radPie.Text = "Banoffee Pie"
        Me.radPie.UseVisualStyleBackColor = True
        '
        'radKueh
        '
        Me.radKueh.AutoSize = True
        Me.radKueh.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radKueh.Location = New System.Drawing.Point(6, 72)
        Me.radKueh.Name = "radKueh"
        Me.radKueh.Size = New System.Drawing.Size(116, 22)
        Me.radKueh.TabIndex = 12
        Me.radKueh.TabStop = True
        Me.radKueh.Text = "Kueh Dadar"
        Me.radKueh.UseVisualStyleBackColor = True
        '
        'radShake
        '
        Me.radShake.AutoSize = True
        Me.radShake.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radShake.Location = New System.Drawing.Point(6, 44)
        Me.radShake.Name = "radShake"
        Me.radShake.Size = New System.Drawing.Size(198, 22)
        Me.radShake.TabIndex = 11
        Me.radShake.TabStop = True
        Me.radShake.Text = "Argentinian Milkshake"
        Me.radShake.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 475)
        Me.Controls.Add(Me.grpDessert)
        Me.Controls.Add(Me.grpDrink)
        Me.Controls.Add(Me.grpSide)
        Me.Controls.Add(Me.grpEntree)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(9)
        Me.Name = "Menu"
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
    Friend WithEvents radTuna As RadioButton
    Friend WithEvents radLobster As RadioButton
    Friend WithEvents radRigatoni As RadioButton
    Friend WithEvents radChicken As RadioButton
    Friend WithEvents grpSide As GroupBox
    Friend WithEvents radRice As RadioButton
    Friend WithEvents radTortilla As RadioButton
    Friend WithEvents radSalad As RadioButton
    Friend WithEvents radFries As RadioButton
    Friend WithEvents grpDrink As GroupBox
    Friend WithEvents radTea As RadioButton
    Friend WithEvents radSoda As RadioButton
    Friend WithEvents radWater As RadioButton
    Friend WithEvents grpDessert As GroupBox
    Friend WithEvents radPie As RadioButton
    Friend WithEvents radKueh As RadioButton
    Friend WithEvents radShake As RadioButton
End Class
