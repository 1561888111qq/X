﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCode.Transform
{
    /// <summary>数据上下文</summary>
    public class DataContext
    {
        #region 属性
        /// <summary>抽取设置</summary>
        public IExtractSetting Setting { get; set; }

        /// <summary>实体列表</summary>
        public IList<IEntity> Data { get; set; }

        /// <summary>抽取耗时，毫秒</summary>
        public Double FetchCost { get; set; }

        /// <summary>成功处理数</summary>
        public Int32 Success { get; set; }

        /// <summary>处理耗时</summary>
        public Double ProcessCost { get; set; }

        /// <summary>实体对象</summary>
        public IEntity Entity { get; set; }

        /// <summary>处理异常</summary>
        public Exception Error { get; set; }

        /// <summary>状态对象</summary>
        public Object State { get; set; }
        #endregion

        #region 扩展属性
        /// <summary>抽取速度</summary>
        public Int32 FetchSpeed { get => (FetchCost == 0 || Data == null) ? 0 : (Int32)(Data.Count * 1000 / FetchCost); }

        /// <summary>处理速度</summary>
        public Int32 ProcessSpeed { get => (ProcessCost == 0 || Data == null) ? 0 : (Int32)(Data.Count * 1000 / ProcessCost); }
        #endregion
    }
}