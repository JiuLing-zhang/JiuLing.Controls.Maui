using JiuLing.Controls.Maui.Handlers.GaussianImage;

namespace JiuLing.Controls.Maui;

/// <summary>
/// MauiAppBuilder 的扩展方法
/// </summary>
public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// 启用组件库
    /// </summary>
    /// <returns></returns>
    public static MauiAppBuilder UseJiuLingControls(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(handler =>
        {
            handler.AddHandler(typeof(GaussianImage), typeof(GaussianImageHandler));
        });
        return builder;
    }
}