Public Class AnimData
    Public Property AnimGroupData As New List(Of AnimGroup)
    Public Property AnimSequenceData As New List(Of AnimSequence)
    Public Shared Function FromXml(XmlString As String) As AnimData
        Dim a As New AnimData
        Dim d As New Xml.XmlDocument
        d.LoadXml(XmlString)
        For Each item As Xml.XmlNode In d.SelectNodes("AnimData/AnimGroupTable/AnimGroup")
            a.AnimGroupData.Add(AnimGroup.FromXml(item))
        Next
        For Each item As Xml.XmlNode In d.SelectSingleNode("AnimData/AnimSequenceTable")
            If Not item.OuterXml.StartsWith("<!") Then
                a.AnimSequenceData.Add(AnimSequence.FromXml(item))
            End If
        Next
        Return a
    End Function
End Class