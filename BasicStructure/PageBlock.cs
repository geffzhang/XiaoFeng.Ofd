﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-28 17:56:11                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.BasicStructure
{
    /// <summary>
    /// 页面块结构
    /// </summary>
    public class PageBlock : IPageBlock
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public PageBlock()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 页面块
        /// </summary>
        [XmlArrayItem("PageBlock")]
        public List<IPageBlock> PageBlocks { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}