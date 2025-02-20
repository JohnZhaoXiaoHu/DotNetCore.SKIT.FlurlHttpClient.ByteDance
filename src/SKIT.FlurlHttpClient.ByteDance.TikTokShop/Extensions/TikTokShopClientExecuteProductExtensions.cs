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
    public static class TikTokShopClientExecuteProductExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /product/listV2 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/633 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductListV2Response> ExecuteProductListV2Async(this TikTokShopClient client, Models.ProductListV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "listV2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductListV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/addV2 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/249 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductAddV2Response> ExecuteProductAddV2Async(this TikTokShopClient client, Models.ProductAddV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "addV2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductAddV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/editV2 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/250 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductEditV2Response> ExecuteProductEditV2Async(this TikTokShopClient client, Models.ProductEditV2Request request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "editV2")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductEditV2Response>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/detail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/56 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDetailResponse> ExecuteProductDetailAsync(this TikTokShopClient client, Models.ProductDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "detail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/del 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/61 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductDeleteResponse> ExecuteProductDeleteAsync(this TikTokShopClient client, Models.ProductDeleteRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "del")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductDeleteResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/getCateProperty 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/94 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductGetCategoryPropertyResponse> ExecuteProductGetCategoryPropertyAsync(this TikTokShopClient client, Models.ProductGetCategoryPropertyRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "getCateProperty")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductGetCategoryPropertyResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/setOnline 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/251 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSetOnlineResponse> ExecuteProductSetOnlineAsync(this TikTokShopClient client, Models.ProductSetOnlineRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "setOnline")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSetOnlineResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/setOffline 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/252 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductSetOfflineResponse> ExecuteProductSetOfflineAsync(this TikTokShopClient client, Models.ProductSetOfflineRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "setOffline")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductSetOfflineResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/editBuyerLimit 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/262 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductEditBuyerLimitResponse> ExecuteProductEditBuyerLimitAsync(this TikTokShopClient client, Models.ProductEditBuyerLimitRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "editBuyerLimit")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductEditBuyerLimitResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Quality
        /// <summary>
        /// <para>异步调用 [POST] /product/qualityTask 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/937 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductQualityTaskResponse> ExecuteProductQualityTaskAsync(this TikTokShopClient client, Models.ProductQualityTaskRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "qualityTask")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductQualityTaskResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/qualityList 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/938 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductQualityListResponse> ExecuteProductQualityListAsync(this TikTokShopClient client, Models.ProductQualityListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "qualityList")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductQualityListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /product/qualityDetail 接口。</para>
        /// <para>REF: https://op.jinritemai.com/docs/api-docs/14/939 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.ProductQualityDetailResponse> ExecuteProductQualityDetailAsync(this TikTokShopClient client, Models.ProductQualityDetailRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "product", "qualityDetail")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.ProductQualityDetailResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
