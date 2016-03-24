# Introduction #

C# Xml Serialization typically requires a parent element for collections, but KML uses collections without that requirement. This proof of concept uses attributes applied to a List in such a way that the child elements do not require a parent.

# Code #
```
    [XmlRootAttribute(ElementName = "kml")]
    public class XmlRoot : AContainer
    {
        private static bool serializing;
        public static void TestXML() {
            XmlRoot tst = new XmlRoot();
            Folder flr = new Folder("Container");
            tst.Add(flr);
            tst.Add(new Placemark(5));
            tst.Document.Add(new Placemark(18));
            tst.Document.Add(flr);

            flr.Add(new Placemark(12));

            XmlSerializer ser = new XmlSerializer(typeof(XmlRoot));
            serializing = true;
            ser.Serialize(Console.Out, tst);
            serializing = false;
            Console.WriteLine();
        }

        private Document m_Document;
        public Document Document {
            get {
                if (!serializing && m_Document == null) {
                    m_Document = new Document();
                }
                return m_Document;
            }
            set {
                m_Document = value;
            }
        }
    }

    public class Document : AContainer
    {
        public Document() { }
    }

    public abstract class AFeature
    {
        public bool IsCool = true;
    }

    public abstract class AContainer : AFeature
    {
        public void Add(AFeature kid) {
            if (MyKids == null) {
                MyKids = new List<AFeature>();
            }
            MyKids.Add(kid);
        }
        [XmlElement(ElementName = "Folder", Type = typeof(Folder))]
        [XmlElement(ElementName = "Placemark", Type = typeof(Placemark))]
        public List<AFeature> MyKids;
    }

    public class Folder : AContainer
    {
        public string Title;
        public Folder() { }
        public Folder(string t) {
            Title = t;
        }
    }

    public class Placemark : AFeature
    {
        public int Places;
        public Placemark() { }
        public Placemark(int t) {
            Places = t;
        }
    }
```