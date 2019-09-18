Public Class AnimFrame
    Public Property frameDuration As UInt16
    Public Property metaFrmGrpIndex As UInt16
    Public Property sprOffsetX As Int16
    Public Property sprOffsetY As Int16
    Public Property shadowOffsetX As Int16
    Public Property shadowOffsetY As Int16
    Public Function ToXml() As String
        Dim d As New Text.StringBuilder
        Using w As Xml.XmlWriter = Xml.XmlWriter.Create(d)
            w.WriteStartElement("AnimFrame")

            w.WriteStartElement("Duration")
            w.WriteValue(frameDuration)
            w.WriteEndElement()

            w.WriteStartElement("MetaFrameGroupIndex")
            w.WriteValue(metaFrmGrpIndex)
            w.WriteEndElement()

            w.WriteStartElement("Sprite")

            w.WriteStartElement("XOffset")
            w.WriteValue(sprOffsetX)
            w.WriteEndElement()

            w.WriteStartElement("YOffset")
            w.WriteValue(sprOffsetY)
            w.WriteEndElement()

            w.WriteEndElement()

            w.WriteStartElement("Shadow")

            w.WriteStartElement("XOffset")
            w.WriteValue(shadowOffsetX)
            w.WriteEndElement()

            w.WriteStartElement("YOffset")
            w.WriteValue(shadowOffsetY)
            w.WriteEndElement()

            w.WriteEndElement()

            w.WriteEndElement()
        End Using
        Return d.ToString
    End Function
    Public Shared Function FromXml(Node As Xml.XmlNode) As AnimFrame
        Dim a As New AnimFrame
        a.frameDuration = Node.SelectSingleNode("Duration").InnerText
        a.metaFrmGrpIndex = Node.SelectSingleNode("MetaFrameGroupIndex").InnerText
        a.sprOffsetX = Node.SelectSingleNode("Sprite/XOffset").InnerText
        a.sprOffsetY = Node.SelectSingleNode("Sprite/YOffset").InnerText
        a.shadowOffsetX = Node.SelectSingleNode("Shadow/XOffset").InnerText
        a.shadowOffsetY = Node.SelectSingleNode("Shadow/YOffset").InnerText
        Return a
    End Function
End Class