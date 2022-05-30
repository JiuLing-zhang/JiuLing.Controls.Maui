using IImage = Microsoft.Maui.IImage;

namespace JiuLing.Controls.Maui.Handlers.GaussianImage;
/// <summary>
/// 图像高斯模糊接口
/// </summary>
public interface IGaussianImage : IImage
{
    string Url { get; set; }
}