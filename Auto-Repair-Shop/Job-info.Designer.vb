<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Job_info
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
        Me.CustomerName_Box = New System.Windows.Forms.TextBox()
        Me.Hour_box = New System.Windows.Forms.TextBox()
        Me.Charged_box = New System.Windows.Forms.TextBox()
        Me.JobNumber_Box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Calculate_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Hour_Charge = New System.Windows.Forms.Label()
        Me.Total_Label = New System.Windows.Forms.Label()
        Me.Taxes_Label = New System.Windows.Forms.Label()
        Me.Charges_Label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerName_Box
        '
        Me.CustomerName_Box.Location = New System.Drawing.Point(104, 29)
        Me.CustomerName_Box.Name = "CustomerName_Box"
        Me.CustomerName_Box.Size = New System.Drawing.Size(100, 20)
        Me.CustomerName_Box.TabIndex = 0
        '
        'Hour_box
        '
        Me.Hour_box.Location = New System.Drawing.Point(255, 122)
        Me.Hour_box.Name = "Hour_box"
        Me.Hour_box.Size = New System.Drawing.Size(70, 20)
        Me.Hour_box.TabIndex = 3
        '
        'Charged_box
        '
        Me.Charged_box.Location = New System.Drawing.Point(87, 122)
        Me.Charged_box.Name = "Charged_box"
        Me.Charged_box.Size = New System.Drawing.Size(65, 20)
        Me.Charged_box.TabIndex = 2
        '
        'JobNumber_Box
        '
        Me.JobNumber_Box.Location = New System.Drawing.Point(104, 55)
        Me.JobNumber_Box.Name = "JobNumber_Box"
        Me.JobNumber_Box.Size = New System.Drawing.Size(100, 20)
        Me.JobNumber_Box.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Part Charge"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hours of Labor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Job #"
        '
        'Calculate_Button
        '
        Me.Calculate_Button.Location = New System.Drawing.Point(37, 182)
        Me.Calculate_Button.Name = "Calculate_Button"
        Me.Calculate_Button.Size = New System.Drawing.Size(91, 27)
        Me.Calculate_Button.TabIndex = 4
        Me.Calculate_Button.Text = "Calculate"
        Me.Calculate_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Location = New System.Drawing.Point(255, 27)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(75, 23)
        Me.Clear_Button.TabIndex = 6
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Ok_Button
        '
        Me.Ok_Button.Location = New System.Drawing.Point(37, 218)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(91, 27)
        Me.Ok_Button.TabIndex = 5
        Me.Ok_Button.Text = "OK"
        Me.Ok_Button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Hour_Charge)
        Me.GroupBox1.Controls.Add(Me.Total_Label)
        Me.GroupBox1.Controls.Add(Me.Taxes_Label)
        Me.GroupBox1.Controls.Add(Me.Charges_Label)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Hour_Charge
        '
        Me.Hour_Charge.AutoSize = True
        Me.Hour_Charge.Location = New System.Drawing.Point(7, 45)
        Me.Hour_Charge.Name = "Hour_Charge"
        Me.Hour_Charge.Size = New System.Drawing.Size(77, 13)
        Me.Hour_Charge.TabIndex = 3
        Me.Hour_Charge.Text = "Hourly Charge:"
        '
        'Total_Label
        '
        Me.Total_Label.AutoSize = True
        Me.Total_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Label.Location = New System.Drawing.Point(6, 99)
        Me.Total_Label.Name = "Total_Label"
        Me.Total_Label.Size = New System.Drawing.Size(77, 24)
        Me.Total_Label.TabIndex = 2
        Me.Total_Label.Text = "TOTAL:"
        '
        'Taxes_Label
        '
        Me.Taxes_Label.AutoSize = True
        Me.Taxes_Label.Location = New System.Drawing.Point(6, 70)
        Me.Taxes_Label.Name = "Taxes_Label"
        Me.Taxes_Label.Size = New System.Drawing.Size(39, 13)
        Me.Taxes_Label.TabIndex = 1
        Me.Taxes_Label.Text = "Taxes:"
        '
        'Charges_Label
        '
        Me.Charges_Label.AutoSize = True
        Me.Charges_Label.Location = New System.Drawing.Point(7, 20)
        Me.Charges_Label.Name = "Charges_Label"
        Me.Charges_Label.Size = New System.Drawing.Size(66, 13)
        Me.Charges_Label.TabIndex = 0
        Me.Charges_Label.Text = "Part Charge:"
        '
        'Job_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 299)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Ok_Button)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Calculate_Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JobNumber_Box)
        Me.Controls.Add(Me.Charged_box)
        Me.Controls.Add(Me.Hour_box)
        Me.Controls.Add(Me.CustomerName_Box)
        Me.Name = "Job_info"
        Me.Text = "Job_info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerName_Box As System.Windows.Forms.TextBox
    Friend WithEvents Hour_box As System.Windows.Forms.TextBox
    Friend WithEvents Charged_box As System.Windows.Forms.TextBox
    Friend WithEvents JobNumber_Box As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Calculate_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_Button As System.Windows.Forms.Button
    Friend WithEvents Ok_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Total_Label As System.Windows.Forms.Label
    Friend WithEvents Taxes_Label As System.Windows.Forms.Label
    Friend WithEvents Charges_Label As System.Windows.Forms.Label

    Private Sub Calculate_Button_Click(sender As Object, e As EventArgs) Handles Calculate_Button.Click
        'Declares Variables
        Static TAX_RATE_CONST = 0.08
        Static HOURLY_RATE_CONST = 50
        Dim usrName, jobNum As String
        Dim partCharge, hours, hourCharge, taxes, total As Double

        If CustomerName_Box.Text = "" Or JobNumber_Box.Text = "" Or Charged_box.Text = "" Or Hour_box.Text = "" Then
            MessageBox.Show("Invalid Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Gives Default values to uninitialized Variables
            usrName = "Unknown"
            jobNum = "N/A"
            partCharge = 0.0
            hours = 0


            'Populates Text-Box content into appropriate Variable components
            usrName = CustomerName_Box.Text
            jobNum = JobNumber_Box.Text
            partCharge = Double.Parse(Charged_box.Text)
            hours = Double.Parse(Hour_box.Text)

            'Calculating Variables
            hourCharge = hours * HOURLY_RATE_CONST
            taxes = partCharge * TAX_RATE_CONST
            total = hourCharge + partCharge + taxes


            Debug.WriteLine("Customer Name: " & usrName)
            Debug.WriteLine("Job Number: " & jobNum)
            Debug.WriteLine("Part charged: " & partCharge)
            Debug.WriteLine("Hours Worked: " & hours)
            Debug.WriteLine("Hour Charge: " & hourCharge)
            Debug.WriteLine("Taxes: " & taxes)
            Debug.WriteLine("Total: " & total)
            GroupBox1.Visible = True

            Charges_Label.Text = ("Part Charges: " & partCharge.ToString("C"))
            Taxes_Label.Text = ("Taxes: " & taxes.ToString("C"))
            Hour_Charge.Text = ("Hourly Charge: " & hourCharge.ToString("C"))
            Total_Label.Text = ("TOTAL: " & total.ToString("C"))
        End If

    End Sub

    Private Sub Job_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Charges_Label.Text = "Charges:"
        Taxes_Label.Text = "Taxes:"
        Total_Label.Text = "TOTAL:"
        CustomerName_Box.Text = ""
        JobNumber_Box.Text = ""
        Charged_box.Text = ""
        Hour_box.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        Me.Hide()

    End Sub
    Friend WithEvents Hour_Charge As System.Windows.Forms.Label
End Class
