using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPickerWPF
{
    public static class ColorPickerSettings
    {
        public static bool UsingCustomPalette { get; internal set; }
        public static string CustomColorsFilename = "CustomColorPalette.xml";
        public static string CustomColorsDirectory = Environment.CurrentDirectory;

        public static string CustomPaletteFilename {  get { return Path.Combine(CustomColorsDirectory, CustomColorsFilename); } }

    }
}
