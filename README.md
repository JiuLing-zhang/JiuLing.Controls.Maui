![](https://img.shields.io/github/license/JiuLing-zhang/JiuLing.Controls.Maui)
![](https://img.shields.io/github/workflow/status/JiuLing-zhang/JiuLing.Controls.Maui/Build)
[![](https://img.shields.io/nuget/v/JiuLing.Controls.Maui)](https://www.nuget.org/packages/JiuLing.Controls.Maui/)
[![](https://img.shields.io/github/v/release/JiuLing-zhang/JiuLing.Controls.Maui)](https://github.com/JiuLing-zhang/JiuLing.Controls.Maui/releases)  

## JiuLing.Controls.Maui
一个MAUI下的控件库

## 组件列表
<table>
    <tr>
        <td>组件名</td>
        <td>说明</td>
        <td>Android</td>
        <td>iOS</td>
        <td>MacCatalyst</td>
        <td>Tizen</td>
        <td>Windows</td>
    </tr>
    <tr>
        <td>TextSwitch</td>
        <td>带文本的开关</td>
        <td>✔️</td>
        <td>✔️</td>
        <td>✔️</td>
        <td>✔️</td>
        <td>✔️</td>
    </tr>
</table>

## 使用  
### `TextSwitch` 带文本的开关

针对不同平台定义开关的展示方式，使得布局更加合理。  
`UWP`和`macOS`平台采用开关居左，文本描述居右的布局。  
`Android`和`iOS`平台采用文本描述居左，开关居右的布局。  

```c#
//导入命名控件
xmlns:JiuLing="clr-namespace:JiuLing.Controls.Maui.Controls;assembly=JiuLing.Controls.Maui"

//创建组件
<JiuLing:TextSwitch Text="深色主题" IsToggled="{Binding IsDarkMode}">
```

## License
本项目基于`MIT License`