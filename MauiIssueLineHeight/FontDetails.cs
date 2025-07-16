namespace MauiIssueLineHeight;

public class FontDetails
{
    public string FontFamily { get; } = string.Empty;
    
    public float FontSize { get; }
    
    public float Ascender { get; }
    public float Descender { get; }
    public float Leading { get; }
    public float CapHeight { get; }
    public float LineHeight { get; }
    public float XHeight { get; }
    public float Top { get; }
    public float Bottom { get; }

    public FontDetails(string fontFamily, float fontSize)
    {
        FontFamily = fontFamily;
        FontSize = fontSize;
        
        #if __IOS__
        var fontName = fontFamily switch
        {
            "OpenSansRegular" => "OpenSans-Regular",
            "OpenSansSemibold" => "OpenSans-Semibold",
            _ => string.Empty,
        };

        if (string.IsNullOrWhiteSpace(fontName))
        {
            return;
        }

        var font = UIKit.UIFont.FromName(fontName, fontSize);
        if (font is null)
        {
            return;
        }

        Ascender = (float)font.Ascender;
        Descender = (float)font.Descender;
        CapHeight = (float)font.CapHeight;
        LineHeight = (float)font.LineHeight;
        XHeight = (float)font.XHeight;
        
        #elif __ANDROID__
        var typeface = Android.Graphics.Typeface.Create(fontFamily, Android.Graphics.TypefaceStyle.Normal);
        if (typeface is null)
        {
            return;
        }
        
        var paint = new Android.Graphics.Paint()
        {
            TextSize = fontSize,
        };
        paint.SetTypeface(typeface);

        var metrics = paint.GetFontMetrics();
        if (metrics is null)
        {
            return;
        }
        
        Ascender = metrics.Ascent;
        Descender = metrics.Descent;
        Leading = metrics.Leading;
        Top = metrics.Top;
        Bottom = metrics.Bottom;
#endif
    }
}