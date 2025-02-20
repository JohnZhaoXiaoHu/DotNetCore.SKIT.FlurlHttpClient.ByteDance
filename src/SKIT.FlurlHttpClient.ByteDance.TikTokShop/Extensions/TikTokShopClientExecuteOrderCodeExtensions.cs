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
    public static class TikTokShopClientExecuteOrderCodeExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /orderCode/erpShopBindOrderCode 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/51/546 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderCodeERPShopBindOrderCodeResponse> ExecuteOrderCodeERPShopBindOrderCodeAsync(this TikTokShopClient client, Models.OrderCodeERPShopBindOrderCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orderCode", "erpShopBindOrderCode")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderCodeERPShopBindOrderCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /orderCode/downloadOrderCodeByShop 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/51/479 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderCodeDownloadOrderCodeByShopResponse> ExecuteOrderCodeDownloadOrderCodeByShopAsync(this TikTokShopClient client, Models.OrderCodeDownloadOrderCodeByShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orderCode", "downloadOrderCodeByShop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderCodeDownloadOrderCodeByShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /orderCode/batchGetOrderCodeByShop 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/51/688 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.OrderCodeBatchGetOrderCodeByShopResponse> ExecuteOrderCodeBatchGetOrderCodeByShopAsync(this TikTokShopClient client, Models.OrderCodeBatchGetOrderCodeByShopRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "orderCode", "batchGetOrderCodeByShop")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.OrderCodeBatchGetOrderCodeByShopResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
