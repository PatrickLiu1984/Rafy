﻿/*******************************************************
 * 
 * 作者：胡庆访
 * 创建时间：20120424
 * 说明：此文件只包含一个类，具体内容见类型注释。
 * 运行环境：.NET 4.0
 * 版本号：1.0.0
 * 
 * 历史记录：
 * 创建文件 胡庆访 20120424
 * 
*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbMigration.Model;
using hxy.Common.Data;
using hxy.Common.Data.Providers;
using DbMigration.SqlServer;

namespace DbMigration.Oracle
{
    /// <summary>
    /// Oracle 的数据库迁移提供程序
    /// </summary>
    public class OracleMigrationProvider : DbMigrationProvider
    {
        public override IMetadataReader CreateSchemaReader()
        {
            return new OracleMetaReader(this.DbSetting);
        }

        public override RunGenerator CreateRunGenerator()
        {
            return new OracleRunGenerator();
        }

        public override IDbBackuper CreateDbBackuper()
        {
            //TODO 实现 .sdf 文件的复制即可
            throw new NotSupportedException("暂时未完成此方法的实现。");
        }
    }
}