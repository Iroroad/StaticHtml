﻿using System;
using System.IO;

namespace StaticHtml
{
    /// <summary>
    /// 存储生成的Html缓存内容接口
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// 存储Html
        /// </summary>
        /// <param name="key">HttpRequest生成的key</param>
        /// <param name="repInfo">内容</param>
        void Save(String key, Stream repInfo);
       
        /// <summary>
        /// 获取缓存的Html
        /// </summary>
        /// <param name="key">HttpRequest生成的key</param>
        /// <returns>内容</returns>
        Stream Get(String key);
        


        /// <summary>
        /// 查询缓存信息
        /// </summary>
        /// <param name="key">HttpRequest生成的key</param>
        /// <returns>HtmlInfo包含存储时间，大小等</returns>
        CacheInfo Query(String key);
    }
}
