// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class vertex : Exchange
{
    public vertex (object args = null): base(args) {}

    public async Task<object> v1ArchivePost (object parameters = null)
    {
        return await this.callAsync ("v1ArchivePost",parameters);
    }

    public async Task<object> v1GatewayGetQuery (object parameters = null)
    {
        return await this.callAsync ("v1GatewayGetQuery",parameters);
    }

    public async Task<object> v1GatewayGetSymbols (object parameters = null)
    {
        return await this.callAsync ("v1GatewayGetSymbols",parameters);
    }

    public async Task<object> v1GatewayGetTime (object parameters = null)
    {
        return await this.callAsync ("v1GatewayGetTime",parameters);
    }

    public async Task<object> v1GatewayPostQuery (object parameters = null)
    {
        return await this.callAsync ("v1GatewayPostQuery",parameters);
    }

    public async Task<object> v1GatewayPostExecute (object parameters = null)
    {
        return await this.callAsync ("v1GatewayPostExecute",parameters);
    }

    public async Task<object> v1TriggerPostExecute (object parameters = null)
    {
        return await this.callAsync ("v1TriggerPostExecute",parameters);
    }

    public async Task<object> v1TriggerPostQuery (object parameters = null)
    {
        return await this.callAsync ("v1TriggerPostQuery",parameters);
    }

    public async Task<object> v2ArchiveGetTickers (object parameters = null)
    {
        return await this.callAsync ("v2ArchiveGetTickers",parameters);
    }

    public async Task<object> v2ArchiveGetContracts (object parameters = null)
    {
        return await this.callAsync ("v2ArchiveGetContracts",parameters);
    }

    public async Task<object> v2ArchiveGetTrades (object parameters = null)
    {
        return await this.callAsync ("v2ArchiveGetTrades",parameters);
    }

    public async Task<object> v2ArchiveGetVrtx (object parameters = null)
    {
        return await this.callAsync ("v2ArchiveGetVrtx",parameters);
    }

    public async Task<object> v2GatewayGetAssets (object parameters = null)
    {
        return await this.callAsync ("v2GatewayGetAssets",parameters);
    }

    public async Task<object> v2GatewayGetPairs (object parameters = null)
    {
        return await this.callAsync ("v2GatewayGetPairs",parameters);
    }

    public async Task<object> v2GatewayGetOrderbook (object parameters = null)
    {
        return await this.callAsync ("v2GatewayGetOrderbook",parameters);
    }

}