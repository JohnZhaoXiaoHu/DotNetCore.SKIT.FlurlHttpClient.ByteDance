﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    public static class TikTokShopClientExecuteDutyFreeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /dutyFree/orderConfirm 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/53/702 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.DutyFreeOrderConfirmResponse> ExecuteDutyFreeOrderConfirmAsync(this TikTokShopClient client, Models.DutyFreeOrderConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "dutyFree", "orderConfirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.DutyFreeOrderConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
