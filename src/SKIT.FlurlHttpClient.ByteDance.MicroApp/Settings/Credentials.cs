﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 的副本。
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.AppSecret"/> 的副本。
        /// </summary>
        public string AppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.ECPaySalt"/> 的副本。
        /// </summary>
        public string? ECPaySalt { get; }

        internal Credentials(ByteDanceMicroAppClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            AppId = options.AppId;
            AppSecret = options.AppSecret;
            PushToken = options.PushToken;
            ECPaySalt = options.ECPaySalt;
        }
    }
}
