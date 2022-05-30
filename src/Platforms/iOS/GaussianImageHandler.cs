using Microsoft.Maui.Handlers;

namespace JiuLing.Controls.Maui.Handlers.GaussianImage;

/// <summary>
/// 图像高斯模糊处理程序
/// </summary>
public partial class GaussianImageHandler : ViewHandler<IGaussianImage, UIKit.UIView>
{
    protected override UIKit.UIView CreatePlatformView()
    {
        throw new NotImplementedException("不支持的平台");
    }

    static async void MapUrl(GaussianImageHandler handler, IGaussianImage gaussianBlurImage)
    {
        throw new NotImplementedException("不支持的平台");
    }
}