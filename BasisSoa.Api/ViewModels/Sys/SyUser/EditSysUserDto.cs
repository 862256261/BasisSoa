﻿
using BasisSoa.Common.LambdaHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasisSoa.Api.ViewModels.Sys
{

    public class EditSysUserDto
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        [SearchAttribute("Account", Symbol.等于)]
        public string Account { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>

        public string RoleId { get; set; }
        /// <summary>
        /// 组织ID
        /// </summary>
        public string OrganizeId { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string HeadIcon { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string WeChat { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [SearchAttribute("Tel", Symbol.相似)]
        public string Tel { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 真名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [SearchAttribute("Email", Symbol.相似)]
        public string Email { get; set; }

        /// <summary>
        /// 是否管理员（为了功能编辑个人资料中 附带企业信息）
        /// </summary>           
        public bool? IsAdministrator { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool? EnabledMark { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? SortCode { get; set; }






        //-------------------------额外



        /// <summary>
        /// 密码
        /// </summary>
        public string UserPassword { get; set; }
        /// <summary>
        /// 密码安全性
        /// </summary>
        public string PasswordSecurity { get; set; }
        /// <summary>
        /// 是否允许多用户登录
        /// </summary>
        public bool? MultiUserLogin { get; set; }
        /// <summary>
        /// 系统语言
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// 系统样式
        /// </summary>
        public string Theme { get; set; }



    }
}
