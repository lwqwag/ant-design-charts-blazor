﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AntDesign.Charts
{
    public class RangeBarConfig : IRangeBarViewConfig, IPlotConfig
    {
        public RangeBarLabelConfig label { get; set; }
        public string colorField { get; set; }
        public int? barSize { get; set; }
        public GraphicStyle barStyle { get; set; }
        public ValueAxis xAxis { get; set; }
        public CatAxis yAxis { get; set; }
        public ConversionTagOptions conversionTag { get; set; }
        public Interactions[] interactions { get; set; }
        public string renderer { get; set; }
        public object data { get; set; }
        public ILooseMap<Meta> meta { get; set; }
        public string padding { get; set; }
        public string xField { get; set; }
        public string yField { get; set; }
        public string[] color { get; set; }
        public Tooltip tooltip { get; set; }
        public Legend legend { get; set; }
        public bool? animation { get; set; }
        public string theme { get; set; }
        public object responsiveTheme { get; set; }
        public bool? responsive { get; set; }
        public Title title { get; set; }
        public Description description { get; set; }
        public GuideLineConfig[] guideLine { get; set; }
        public ViewConfigDefaultState defaultState { get; set; }
        public string name { get; set; }
        public bool? forceFit { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public int? pixelRatio { get; set; }
        public bool? localRefresh { get; set; }
        public object columnStyle { get; set; }
        BarViewConfigLabel IBarViewConfig.label { get; set; }
        Label IViewConfig.label { get; set; }
        Axis IViewConfig.xAxis { get; set; }
        Axis IViewConfig.yAxis { get; set; }
    }

    public interface IRangeBarViewConfig : IBarViewConfig
    {
        public RangeBarLabelConfig label { get; set; }

        public object columnStyle { get; set; }//TODO:源码中缺失，Demo中存在 
    }
}