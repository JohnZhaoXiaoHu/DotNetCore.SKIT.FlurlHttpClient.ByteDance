﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientExecutePOIOrderExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /poi/order/sync 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848798579239290892 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderSyncResponse> ExecutePOIOrderSyncAsync(this TikTokClient client, Models.POIOrderSyncRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (request.DateTimeUnixMilliseconds == null)
                request.DateTimeUnixMilliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "sync")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderSyncResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /poi/order/status 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6848806501990074382 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderStatusResponse> ExecutePOIOrderStatusAsync(this TikTokClient client, Models.POIOrderStatusRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "status")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderStatusResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// <para>异步调用 [POST] /poi/order/confirm 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6875919211793778699 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderConfirmResponse> ExecutePOIOrderConfirmAsync(this TikTokClient client, Models.POIOrderConfirmRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "poi", "order", "confirm")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.POIOrderConfirmResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/order/bill/token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6898241240786126861 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderBillTokenResponse> ExecutePOIOrderBillTokenAsync(this TikTokClient client, Models.POIOrderBillTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "order", "bill", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("bill_date", request.BillDateString);

            return await client.SendRequestWithJsonAsync<Models.POIOrderBillTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /poi/order/list/token 接口。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6932733054666524685 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.POIOrderListTokenResponse> ExecutePOIOrderListTokenAsync(this TikTokClient client, Models.POIOrderListTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "poi", "order", "list", "token")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("order_date", request.OrderDateString);

            return await client.SendRequestWithJsonAsync<Models.POIOrderListTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
    }
}
