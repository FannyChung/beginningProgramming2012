# VS使用技巧

##调试
### 输出调试信息
不会包含到发布版本：'Debug.WriteLine("info","infotype");''
###跟踪点
作用和Console.WriteLine相同。在断点处右击，输入信息
###断点
在BreakPoints窗口，可以添加标签以分组。在condition输入条件可以在满足条件时候才出发断点，在hit count中输入次数可以指定遇到这里多少次后才触发断点。
可以在监视变量的窗口中编辑变量的值
## 错误处理
###try
没有匹配的catch块，就终止程序
catch块要由细到粗写

##类
###类库
包含类，没有入口点，
声明：创建项目时选择Class Library，用build生成
调用：在其他项目中Project|Add Preference导航到原项目中的bin/Debug的dll文件

###属性
通过重构字段生成属性
右击该字段Refactor|Encapsulate Field即可

##快速生成代码
###新建类、枚举等
右击项目，查看类图
打开工具箱，拖动枚举、类等元素
编辑成员
