﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "ResultBinding", Namespace = "http://api-v1.gen.mm.vodafone.com/mminterface/result")]
public partial class ResultMgrService : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback GenericAPIResultOperationCompleted;

    /// <remarks/>
    public ResultMgrService()
    {
        this.Url = "http://api-v1.gen.mm.vodafone.com/mminterface/result";
    }

    /// <remarks/>
    public event GenericAPIResultCompletedEventHandler GenericAPIResultCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    [return: System.Xml.Serialization.XmlElementAttribute("ResponseMsg", Namespace = "http://api-v1.gen.mm.vodafone.com/mminterface/result")]
    public string GenericAPIResult([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://api-v1.gen.mm.vodafone.com/mminterface/result")] string ResultMsg)
    {
        object[] results = this.Invoke("GenericAPIResult", new object[] {
                    ResultMsg});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginGenericAPIResult(string ResultMsg, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("GenericAPIResult", new object[] {
                    ResultMsg}, callback, asyncState);
    }

    /// <remarks/>
    public string EndGenericAPIResult(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void GenericAPIResultAsync(string ResultMsg)
    {
        this.GenericAPIResultAsync(ResultMsg, null);
    }

    /// <remarks/>
    public void GenericAPIResultAsync(string ResultMsg, object userState)
    {
        if ((this.GenericAPIResultOperationCompleted == null))
        {
            this.GenericAPIResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGenericAPIResultOperationCompleted);
        }
        this.InvokeAsync("GenericAPIResult", new object[] {
                    ResultMsg}, this.GenericAPIResultOperationCompleted, userState);
    }

    private void OnGenericAPIResultOperationCompleted(object arg)
    {
        if ((this.GenericAPIResultCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.GenericAPIResultCompleted(this, new GenericAPIResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
public delegate void GenericAPIResultCompletedEventHandler(object sender, GenericAPIResultCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class GenericAPIResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal GenericAPIResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
        base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
