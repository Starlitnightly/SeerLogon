#星小夜的登录器

- 1.采用c#语言，结合大漠插件开发脚本，将大漠dll的相关内容封装进C_dm类中，调用前先实例化,此类的相关函数于下方讲解
- 2.采用多线程，开发前应先了解下几个相关的类库及其有关函数
	- 1. System.Threading.Tasks; 
	- 2. System.Threading;


**注：制作新的脚本时，需结合大漠综合工具找图，找坐标**



##部分函数讲解（实例化对象为dm）

###FindPic
``` 
dm.FindPic(x1, y1, x2, y2, pic_name, delta_color,sim, dir,intX, intY)
```
####参数定义
int **x1**:区域的左上X坐标

int **y1**:区域的左上Y坐标

int **x2**:区域的右下X坐标

int **y2**:区域的右下Y坐标

string **pic_name**:图片名,可以是多个图片,比如"test.bmp|test2.bmp|test3.bmp"

string **delta_color**:颜色色偏比如"203040" 表示RGB的色偏分别是20 30 40 (这里是16进制表示)

double **sim**:相似度,取值范围0.1-1.0

int **dir**:查找方向 0: 从左到右,从上到下 1: 从左到右,从下到上 2: 从右到左,从上到下 3: 从右到左, 从下到上

int **X** 变参指针:返回图片左上角的X坐标

int **Y** 变参指针:返回图片左上角的Y坐标

####返回值

int

返回找到的图片的序号,从0开始索引.如果没找到返回-1

####实例
```
if (dm.FindPic(0, 0, 1000, 600, "道具.bmp", "000000", 0.8, 0, out x, out y) != -1)
```
##
###FindPic
``` 
dm.FindPic(x1, y1, x2, y2, pic_name, delta_color,sim, dir,intX, intY)
```
####参数定义
int **x1**:区域的左上X坐标

int **y1**:区域的左上Y坐标

int **x2**:区域的右下X坐标

int **y2**:区域的右下Y坐标

string **color**:颜色 格式为**"RRGGBB-DRDGDB"**,
比如**"123456-000000|aabbcc-202020"**.注意，这里只支持RGB颜色.

double **sim**:相似度,取值范围0.1-1.0

int **dir**:查找方向
 
- 0: 从左到右,从上到下 
- 1: 从左到右,从下到上
- 2: 从右到左,从上到下
- 3: 从右到左,从下到上 
- 4：从中心往外查找
- 5: 从上到下,从左到右
- 6: 从上到下,从右到左
- 7: 从下到上,从左到右
- 8: 从下到上,从右到左


int **X** 变参指针:返回图片左上角的X坐标

int **Y** 变参指针:返回图片左上角的Y坐标

####返回值

int

0:没找到

1:找到

####实例
```
dm.FindColor(284, 509, 297, 518, "0388ec-000000", 1, 0, out x, out y) != 0
```
##
###MoveTo
``` 
dm.MoveTo(x,y)
```
####参数定义
int **x**:X坐标

int **y**:Y坐标



####返回值

int

0:失败

1:成功

####实例
```
dm.MoveTo(500,500)
```
##
###LeftClick
``` 
dm.LeftClick(x,y)
```
####参数定义

####返回值

int

0:失败

1:成功

####实例
```
dm.LeftClick()
```
