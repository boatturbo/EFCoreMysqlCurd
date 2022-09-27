# EFCoreMysqlCurd
创建一个ASP.NET Core Web API程序并用efcore+mysql做增删改查demo；转载自：https://blog.csdn.net/EAyayaya/article/details/124048491

Codefrist 将代码映射到数据库步骤：
点击工具 ->NUGET包管理器 -> 程序包管理器控制台；
依次执行Add-Migration init、Update-Database；
如果更改了models，需要删除迁移，然后重新迁移；

如何运行并查看效果：
随便往Parameter_Table表手动添加一些数据并保存，运行此项目。
点击展开Parameter/GET/api​/parameter​/getall，点击try it out => Excute，能看到查询出的结果。
