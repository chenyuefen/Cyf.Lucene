﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyf.SearchEngines.UnitTestProject.WCFTest {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTest.ISearcher")]
    public interface ISearcher {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISearcher/QueryCommodityPage", ReplyAction="http://tempuri.org/ISearcher/QueryCommodityPageResponse")]
        string QueryCommodityPage(int pageIndex, int pageSize, string keyword, int[] categoryIdList, string priceFilter, string priceOrderBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISearcher/QueryCommodityPage", ReplyAction="http://tempuri.org/ISearcher/QueryCommodityPageResponse")]
        System.Threading.Tasks.Task<string> QueryCommodityPageAsync(int pageIndex, int pageSize, string keyword, int[] categoryIdList, string priceFilter, string priceOrderBy);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISearcherChannel : Cyf.SearchEngines.UnitTestProject.WCFTest.ISearcher, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearcherClient : System.ServiceModel.ClientBase<Cyf.SearchEngines.UnitTestProject.WCFTest.ISearcher>, Cyf.SearchEngines.UnitTestProject.WCFTest.ISearcher {
        
        public SearcherClient() {
        }
        
        public SearcherClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearcherClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearcherClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearcherClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string QueryCommodityPage(int pageIndex, int pageSize, string keyword, int[] categoryIdList, string priceFilter, string priceOrderBy) {
            return base.Channel.QueryCommodityPage(pageIndex, pageSize, keyword, categoryIdList, priceFilter, priceOrderBy);
        }
        
        public System.Threading.Tasks.Task<string> QueryCommodityPageAsync(int pageIndex, int pageSize, string keyword, int[] categoryIdList, string priceFilter, string priceOrderBy) {
            return base.Channel.QueryCommodityPageAsync(pageIndex, pageSize, keyword, categoryIdList, priceFilter, priceOrderBy);
        }
    }
}
