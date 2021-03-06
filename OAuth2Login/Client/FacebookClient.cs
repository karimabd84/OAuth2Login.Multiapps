﻿using OAuth2Login.Configuration;
using OAuth2Login.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2Login.Client
{
    public class FacebookClient : AbstractClientProvider
    {
        public FacebookClient()
        {
        }

        public FacebookClient(OAuthWebConfigurationElement ccRoot, OAuthConfigurationElement ccOauth)
            : base(ccRoot, ccOauth)
        {
        }

        public FacebookClient(WebConfiguration ccRoot, OAuthSettingsConfig ccOauth)
            : base(ccRoot, ccOauth)
        {
        }
    }
}
