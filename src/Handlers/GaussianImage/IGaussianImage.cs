using IImage = Microsoft.Maui.IImage;

namespace JiuLing.Controls.Maui.Handlers.GaussianImage;
public interface IGaussianImage : IImage
{
    string Url { get; set; }
}