using IImage = Microsoft.Maui.IImage;

namespace JiuLing.Controls.Maui.Handlers.GaussianImage;
internal interface IGaussianImage : IImage
{
    string Url { get; set; }
}