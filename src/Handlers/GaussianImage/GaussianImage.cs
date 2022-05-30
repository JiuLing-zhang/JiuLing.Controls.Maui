namespace JiuLing.Controls.Maui.Handlers.GaussianImage;

/// <summary>
/// 图像高斯模糊
/// </summary>
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