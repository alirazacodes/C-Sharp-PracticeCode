using System;

namespace ClassesV2
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink( string url)
        {
            Console.WriteLine("We added the link to url!");
        }
    }
}