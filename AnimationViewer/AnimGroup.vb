Public Class AnimGroup
    Public Property Name As String
    Public Property Frames As New List(Of Integer)
    Public Function ToXml() As String
        Dim d As New Text.StringBuilder
        Using w As Xml.XmlWriter = Xml.XmlWriter.Create(d)
            w.WriteStartElement("AnimGroup")
            w.WriteAttributeString("name", Name)
            For Each item In Frames
                w.WriteStartElement("AnimSequenceIndex")
                w.WriteValue(item)
                w.WriteEndElement()
            Next
            w.WriteEndElement()
        End Using
        Return d.ToString
    End Function
    Public Shared Function FromXml(Node As Xml.XmlNode) As AnimGroup
        Dim a As New AnimGroup
        a.Name = Node.Attributes("name").Value
        For Each item As Xml.XmlNode In Node.SelectNodes("AnimSequenceIndex")
            a.Frames.Add(CInt(item.InnerText))
        Next
        Return a
    End Function
End Class