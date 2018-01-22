namespace Been.Soa.Contract
{
    /// <summary>
    /// 契约接口
    /// </summary>
    public interface IContract<T,S>
        where T:IContractRequest
        where S:IContractResponse
    {
    }
}
