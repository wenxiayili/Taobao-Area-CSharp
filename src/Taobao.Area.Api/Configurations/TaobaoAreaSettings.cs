﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taobao.Area.Api.Configurations
{
    public class TaobaoAreaSettings
    {
        public string TempDirectoryName { get; set; }
        public string TaobaoJsVersion { get; set; }
        // 淘宝地址js的url 目前最新版 https://g.alicdn.com/vip/address/6.0.14/index-min.js
        public string TaobaoAreaJsUrl { get; set; }

        public string JsTemplate { get; set; }

        public string AreaPickerDataJsName { get; set; }

        public string TaobaoStreetUrl { get; set; }

        public string JsDirectoryName { get; set; }
    }
}
