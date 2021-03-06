﻿using OAuth2Login.Configuration;
using OAuth2Login.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2Login.Client
{
    public class TwitterClient : AbstractClientProvider
    {
        public TwitterClient()
        {
        }

        public TwitterClient(OAuthWebConfigurationElement ccRoot, OAuthConfigurationElement ccOauth)
            : base(ccRoot, ccOauth)
        {
        }

        public TwitterClient(WebConfiguration ccRoot, OAuthSettingsConfig ccOauth)
            : base(ccRoot, ccOauth)
        {
        }
    }
}
