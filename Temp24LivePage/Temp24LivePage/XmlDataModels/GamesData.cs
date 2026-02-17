using System.Xml.Serialization;

namespace Temp24LivePage.XmlDataModels;

[XmlRoot("GamesData")]
public class GamesData
{
    [XmlElement("game")]
    public List<Game> GamesList { get; set; }
}
public class Game
{
    [XmlAttribute("id")]
    public int id { get; set; }

    [XmlAttribute("titleEn")]
    public string titleEn { get; set; }

    [XmlAttribute("titleFa")]
    public string titleFa { get; set; }

    [XmlAttribute("icon")]
    public string icon { get; set; }

    [XmlElement("GameLinks")]
    public GameLinks gameLinks { get; set; }

    [XmlElement("GameSlides")]
    public GameSlides gameSlides { get; set; }
}
public class GameLinks
{
    [XmlElement("link")]
    public List<GameLink> links { get; set; }
}
public class GameLink
{
    [XmlAttribute("id")]
    public int id { get; set; }

    [XmlAttribute("title")]
    public string title { get; set; }

    [XmlAttribute("url")]
    public string url { get; set; }
}
public class GameSlides
{
    [XmlElement("slide")]
    public List<Slide> slides { get; set; }
}
public class Slide
{
    [XmlAttribute("id")]
    public int id { get; set; }

    [XmlAttribute("img")]
    public string img { get; set; }

    [XmlAttribute("aspect")]
    public string aspect { get; set; }

    [XmlAttribute("alt")]
    public string alt { get; set; }


}
