﻿Public Class frmLab6
    Private Sub chkCar_Click(sender As Object, e As EventArgs) Handles chkCar.Click
        If chkCar.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            chkInsurance.Checked = True
            chkRaw.Checked = True
            chkRegis.Checked = True
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblPrice.Text)
        Else
            If MessageBox.Show("ต้องการยกเลิกการซื้อรถใช่หรือไม่", "จะยกเลิกหรอ", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                chkInsurance.Checked = False
                chkRaw.Checked = False
                chkRegis.Checked = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                lblNetPrice.Text = ""
            Else
                chkCar.Checked = True
            End If
        End If
    End Sub

    Private Sub chkInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles chkInsurance.CheckedChanged
        If chkInsurance.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblPromotion1.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblPromotion1.Text)
        End If
    End Sub

    Private Sub chkRaw_CheckedChanged(sender As Object, e As EventArgs) Handles chkRaw.CheckedChanged
        If chkRaw.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblPromotion2.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblPromotion2.Text)
        End If
    End Sub

    Private Sub chkRegis_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegis.CheckedChanged
        If chkRegis.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblPromotion3.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblPromotion3.Text)
        End If
    End Sub

    Private Sub chkOption1_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption1.CheckedChanged
        If chkOption1.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblOption1.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblOption1.Text)
        End If
    End Sub

    Private Sub chkOption2_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption2.CheckedChanged
        If chkOption2.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblOption2.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblOption2.Text)
        End If
    End Sub

    Private Sub chkOption3_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption3.CheckedChanged
        If chkOption3.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblOption3.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblOption3.Text)
        End If
    End Sub

    Private Sub chkOption4_CheckedChanged(sender As Object, e As EventArgs) Handles chkOption4.CheckedChanged
        If chkOption4.Checked = True Then
            lblNetPrice.Text = Val(lblNetPrice.Text) + Val(lblOption4.Text)
        Else
            lblNetPrice.Text = Val(lblNetPrice.Text) - Val(lblOption4.Text)
        End If
    End Sub
End Class