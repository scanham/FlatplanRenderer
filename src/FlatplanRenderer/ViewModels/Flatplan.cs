using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FlatplanRenderer.ViewModels
{
    public class Data
    {
        public List<Flatplan> Flatplans { get; set; }
    }
    public class Flatplan
    {
        public string LayoutId { get; set; }
        public Label Label { get; set; }
        public List<Template> Templates { get; set; }
        public bool Subplan { get; set; }
    }

    public class Template
    {
        public string ChannelName { get; set; }
        public List<Column> Columns { get; set; }
        public int Units { get; set; }
        public Label Label { get; set; }
        public bool? IsSticky { get; set; }
        public TimeSpan SuggestedCacheExpiration { get; set; }
    }

    public class Column
    {
        public int Units { get; set; }
        public List<StoryCard> Cards { get; set; }
        public bool? IsSticky { get; set; }
    }

    public class InstrumentModel
    {
        public string Ticker { get; set; }
        public string Country { get; set; }
        public string InstrumentType { get; set; }
        public string Company { get; set; }
        public string ExchangeCommonName { get; set; }
        public string TimeZoneAbbreviation { get; set; }
        public bool IsAfterHours { get; set; }
        public bool IsBeforeHours { get; set; }
        public bool IsMarketClosed { get; set; }
        public List<BlueGrassChannel> BlueGrassChannels { get; set; }
        public string GavelChannel { get; set; }
        public string ChartingSymbol { get; set; }
    }

    public class BlueGrassChannel
    {
        public string Type { get; set; }
        public string Channel { get; set; }
    }
}
