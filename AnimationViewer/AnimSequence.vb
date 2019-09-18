Public Class AnimSequence
    Public Property Frames As New List(Of AnimFrame)
    Public Shared Function FromXml(XmlNode As Xml.XmlNode) As AnimSequence
        Dim a As New AnimSequence
        For Each item As Xml.XmlNode In XmlNode.SelectNodes("AnimFrame")
            a.Frames.Add(AnimFrame.FromXml(item))
        Next
        Return a
    End Function
End Class