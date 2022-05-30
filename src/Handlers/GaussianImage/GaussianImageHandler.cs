using Microsoft.Maui.Handlers;

namespace JiuLing.Controls.Maui.Handlers.GaussianImage;

public partial class GaussianImageHandler
{
    public static PropertyMapper<IGaussianImage, GaussianImageHandler> Mapper = new(ViewHandler.ViewMapper)
    {
        [nameof(IGaussianImage.Url)] = MapUrl

    };

    public GaussianImageHandler(PropertyMapper mapper)
        : base(mapper)
    {

    }

    public GaussianImageHandler() : base(Mapper)
    {

    }
}