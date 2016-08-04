#C#基础知识点
比C++:更简单、代码更长、为.net设计

命名：camelCase、PascalCase
简单变量用camelCase，复杂用PascalCase。
##运算符
布尔运算符：
&、|、！、^(异或)
&&、||短路

按位运算符：&、|，~

C#中switch执行多个case块是非法的（和C++不同）

##转换：
- 隐式转换（函数参数不符合的时候）
- 显式转换：
*用checked((byte)moushort)
*用Convert

##枚举：
* 枚举类转byte：directionByte=(byte)myDir;
* byte转枚举：myDir=(orientation)directionByte;
* 枚举转string：dirStr=myDir.ToString();或Convert.ToString(myDir);
* string转枚举：myDir=(orientation)Enum.Parse(typeof(orientation),myStr);
    
##结构：
常在一起复用的几个值，和类不同的是值引用


##函数：
参数数组：必须是最后一个参数EG:fun(params int[] vals)
ref引用参数,out（输出参数，可不提前赋值）
    

###委托：
委托声明：delegate double ProcessDelegate(double p1,double p2);
实现函数：double Multiply(double p1,double p2){...} doubel Divide(double p1,double p2){...}
调用：ProcessDelegate process=new ProcessDelegate(Multiply);【根据条件决定参数是Multiply还是Divide】Console.WriteLine(process(p1,p2));

##OOP
最好不要修改接口，而是新建并扩展原来的接口
###构造析构
析构~MyClass(){...}

构造函数是先执行父类的默认构造函数，这样递归
用base可以指定执行父类的哪个构造函数`（SonClass(int i,int j):base(i)）`或`（SonClass():base(6)）`
用this可以指定其他构造函数的默认参数`（SonClass():this(5,6)）`

###成员
####字段
关键字：readonly只读、static、const，其中const隐含static所以不能混用
####属性
用PascalCasing格式命名
在set中可以进行检验并抛出异常
set、get可访问性不能高于这个属性
自动属性：set、get没有内容，但必须有set、get，不能只读或只写

####方法
关键字：virtual必须重写；abstract必须在非抽象子类重写；override重写了父类方法；extern定义放在其他地方；sealed不能重写（和override合用）


###嵌套类
嵌套类可访问、设置包含类的私有属性——可以通过嵌套类函数设置包含类属性


###继承与多态
Base b=new Dirived();
b.Fun();调用的是子类的方法

将父类强转为子类：(Dirived)b

非抽象的子类必须实现父类的所有抽象函数

子类的可访问性不能高于父类

同时继承类和接口时，要把父类放在最前面MyClass:MyBase,IMyInt

####隐藏父类方法
隐藏用new：`new public void DoSth(){...}`能够先执行父类的该方法（不执行自己的）
重写用override：`public override void DoSth(){...}`能够替代父类方法

####接口
不能用访问修饰符，默认为公共
函数不能有修饰符
#####显式和隐式实现接口方法
显示：`void IMyInterface.DoSomething()`
隐式：`public void DoSomething()`
类如果显式的实现接口的方法，则只能由接口对象访问而不能由类对象访问：
```C#
MyClass myobj=new MyClass();
IMyInter myInt=myobj;
myInt.DoSomething();
```
而不能
```C#
MyClass myobj=new MyClass();
myInt.DoSomething();
```
而隐式实现可以同时用两种方法访问

#####属性
接口中可以有属性
实现类可以给属性增加存取器，但是要低于public

###部分
####部分类
如果类太长，可以包含到多个文件中，声明时`public partial class MyClass`
####部分方法
一个方法也可以定义在多个部分类中`partial void Fun(){...}`
可以是静态，但总是私有的，不能返回值（因为可能没有被实现，就不会有返回值，导致调用得到为空），传入参数不能是out但可以是ref（同理，可能没有被实现）
作用是在一个部分类文件中声明，在另一个中调用，如果没有实现，则调用和声明会被删除，提高编译效率。

###复制
* 浅度复制:只复制成员，引用成员复制的仍然是引用（和原来指向同一个对象）
* 深度复制：继承ICloneable接口并实现Clone方法，自定制复制程度


