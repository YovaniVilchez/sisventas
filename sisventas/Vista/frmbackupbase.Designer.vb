﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbackupbase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Location = New System.Drawing.Point(81, 50)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(245, 61)
        Me.btnbackup.TabIndex = 0
        Me.btnbackup.Text = "Backup Base"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'frmbackupbase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 164)
        Me.Controls.Add(Me.btnbackup)
        Me.Name = "frmbackupbase"
        Me.Text = ".:. Backup de la Base de Datos .:."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
End Class
