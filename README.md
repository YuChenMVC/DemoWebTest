## ²��DemoWeb�椸����
<br>

![GitHub commit checks state](https://img.shields.io/github/checks-status/YuChenMVC/DemoWebTest/5d19dd82768d5e5c0236e972d9215c6d5b5d9cd1?color=ff69b4&label=DemoWebTest&logo=github&logoColor=%23FC60A8&style=plastic)

|TestTool|Class|Method|
|-|-|-|
|xunit|ListService|GetHouseById|

![png](https://github.com/YuChenMVC/DemoWebTest/blob/master/png.png)

## Resource

> ����HTTP response��
```C#
Assert.IsType<OkObjectResult>(�^�ǵ��G as OkObjectResult);
```
> ���ƭȬ۵���
```C#
Assert.Equal(���ռƭ�, �ƭ�);
```
> ��~~���s�b~~���ȥ�
```C#
Assert.IsType<NotFoundResult>(���s�b����);
```