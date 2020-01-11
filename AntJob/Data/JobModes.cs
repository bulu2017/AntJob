﻿using System.ComponentModel;

namespace AntJob.Data
{
    /// <summary>作业模式</summary>
    //[Description("作业模式")]
    public enum JobModes
    {
        /// <summary>数据调度</summary>
        [Description("数据调度")]
        Data = 1,

        /// <summary>定时调度</summary>
        [Description("定时调度")]
        Alarm = 2,

        /// <summary>消息调度</summary>
        [Description("消息调度")]
        Message = 3,

        /// <summary>C#调度</summary>
        [Description("C#调度")]
        CSharp = 4,

        /// <summary>SQL调度</summary>
        [Description("SQL调度")]
        Sql = 5,
    }
}