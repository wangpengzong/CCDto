using com.msung.application.Service.Crud.Dto;
using com.msung.entity;
using com.msung.entity.Base;
using com.msung.entity.DtoColumn;
using FreeSql.DataAnnotations;
using System;
using com.msung.entity.Table;

namespace com.msung.application.Service.MaterialBatchs.Dto
{

    public class MaterialBatchDto:EntityDto<int>
    {
        //DtoColumn 查询列表不显示 ，设置IsDisabled = true 
        //DtoColumn 新增/修改 不显示 ，设置IsEdit = false 
        //DtoColumn 新增/修改 是选择框 ，设置EditType = EditType.select 
        //DtoColumn 外联从OptionValue字典表读取 ，设置OptionGroup = "你的OptionGroup名称" 
        //DtoColumn 外联从其他表读取 分为 
        //1.新增/修改中的select 设置OptionSql = "select id,name as value from tablename where ..." 
        //2.列表显示中  先在Entity中增加对应表实体，Dto中增加对应Value或者Name名称，MapProfile中增加对应映射关系


        [DtoColumn(ShowName = "添加时间", IsEdit = false)]
        public DateTime? CreateTime { get; set; }

        [DtoColumn(ShowName = "备注")]
        public string Remark { get; set; }

    }

}
