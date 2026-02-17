using System.Xml.Serialization;

namespace Temp24LivePage.XmlDataModels;

[XmlRoot("VideosData")]
public class VideosData
{
    [XmlElement("video")]
    public List<Video> VideosList { get; set; }
}

public class Video
{
    [XmlAttribute("id")]
    public int id { get; set; }

    [XmlAttribute("titleEn")]
    public string titleEn { get; set; }

    [XmlAttribute("titleFa")]
    public string titleFa { get; set; }

    [XmlAttribute("cover")]
    public string cover { get; set; }

    [XmlAttribute("desEn")]
    public string desEn { get; set; }
    
    [XmlAttribute("desFa")]
    public string desFa { get; set; }

    [XmlElement("VideoLinks")]
    public VideoLinks videoLinks { get; set; }
}
public class VideoLinks
{
    [XmlElement("link")]
    public List<VideoLink> links { get; set; }
}

public class VideoLink
{
    [XmlAttribute("id")]
    public int id { get; set; }

    [XmlAttribute("title")]
    public string title { get; set; }

    [XmlAttribute("url")]
    public string url { get; set; }
}
