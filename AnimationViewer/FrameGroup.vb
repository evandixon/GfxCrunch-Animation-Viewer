Public Class FrameGroup
    Public Property Frames As New List(Of Frame)
    Public Shared Function FromXml(XmlNode As Xml.XmlNode) As FrameGroup
        Dim f As New FrameGroup
        For Each item As Xml.XmlNode In XmlNode.SelectNodes("Frame")
            f.Frames.Add(Frame.FromXml(item))
        Next
        Return f
    End Function
End Class
