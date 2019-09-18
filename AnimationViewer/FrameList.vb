Public Class FrameList
    Public Property FrameGroups As New List(Of FrameGroup)
    Public Shared Function FromXml(XmlString As String) As FrameList
        Dim f As New FrameList
        Dim d As New Xml.XmlDocument
        d.LoadXml(XmlString)
        For Each item As Xml.XmlNode In d.SelectNodes("FrameList/FrameGroup")
            f.FrameGroups.Add(FrameGroup.FromXml(item))
        Next
        Return f
    End Function
End Class