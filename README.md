# 自定义安装程序模板
## 新建项目流程
1. 将要安装的文件拷贝到InstallFiles\package.zip中的package文件夹中
2. 继承InstallationStepBase基类实现Setup、IsNeedToSetup和Order（代表安装顺序）
3. 修改StringConst.cs中的字符串

## 常用变量
1. SetupUtil.CurrentInstallInfo 软件安装的基本参数，例如版本号和安装路径
