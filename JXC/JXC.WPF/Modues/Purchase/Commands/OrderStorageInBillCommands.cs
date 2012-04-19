﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20120418
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20120418
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JXC.WPF.Templates;
using OEA;
using OEA.MetaModel.Attributes;
using OEA.MetaModel.View;
using OEA.Module.WPF;
using OEA.Module.WPF.Controls;
using OEA.WPF.Command;
using OEA.Library;

namespace JXC.Commands
{
    [Command(ImageName = "Add.bmp", Label = "入库", ToolTip = "添加一个采购入库单", GroupType = CommandGroupType.Edit)]
    public class AddOrderStorageInBill : AddBill
    {
        public AddOrderStorageInBill()
        {
            this.Service = new AddOrderStorageInBillService();
        }
    }

    //[Command(ImageName = "Delete.bmp", Label = "删除", ToolTip = "删除一个采购入库单", GroupType = CommandGroupType.Edit)]
    //public class DeleteStorageInBill : DeleteBill
    //{
    //    public DeleteStorageInBill()
    //    {
    //        this.Service = new DeleteOrderStorageInBillService();
    //    }
    //}
}