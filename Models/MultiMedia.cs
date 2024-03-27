﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XiaoFeng.Ofd.Attributes;
using XiaoFeng.Ofd.Enum;
using XiaoFeng.Ofd.Internal;
using XiaoFeng.Xml;

/****************************************************************
*  Copyright © (2024) www.eelf.cn All Rights Reserved.          *
*  Author : jacky                                               *
*  QQ : 7092734                                                 *
*  Email : jacky@eelf.cn                                        *
*  Site : www.eelf.cn                                           *
*  Create Time : 2024-03-26 20:35:28                            *
*  Version : v 1.0.0                                            *
*  CLR Version : 4.0.30319.42000                                *
*****************************************************************/
namespace XiaoFeng.Ofd.Models
{
    /// <summary>
    /// 多媒体结构
    /// </summary>
    public class MultiMedia
    {
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public MultiMedia()
        {

        }
        #endregion

        #region 属性
        /// <summary>
        /// 多媒体类型
        /// </summary>
        [XmlAttribute]
        [Required] 
        public MultiMediaType Type { get; set; }
        /// <summary>
        /// 资源的格式 支持BMP、JPEG、PNG、TIFF及AVS等格式，其中TIFF格式不支持多页
        /// </summary>
        [XmlAttribute] 
        public string Format { get; set; }
        /// <summary>
        /// 指向OFD包内的多媒体文件位置
        /// </summary>
        [XmlCData]
        [Required]
        public Location MediaFile { get; set; }
        #endregion

        #region 方法

        #endregion
    }
}