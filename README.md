# CCDto
依照ABP做一个简单的开发框架，基础的增删改查方法从AsyncCrudAppService继承，需要实现的Service如果有额外修改，可以进行override重写

参考：ABP

ORM：FreeSql

# 简单cshtml页面无需多写，只需要根据模板生成
```
https://github.com/wangpengzong/CCDto/tree/master/src/Web/CCDto.Web/Template/TableName
└─ TableName
   ├─ Controller
   │  └─ TableNameController.cs
   ├─ Service
   │  └─ TableName
   │     ├─ Dto
   │     │  ├─ TableNameDto.cs
   │     │  ├─ TableNameMapProfile.cs
   │     │  └─ TableNamesPagedResultRequestDto.cs
   │     ├─ ITableNameService.cs
   │     └─ TableNameService.cs
   └─ Views
      └─ TableName
         ├─ Edit.cshtml
         └─ Index.cshtml
```
# 列表表头，数据加载，Edit界面从Dto进行控制显示隐藏
```
https://github.com/wangpengzong/CCDto/blob/master/src/Core/CCDto.application/Service/DB/DBConnection/Dto/DBConnectionDto.cs
```


多数据库支持
弃用之前的DbType和ConnectionStrings，使用DbsOpen和Dbs
表对应实体头部添加`[MultiDB(DbName: "DB1")]`属性使当前实体连接数据库时使用这个Db，如果不添加默认使用配置json文件中的第一个Db连接