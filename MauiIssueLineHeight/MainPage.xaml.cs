using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MauiIssueLineHeight;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        /*
        var fontDetails = new FontDetails("OpenSansRegular", 15);
        Debug.WriteLine(JsonSerializer.Serialize(fontDetails, new JsonSerializerOptions() { WriteIndented = true, }));

        fontDetails = new FontDetails("OpenSansRegular", 30);
        Debug.WriteLine(JsonSerializer.Serialize(fontDetails, new JsonSerializerOptions() { WriteIndented = true, }));
        */
        /*
        iOS:
        {
            "FontFamily": "OpenSansRegular",
            "FontSize": 15,
            "Ascender": 16.032715,
            "Descender": -4.3945312,
            "Leading": 0,
            "CapHeight": 10.708008,
            "LineHeight": 20.427246,
            "XHeight": 8.027344,
            "Top": 0,
            "Bottom": 0
        }
        
        Figma Auto  = LineHeight / FontSize = 136.18164%
        
        Figma Auto = top + bottom / FontSize = 132.71484267%
        {
            "FontFamily": "OpenSansRegular",
            "FontSize": 30,
            "Ascender": 32.06543,
            "Descender": -8.7890625,
            "Leading": 0,
            "CapHeight": 21.416016,
            "LineHeight": 40.854492,
            "XHeight": 16.054688,
            "Top": 0,
            "Bottom": 0
        }
        
        Android:
        {
            "FontFamily": "OpenSansRegular",
            "FontSize": 15,
            "Ascender": -13.916016,
            "Descender": 3.6621094,
            "Leading": 0,
            "CapHeight": 0,
            "LineHeight": 0, // top + bottom = 19.9072264
            "XHeight": 0,
            "Top": -15.842285,
            "Bottom": 4.0649414
        }
        
        {
            "FontFamily": "OpenSansRegular",
            "FontSize": 30,
            "Ascender": -27.832031,
            "Descender": 7.3242188,
            "Leading": 0,
            "CapHeight": 0,
            "LineHeight": 0, // top + bottom = 39.814453
            "XHeight": 0,
            "Top": -31.68457,
            "Bottom": 8.129883
        }
        
        MacCatalyst:
        {
             "FontFamily": "OpenSansRegular",
             "FontSize": 15,
             "Ascender": 16.032715,
             "Descender": -4.3945312,
             "Leading": 0,
             "CapHeight": 10.708008,
             "LineHeight": 20,
             "XHeight": 8.027344,
             "Top": 0,
             "Bottom": 0
           }
        */
    }

    private void Label_OnSizeChanged(object? sender, EventArgs e)
    {
        if (sender is Label label)
        {
            Debug.WriteLine($"{label.Text} - {label.Width} x {label.Height}");
        }
    }
}