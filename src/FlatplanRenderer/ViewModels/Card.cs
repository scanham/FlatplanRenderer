using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FlatplanRenderer.ViewModels
{

    public class StoryCard
    {
        public StoryCard()
        {
            // just to set default options
            Options = new StoryCardOptions();
        }
        
        public StoryCardOptions Options { get; set; }
        public string Headline { get; set; }
        public string Summary { get; set; }
        public string Byline { get; set; }
        public string SeoFragment { get; set; }
        public string Url { get; set; }
        public DateTime TimestampUtc { get; set; }
        public List<Image> Images { get; set; }
        public Label Label { get; set; }
        public List<InstrumentModel> Instruments { get; set; }
        public Guid? Guid { get; set; }
        public int DocType { get; set; }
    }

    public class StoryCardOptions
    {
        public StoryCardOptions()
        {
            // default options
            ShowImage = true;
        }

        public bool? ShowImage { get; set; }
        public bool? ShowByline { get; set; }
        public bool? ShowSummary { get; set; }
        public bool? ShowTickers { get; set; }
        public bool? ShowTimestamp { get; set; }
        public int? SummaryMaxLength { get; set; }
    }
    public class Image
    {
        public string Url { get; set; }
        public string Credit { get; set; }
        public string Size { get; set; }
        public bool Responsive { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Label
    {
        public string Url { get; set; }
        public string Display { get; set; }
        public string ImageUrl { get; set; }
    }
}
