using System.Collections.Generic;

namespace MarkdownWikiGenerator
{
    public class XmlDocumentComment
    {
        public MemberType MemberType { get; set; }
        public string ClassName { get; set; }
        public string MemberName { get; set; }
        public string Summary { get; set; }
        public string Remarks { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public string Returns { get; set; }
        public string Example { get; set; }

        public override string ToString()
        {
            return MemberType + ":" + ClassName + "." + MemberName;
        }
    }
}