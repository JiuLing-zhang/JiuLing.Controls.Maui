namespace JiuLing.Controls.Maui.Controls;
/// <summary>
/// 文本开关
/// </summary>
public partial class TextSwitch : ContentView
{
    /// <summary>
    /// 要绑定的文本属性
    /// </summary>
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(TextSwitch),
            string.Empty);
    /// <summary>
    /// 文本内容
    /// </summary>
    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    /// <summary>
    /// 选中
    /// </summary>
    public static readonly BindableProperty IsToggledProperty =
        BindableProperty.Create(
            nameof(IsToggled),
            typeof(bool),
            typeof(Switch),
            false,
            defaultBindingMode: BindingMode.TwoWay);

    /// <summary>
    /// 选中
    /// </summary>
    public bool IsToggled
    {
        get { return (bool)GetValue(IsToggledProperty); }
        set { SetValue(IsToggledProperty, value); }
    }

    /// <summary>
    /// 初始化组件
    /// </summary>
    public TextSwitch()
    {
        InitializeComponent();
    }
}