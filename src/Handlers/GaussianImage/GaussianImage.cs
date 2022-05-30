namespace JiuLing.Controls.Maui.Handlers.GaussianImage;
public class GaussianImage : Image, IGaussianImage
{
    public static readonly BindableProperty UrlProperty =
        BindableProperty.Create(
            nameof(Url),
            typeof(string),
            typeof(GaussianImage),
            string.Empty);
    public string Url
    {
        get { return (string)GetValue(UrlProperty); }
        set { SetValue(UrlProperty, value); }
    }
}