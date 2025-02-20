﻿using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new ByteDanceMicroAppClient(new ByteDanceMicroAppClientOptions()
            {
                AppId = TestConfigs.MicroAppId,
                AppSecret =  TestConfigs.MicroAppSecret
            });
        }

        public static readonly ByteDanceMicroAppClient Instance;
    }
}
