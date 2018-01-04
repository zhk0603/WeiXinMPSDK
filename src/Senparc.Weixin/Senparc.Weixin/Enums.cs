﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2018 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2018 Senparc

    文件名：Enums.cs
    文件功能描述：枚举类型


    创建标识：Senparc - 20150211

    修改标识：Senparc - 20150303
    修改描述：整理接口

    修改标识：Senparc - 20150303
    修改描述：添加企业号返回码

    修改标识：Senparc - 20161112
    修改描述：v4.9.3 添加小程序返回码添加小程序返回码

    修改标识：Senparc - 20161215
    修改描述：v4.9.5 添加Sex枚举

    修改标识：Senparc - 20161215
    修改描述：v4.9.9 添加【ReturnCode.template_id】不正确枚举

    修改标识：Senparc - 20170302
    修改描述：v4.11.1 添加【ReturnCode.appsecret不正确】枚举类型（invalid appsecret，40125）

    修改标识：Senparc - 20170328
    修改描述：v4.12.1 添加【ReturnCode.小程序Appid不存在】枚举类型（invalid weapp appid，40166）

    修改标识：Senparc - 20170617
    修改描述：v4.12.3 提供对企业微信的支持：添加WorkJsonResult（企业微信返回消息基类）、ReturnCode_Work（枚举）
 
    修改标识：Senparc - 20170702
    修改描述：添加 PlatformType、CacheType

    修改标识：Senparc - 20170726
    修改描述：完成接口开放平台-代码管理及小程序码获取

    修改标识：Senparc - 20170810
    修改描述：v4.14.1 ReturnCode添加：没有留言权限 = 88000
   
----------------------------------------------------------------*/


namespace Senparc.Weixin
{
    /// <summary>
    /// CommonJsonSend中的http提交类型
    /// </summary>
    public enum CommonJsonSendType
    {
        /// <summary>
        /// GET 方法
        /// </summary>
        GET,
        /// <summary>
        /// POST 方法
        /// </summary>
        POST
    }

    /// <summary>
    /// 平台类型
    /// </summary>
    public enum PlatformType
    {
        /// <summary>
        /// 公众号
        /// </summary>
        MP,
        /// <summary>
        /// 开放平台
        /// </summary>
        Open,
        /// <summary>
        /// 小程序
        /// </summary>
        WxOpen,
        /// <summary>
        /// 企业号
        /// </summary>
        QY,
        /// <summary>
        /// 企业微信
        /// </summary>
        Work
    }

    /// <summary>
    /// 缓存类型
    /// </summary>
    public enum CacheType
    {
        /// <summary>
        /// 本地运行时缓存（单机）
        /// </summary>
        Local,
        /// <summary>
        /// Redis缓存（支持分布式）
        /// </summary>
        Redis,
        /// <summary>
        /// Memcached（支持分布式）
        /// </summary>
        Memcached
    }

    /// <summary>
    /// 公众号返回码（JSON）
    /// 应该更名为ReturnCode_MP，但为减少项目中的修改，此处依旧用ReturnCode命名
    /// </summary>
    public enum ReturnCode
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        系统繁忙此时请开发者稍候再试 = -1,
        请求成功 = 0,
        获取access_token时AppSecret错误或者access_token无效 = 40001,
        不合法的凭证类型 = 40002,
        不合法的OpenID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型_40008 = 40008,
        不合法的图片文件大小 = 40009,
        不合法的语音文件大小 = 40010,
        不合法的视频文件大小 = 40011,
        不合法的缩略图文件大小 = 40012,
        不合法的APPID = 40013,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        不合法的按钮个数1 = 40016,
        不合法的按钮个数2 = 40017,
        不合法的按钮名字长度 = 40018,
        不合法的按钮KEY长度 = 40019,
        不合法的按钮URL长度 = 40020,
        不合法的菜单版本号 = 40021,
        不合法的子菜单级数 = 40022,
        不合法的子菜单按钮个数 = 40023,
        不合法的子菜单按钮类型 = 40024,
        不合法的子菜单按钮名字长度 = 40025,
        不合法的子菜单按钮KEY长度 = 40026,
        不合法的子菜单按钮URL长度 = 40027,
        不合法的自定义菜单使用用户 = 40028,
        不合法的oauth_code = 40029,
        不合法的refresh_token = 40030,
        不合法的openid列表 = 40031,
        不合法的openid列表长度 = 40032,
        不合法的请求字符不能包含uxxxx格式的字符 = 40033,
        不合法的参数 = 40035,

        //小程序、 公众号都有
        template_id不正确 = 40037,

        不合法的请求格式 = 40038,
        不合法的URL长度 = 40039,
        不合法的分组id = 40050,
        分组名字不合法 = 40051,
        appsecret不正确 = 40125,//invalid appsecret

        小程序Appid不存在 = 40166,

        缺少access_token参数 = 41001,
        缺少appid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        缺少oauth_code = 41008,
        缺少openid = 41009,

        //小程序
        form_id不正确_或者过期 = 41028,
        form_id已被使用 = 41029,
        page不正确 = 41030,

        access_token超时 = 42001,
        refresh_token超时 = 42002,
        oauth_code超时 = 42003,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS请求 = 43003,
        需要接收者关注 = 43004,
        需要好友关系 = 43005,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
        文本消息内容为空 = 44004,
        多媒体文件大小超过限制 = 45001,
        消息内容超过限制 = 45002,
        标题字段超过限制 = 45003,
        描述字段超过限制 = 45004,
        链接字段超过限制 = 45005,
        图片链接字段超过限制 = 45006,
        语音播放时间超过限制 = 45007,
        图文消息超过限制 = 45008,
        接口调用超过限制 = 45009,
        创建菜单个数超过限制 = 45010,
        回复时间超过限制 = 45015,
        系统分组不允许修改 = 45016,
        分组名字过长 = 45017,
        分组数量超过上限 = 45018,
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        解析JSON_XML内容错误 = 47001,
        api功能未授权 = 48001,
        用户未授权该api = 50001,
        参数错误invalid_parameter = 61451,
        无效客服账号invalid_kf_account = 61452,
        客服帐号已存在kf_account_exsited = 61453,
        /// <summary>
        /// 客服帐号名长度超过限制(仅允许10个英文字符，不包括@及@后的公众号的微信号)(invalid kf_acount length)
        /// </summary>
        客服帐号名长度超过限制 = 61454,
        /// <summary>
        /// 客服帐号名包含非法字符(仅允许英文+数字)(illegal character in kf_account)
        /// </summary>
        客服帐号名包含非法字符 = 61455,
        /// <summary>
        ///  	客服帐号个数超过限制(10个客服账号)(kf_account count exceeded)
        /// </summary>
        客服帐号个数超过限制 = 61456,
        无效头像文件类型invalid_file_type = 61457,
        系统错误system_error = 61450,
        日期格式错误 = 61500,
        日期范围错误 = 61501,

        //新加入的一些类型，以下文字根据P2P项目格式组织，非官方文字
        发送消息失败_48小时内用户未互动 = 10706,
        发送消息失败_该用户已被加入黑名单_无法向此发送消息 = 62751,
        发送消息失败_对方关闭了接收消息 = 10703,
        对方不是粉丝 = 10700,
        没有留言权限 = 88000,//without comment privilege

        //开放平台

        该公众号_小程序已经绑定了开放平台帐号 = 89000,//account has bound open，该公众号/小程序已经绑定了开放平台帐号

        //小程序代码管理返回码
        不是由第三方代小程序进行调用 = 86000,
        不存在第三方的已经提交的代码 = 86001,
        标签格式错误 = 85006,
        页面路径错误 = 85007,
        类目填写错误 = 85008,
        已经有正在审核的版本 = 85009,
        item_list有项目为空 = 85010,
        标题填写错误 = 85011,
        无效的审核id = 85012,
        没有审核版本 = 85019,
        审核状态未满足发布 = 85020,
        状态不可变 = 85021,
        action非法 = 85022,
        审核列表填写的项目数不在1到5以内 = 85023,
        小程序还未设置昵称_头像_简介_请先设置完后再重新提交 = 86002,
        签名错误 = 87009


#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 企业号返回码
    /// </summary>
    public enum ReturnCode_QY
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        请求成功 = 0,
        获取access_token时Secret错误或者access_token无效 = 40001,
        不合法的凭证类型 = 40002,
        不合法的UserID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型 = 40008,
        不合法的corpid = 40013,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        不合法的按钮个数 = 40016,
        不合法的按钮类型 = 40017,
        不合法的按钮名字长度 = 40018,
        不合法的按钮KEY长度 = 40019,
        不合法的按钮URL长度 = 40020,
        不合法的菜单版本号 = 40021,
        不合法的子菜单级数 = 40022,
        不合法的子菜单按钮个数 = 40023,
        不合法的子菜单按钮类型 = 40024,
        不合法的子菜单按钮名字长度 = 40025,
        不合法的子菜单按钮KEY长度 = 40026,
        不合法的子菜单按钮URL长度 = 40027,
        不合法的自定义菜单使用成员 = 40028,
        不合法的oauth_code = 40029,
        不合法的UserID列表 = 40031,
        不合法的UserID列表长度 = 40032,
        不合法的请求字符_不能包含uxxxx格式的字符 = 40033,
        不合法的参数 = 40035,

        //小程序、 公众号都有
        template_id不正确 = 40037,

        不合法的请求格式 = 40038,
        不合法的URL长度 = 40039,
        不合法的插件token = 40040,
        不合法的插件id = 40041,
        不合法的插件会话 = 40042,
        url中包含不合法domain = 40048,
        不合法的子菜单url域名 = 40054,
        不合法的按钮url域名 = 40055,
        不合法的agentid = 40056,
        不合法的callbackurl = 40057,
        不合法的红包参数 = 40058,
        不合法的上报地理位置标志位 = 40059,
        设置上报地理位置标志位时没有设置callbackurl = 40060,
        设置应用头像失败 = 40061,
        不合法的应用模式 = 40062,
        红包参数为空 = 40063,
        管理组名字已存在 = 40064,
        不合法的管理组名字长度 = 40065,
        不合法的部门列表 = 40066,
        标题长度不合法 = 40067,
        不合法的标签ID = 40068,
        不合法的标签ID列表 = 40069,
        列表中所有标签_成员_ID都不合法 = 40070,
        不合法的标签名字_标签名字已经存在 = 40071,
        不合法的标签名字长度 = 40072,
        不合法的openid = 40073,
        news消息不支持指定为高保密消息 = 40074,
        不合法的预授权码 = 40077,
        不合法的临时授权码 = 40078,
        不合法的授权信息 = 40079,
        不合法的suitesecret = 40080,
        不合法的suitetoken = 40082,
        不合法的suiteid = 40083,
        不合法的永久授权码 = 40084,
        不合法的suiteticket = 40085,
        不合法的第三方应用appid = 40086,
        缺少access_token参数 = 41001,
        缺少corpid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        缺少oauthcode = 41008,
        缺少UserID = 41009,
        缺少url = 41010,
        缺少agentid = 41011,
        缺少应用头像mediaid = 41012,
        缺少应用名字 = 41013,
        缺少应用描述 = 41014,
        缺少Content = 41015,
        缺少标题 = 41016,
        缺少标签ID = 41017,
        缺少标签名字 = 41018,
        缺少suiteid = 41021,
        缺少suitetoken = 41022,
        缺少suiteticket = 41023,
        缺少suitesecret = 41024,
        缺少永久授权码 = 41025,

        //小程序
        form_id不正确_或者过期 = 41028,
        form_id已被使用 = 41029,
        page不正确 = 41030,


        access_token超时 = 42001,
        refresh_token超时 = 42002,
        oauth_code超时 = 42003,
        插件token超时 = 42004,
        预授权码失效 = 42007,
        临时授权码失效 = 42008,
        suitetoken失效 = 42009,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS = 43003,
        需要成员已关注 = 43004,
        需要好友关系 = 43005,
        需要订阅 = 43006,
        需要授权 = 43007,
        需要支付授权 = 43008,
        需要处于回调模式 = 43010,
        需要企业授权 = 43011,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
        文本消息内容为空 = 44004,
        多媒体文件大小超过限制 = 45001,
        消息内容超过限制 = 45002,
        标题字段超过限制 = 45003,
        描述字段超过限制 = 45004,
        链接字段超过限制 = 45005,
        图片链接字段超过限制 = 45006,
        语音播放时间超过限制 = 45007,
        图文消息超过限制 = 45008,
        接口调用超过限制 = 45009,
        创建菜单个数超过限制 = 45010,
        回复时间超过限制 = 45015,
        系统分组不允许修改 = 45016,
        分组名字过长 = 45017,
        分组数量超过上限 = 45018,
        账号数量超过上限 = 45024,
        mpnews消息每天只能发送100次 = 45027,
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        不存在的成员_46004 = 46004,
        解析JSONXML内容错误 = 47001,
        Api未授权 = 48001,
        Api禁用 = 48002,
        suitetoken无效 = 48003,
        授权关系无效 = 48004,
        redirect_uri未授权 = 50001,
        成员不在权限范围 = 50002,
        应用已停用 = 50003,
        成员状态不正确需要成员为企业验证中状态 = 50004,
        企业已禁用 = 50005,
        部门长度不符合限制 = 60001,
        部门层级深度超过限制 = 60002,
        部门不存在 = 60003,
        父亲部门不存在 = 60004,
        不允许删除有成员的部门 = 60005,
        不允许删除有子部门的部门 = 60006,
        不允许删除根部门 = 60007,
        部门名称已存在 = 60008,
        部门名称含有非法字符 = 60009,
        部门存在循环关系 = 60010,
        管理员权限不足_user_department_agent_无权限 = 60011,
        不允许删除默认应用 = 60012,
        不允许关闭应用 = 60013,
        不允许开启应用 = 60014,
        不允许修改默认应用可见范围 = 60015,
        不允许删除存在成员的标签 = 60016,
        不允许设置企业 = 60017,
        不允许设置应用地理位置上报开关 = 60019,
        访问ip不在白名单之中 = 60020,
        应用已授权予第三方不允许通过分级管理员修改菜单 = 60023,
        UserID已存在 = 60102,
        手机号码不合法 = 60103,
        手机号码已存在 = 60104,
        邮箱不合法 = 60105,
        邮箱已存在 = 60106,
        微信号不合法 = 60107,
        微信号已存在 = 60108,
        QQ号已存在 = 60109,
        部门个数超出限制 = 60110,
        UserID不存在 = 60111,
        成员姓名不合法 = 60112,
        身份认证信息_微信号_手机_邮箱_不能同时为空 = 60113,
        性别不合法 = 60114,
        已关注成员微信不能修改 = 60115,
        扩展属性已存在 = 60116,
        成员无有效邀请字段_微信_邮箱_手机号 = 60118,
        成员已关注 = 60119,
        成员已禁用 = 60120,
        找不到该成员 = 60121,
        邮箱已被外部管理员使用 = 60122,
        无效的部门id = 60123,
        无效的父部门id = 60124,
        部门名字长度超过限制 = 60125,
        创建部门失败 = 60126,
        缺少部门id = 60127,
        字段不合法可能存在主键冲突或者格式错误 = 60128,
        可信域名没有IPC备案后续将不能在该域名下正常使用jssdk = 80001,
        发送消息或者邀请的参数全部为空或者全部不合法 = 82001,
        不合法的PartyID列表长度 = 82002,
        不合法的TagID列表长度 = 82003,
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }

    /// <summary>
    /// 企业微信返回码
    /// </summary>
    public enum ReturnCode_Work
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        系统繁忙 = -1,
        请求成功 = 0,
        获取access_token时Secret错误_或者access_token无效 = 40001,
        不合法的凭证类型 = 40002,
        不合法的UserID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型 = 40008,
        不合法的corpid = 40013,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        不合法的按钮个数 = 40016,
        不合法的按钮类型 = 40017,
        不合法的按钮名字长度 = 40018,
        不合法的按钮KEY长度 = 40019,
        不合法的按钮URL长度 = 40020,
        不合法的菜单版本号 = 40021,
        不合法的子菜单级数 = 40022,
        不合法的子菜单按钮个数 = 40023,
        不合法的子菜单按钮类型 = 40024,
        不合法的子菜单按钮名字长度 = 40025,
        不合法的子菜单按钮KEY长度 = 40026,
        不合法的子菜单按钮URL长度 = 40027,
        不合法的自定义菜单使用成员 = 40028,
        不合法的oauth_code = 40029,
        不合法的UserID列表 = 40031,
        不合法的UserID列表长度 = 40032,
        不合法的请求字符_不能包含_反斜杠uxxxx格式的字符 = 40033,
        不合法的参数 = 40035,
        不合法的请求格式 = 40038,
        不合法的URL长度 = 40039,
        不合法的插件token = 40040,
        不合法的插件id = 40041,
        不合法的插件会话 = 40042,
        url中包含不合法domain = 40048,
        不合法的子菜单url域名 = 40054,
        不合法的按钮url域名 = 40055,
        不合法的agentid = 40056,
        不合法的callbackurl或者callbackurl验证失败 = 40057,
        不合法的红包参数 = 40058,
        不合法的上报地理位置标志位 = 40059,
        设置上报地理位置标志位时没有设置callbackurl = 40060,
        设置应用头像失败 = 40061,
        不合法的应用模式 = 40062,
        参数为空 = 40063,
        管理组名字已存在 = 40064,
        不合法的管理组名字长度 = 40065,
        不合法的部门列表 = 40066,
        标题长度不合法 = 40067,
        不合法的标签ID = 40068,
        不合法的标签ID列表 = 40069,
        列表中所有标签_成员_ID都不合法 = 40070,
        不合法的标签名字_标签名字已经存在 = 40071,
        不合法的标签名字长度 = 40072,
        不合法的openid = 40073,
        news消息不支持指定为高保密消息 = 40074,
        不合法的预授权码 = 40077,
        不合法的临时授权码 = 40078,
        不合法的授权信息 = 40079,
        不合法的suitesecret = 40080,
        不合法的suitetoken = 40082,
        不合法的suiteid = 40083,
        不合法的永久授权码 = 40084,
        不合法的suiteticket = 40085,
        不合法的第三方应用appid = 40086,
        导入文件存在不合法的内容 = 40092,
        不合法的跳转target = 40093,
        不合法的URL = 40094,
        修改失败_并发冲突 = 40095,
        请勿添加其他公众号的主页链接 = 40155,
        缺少access_token参数 = 41001,
        缺少corpid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        缺少oauth_code = 41008,
        缺少UserID = 41009,
        缺少url = 41010,
        缺少agentid = 41011,
        缺少应用头像mediaid = 41012,
        缺少应用名字 = 41013,
        缺少应用描述 = 41014,
        缺少Content = 41015,
        缺少标题 = 41016,
        缺少标签ID = 41017,
        缺少标签名字 = 41018,
        缺少suiteid = 41021,
        缺少suitetoken = 41022,
        缺少suiteticket = 41023,
        缺少suitesecret = 41024,
        缺少永久授权码 = 41025,
        缺少login_ticket = 41034,
        缺少跳转target = 41035,
        access_token过期 = 42001,
        refresh_token过期 = 42002,
        oauth_code过期 = 42003,
        插件token过期 = 42004,
        预授权码失效 = 42007,
        临时授权码失效 = 42008,
        suitetoken失效 = 42009,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS = 43003,
        需要成员已关注 = 43004,
        需要好友关系 = 43005,
        需要订阅 = 43006,
        需要授权 = 43007,
        需要支付授权 = 43008,
        需要处于接收消息模式 = 43010,
        需要企业授权 = 43011,
        应用对成员不可见 = 43013,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
        文本消息内容为空 = 44004,
        多媒体文件大小超过限制 = 45001,
        消息内容大小超过限制 = 45002,
        标题大小超过限制 = 45003,
        描述大小超过限制 = 45004,
        链接长度超过限制 = 45005,
        图片链接长度超过限制 = 45006,
        语音播放时间超过限制 = 45007,
        图文消息的文章数量不能超过8条 = 45008,
        接口调用超过限制 = 45009,
        创建菜单个数超过限制 = 45010,
        回复时间超过限制 = 45015,
        系统分组_不允许修改 = 45016,
        分组名字过长 = 45017,
        分组数量超过上限 = 45018,
        应用名字长度不合法_合法长度为2到16个字 = 45022,
        帐号数量超过上限 = 45024,
        同一个成员每周只能邀请一次 = 45025,
        触发删除用户数的保护 = 45026,
        mpnews每天只能发送100次 = 45027,
        素材数量超过上限 = 45028,
        media_id对该应用不可见 = 45029,
        作者名字长度超过限制 = 45032,
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        不存在的成员 = 46004,
        解析JSON_XML内容错误 = 47001,
        Api未授权 = 48001,
        Api禁用_一般是管理组类型与Api不匹配_例如普通管理组调用会话服务的Api_ = 48002,
        suitetoken无效 = 48003,
        授权关系无效 = 48004,
        Api已废弃 = 48005,
        redirect_uri未授权 = 50001,
        成员不在权限范围 = 50002,
        应用已停用 = 50003,
        成员状态不正确_需要成员为企业验证中状态 = 50004,
        企业已禁用 = 50005,
        部门长度不符合限制 = 60001,
        部门层级深度超过限制 = 60002,
        部门不存在 = 60003,
        父部门不存在 = 60004,
        不允许删除有成员的部门 = 60005,
        不允许删除有子部门的部门 = 60006,
        不允许删除根部门 = 60007,
        部门ID或者部门名称已存在 = 60008,
        部门名称含有非法字符 = 60009,
        部门存在循环关系 = 60010,
        权限不足_user_department_agent无权限_只有通迅录同步助手才有通迅录写权限_同时要开启写权限_ = 60011,
        不允许删除默认应用 = 60012,
        不允许关闭应用 = 60013,
        不允许开启应用 = 60014,
        不允许修改默认应用可见范围 = 60015,
        不允许删除存在成员的标签 = 60016,
        不允许设置企业 = 60017,
        不允许设置应用地理位置上报开关 = 60019,
        访问ip不在白名单之中 = 60020,
        已授权的应用不允许企业管理组调用接口修改菜单 = 60023,
        主页型应用不支持的消息类型 = 60025,
        不支持第三方修改主页型应用字段 = 60027,
        应用已授权予第三方_不允许通过接口修改主页url = 60028,
        应用已授权予第三方_不允许通过接口修改可信域名 = 60029,
        未设置管理组的登录授权域名 = 60031,
        UserID已存在 = 60102,
        手机号码不合法 = 60103,
        手机号码已存在 = 60104,
        邮箱不合法 = 60105,
        邮箱已存在 = 60106,
        微信号不合法 = 60107,
        微信号已存在 = 60108,
        QQ号已存在 = 60109,
        用户同时归属部门超过20个 = 60110,
        UserID不存在 = 60111,
        成员姓名不合法 = 60112,
        身份认证信息_微信号_手机_邮箱_不能同时为空 = 60113,
        性别不合法 = 60114,
        已关注成员微信不能修改 = 60115,
        扩展属性已存在 = 60116,
        成员无有效邀请字段_详情参考_邀请成员关注_的接口说明 = 60118,
        成员已关注 = 60119,
        成员已禁用 = 60120,
        找不到该成员 = 60121,
        邮箱已被外部管理员使用 = 60122,
        无效的部门id = 60123,
        无效的父部门id = 60124,
        非法部门名字_长度超过限制_重名等_重名包括与csv文件中同级部门重名或者与旧组织架构包含成员的同级部门重名 = 60125,
        创建部门失败 = 60126,
        缺少部门id = 60127,
        字段不合法_可能存在主键冲突或者格式错误 = 60128,
        用户设置了拒绝邀请 = 60129,
        不合法的职位长度 = 60131,
        可信域名不匹配_或者可信域名没有IPC备案_后续将不能在该域名下正常使用jssdk_ = 80001,
        邀请额度已用完 = 81003,
        部门数量超过上限 = 81004,
        发送消息或者邀请的参数全部为空或者全部不合法 = 82001,
        不合法的PartyID列表长度 = 82002,
        不合法的TagID列表长度 = 82003,
        微信版本号过低 = 82004,
        包含不合法的词语 = 85002,
        不合法的会话ID = 86001,
        不存在的会话ID = 86003,
        不合法的会话名 = 86004,
        不合法的会话管理员 = 86005,
        不合法的成员列表大小 = 86006,
        不存在的成员_86007 = 86007,
        需要会话管理员权限 = 86101,
        缺少会话ID = 86201,
        缺少会话名 = 86202,
        缺少会话管理员 = 86203,
        缺少成员 = 86204,
        非法的会话ID长度 = 86205,
        非法的会话ID数值 = 86206,
        会话管理员不在用户列表中 = 86207,
        消息服务未开启 = 86208,
        缺少操作者 = 86209,
        缺少会话参数 = 86210,
        缺少会话类型_单聊或者群聊_ = 86211,
        缺少发件人 = 86213,
        非法的会话类型 = 86214,
        会话已存在 = 86215,
        非法会话成员 = 86216,
        会话操作者不在成员列表中 = 86217,
        非法会话发件人 = 86218,
        非法会话收件人 = 86219,
        非法会话操作者 = 86220,
        单聊模式下_发件人与收件人不能为同一人 = 86221,
        不允许消息服务访问的API = 86222,
        不合法的消息类型_86304 = 86304,
        客服服务未启用 = 86305,
        缺少发送人 = 86306,
        缺少发送人类型 = 86307,
        缺少发送人id = 86308,
        缺少接收人 = 86309,
        缺少接收人类型 = 86310,
        缺少接收人id = 86311,
        缺少消息类型 = 86312,
        缺少客服_发送人或接收人类型_必须有一个为kf = 86313,
        客服不唯一_发送人或接收人类型_必须只有一个为kf = 86314,
        不合法的发送人类型 = 86315,
        不合法的发送人id_Userid不存在_openid不存在_kf不存在 = 86316,
        不合法的接收人类型 = 86317,
        不合法的接收人id_Userid不存在_openid不存在_kf不存在 = 86318,
        不合法的客服_kf不在客服列表中 = 86319,
        不合法的客服类型 = 86320,
        缺少seq参数 = 88001,
        缺少offset参数_88002 = 88002,
        非法seq = 88003,
        未认证摇一摇周边 = 90001,
        缺少摇一摇周边ticket参数 = 90002,
        摇一摇周边ticket参数不合法 = 90003,
        摇一摇周边ticket过期 = 90004,
        未开启摇一摇周边服务 = 90005,
        卡券已被核销 = 91004,
        无效的code = 91011,
        缺少卡券详情 = 91014,
        代金券缺少least_cost或者reduce_cost参数 = 91015,
        折扣券缺少discount参数 = 91016,
        礼品券缺少gift参数 = 91017,
        缺少卡券sku参数 = 91019,
        缺少卡券有效期 = 91020,
        缺少卡券有效期类型 = 91021,
        缺少卡券logo_url = 91022,
        缺少卡券code类型 = 91023,
        缺少卡券title = 91025,
        缺少卡券color = 91026,
        缺少offset参数_91027 = 91027,
        缺少count参数 = 91028,
        缺少card_id = 91029,
        缺少卡券code = 91030,
        缺少卡券notice = 91031,
        缺少卡券description = 91032,
        缺少ticket类型 = 91033,
        不合法的有效期 = 91036,
        变更库存值不合法 = 91038,
        不合法的卡券id = 91039,
        不合法的ticket_type = 91040,
        没有创建_上传卡券logo_以及核销卡券的权限 = 91041,
        没有该卡券投放权限 = 91042,
        没有修改或者删除该卡券的权限 = 91043,
        不合法的卡券参数 = 91044,
        缺少团购券groupon结构 = 91045,
        缺少现金券cash结构 = 91046,
        缺少折扣券discount_结构 = 91047,
        缺少礼品券gift结构 = 91048,
        缺少优惠券coupon结构 = 91049,
        缺少卡券必填字段 = 91050,
        商户名称超过12个汉字 = 91051,
        卡券标题超过9个汉字 = 91052,
        卡券提醒超过16个汉字 = 91053,
        卡券描述超过1024个汉字 = 91054,
        卡券副标题长度超过18个汉字 = 91055,
        应用id已存在 = 301001,
        accesstoken不允许操作其它应用 = 301002,
        不允许删除超级管理员 = 301004,
        消息型应用不允许做此操作 = 301005,
        不允许禁用超级管理员 = 301006,
        主页型应用不允许做此操作 = 301008,
        应用发送消息没有接收主体 = 301009,
        部门名已存在 = 301010,
        座机不合法 = 301013,
        英文名称不合法 = 301014,
        userid错误 = 301021,
        获取打卡数据失败 = 301022,
        useridlist非法或超过限额 = 301023,
        获取打卡记录时间间隔超限 = 301024,
        批量同步成员存在userid为空的用户 = 302001,
        管理员userid不存在 = 302002,
        存在重复的userid = 302003,
        /// <summary>
        /// （1不是一棵树，2 多个一样的partyid，3 partyid空，4 partyid name 空，5 同一个父节点下有两个子节点 部门名字一样 可能是以上情况，请一一排查）
        /// </summary>
        组织架构不合法 = 302004,

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }



    /// <summary>
    /// 语言
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 中文简体
        /// </summary>
        zh_CN,
        /// <summary>
        /// 中文繁体
        /// </summary>
        zh_TW,
        /// <summary>
        /// 英文
        /// </summary>
        en
    }

    /// <summary>
    /// AppStore状态
    /// </summary>
    public enum AppStoreState
    {
        /// <summary>
        /// 无状态
        /// </summary>
        None = 1,
        /// <summary>
        /// 已进入应用状态
        /// </summary>
        Enter = 2,
        /// <summary>
        /// 退出App状态（临时传输状态，退出后即为None）
        /// </summary>
        Exit = 4
    }

    /// <summary>
    /// 用户信息中的性别（sex）
    /// </summary>
    public enum Sex
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释   
        未知 = 0,
        男 = 1,
        女 = 2
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
