﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Thingie.Tracking;
using Thingie.Tracking.Description;

namespace TestWPFWithUnity.Settings
{
    public class AppSettings
    {
        [Trackable]
        public DisplaySettings DisplaySettings { get; set; }
        [Trackable]
        public GeneralSettings GeneralSettings { get; set; }

        public AppSettings()
        {
            DisplaySettings = new DisplaySettings();
            GeneralSettings = new GeneralSettings();
        }
    }
}
