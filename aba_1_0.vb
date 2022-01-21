    Public Function appendobjectarray(fbytes As Object(), cipherbytes As Object()) As Object()
        Dim nfbytes(1 + (fbytes.Length - 1) + (cipherbytes.Length - 1)) As Object
        Dim qehg As Integer = 0
        For huah As Integer = 0 To nfbytes.Length - 1
            If Not huah > fbytes.Length - 1 Then
                nfbytes(huah) = fbytes(huah)
            Else
                For qweg As Integer = 0 To cipherbytes.Length - 1 Step +0
                    Dim hoh As Integer = ((nfbytes.Length - 1) - (cipherbytes.Length - 1)) + qweg
                    nfbytes(hoh) = cipherbytes(qehg)
                    qehg = qehg + 1
                    qweg = qweg + 1
                Next
                Exit For
            End If
        Next
        Return nfbytes
    End Function

    Public Function appendobjectarray(fbytes As Object, onebyte As Object) As Object()
        Dim nfbytes((fbytes.Length - 1) + 1) As Object
        For huah As Integer = 0 To nfbytes.Length - 1
            If Not huah > fbytes.Length - 1 Then
                nfbytes(huah) = fbytes(huah)
            Else
                nfbytes(nfbytes.Length - 1) = onebyte
                Exit For
            End If
        Next
        Return nfbytes
    End Function
