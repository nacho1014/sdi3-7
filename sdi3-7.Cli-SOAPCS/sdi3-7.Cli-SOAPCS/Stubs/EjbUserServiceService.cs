﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// Este código fuente fue generado automáticamente por wsdl, Versión=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="EjbUserServiceServiceSoapBinding", Namespace="http://impl.business.sdi.com/")]
public partial class EjbUserServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback findByIdOperationCompleted;
    
    private System.Threading.SendOrPostCallback saveUserOperationCompleted;
    
    private System.Threading.SendOrPostCallback verifyOperationCompleted;
    
    private System.Threading.SendOrPostCallback updateUserOperationCompleted;
    
    private System.Threading.SendOrPostCallback findAllUsersOperationCompleted;
    
    /// <remarks/>
    public EjbUserServiceService() {
        this.Url = "http://localhost:8280/sdi3-7.EJB/UserService";
    }
    
    /// <remarks/>
    public event findByIdCompletedEventHandler findByIdCompleted;
    
    /// <remarks/>
    public event saveUserCompletedEventHandler saveUserCompleted;
    
    /// <remarks/>
    public event verifyCompletedEventHandler verifyCompleted;
    
    /// <remarks/>
    public event updateUserCompletedEventHandler updateUserCompleted;
    
    /// <remarks/>
    public event findAllUsersCompletedEventHandler findAllUsersCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://impl.business.sdi.com/", ResponseNamespace="http://impl.business.sdi.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public user findById([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] long arg0, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool arg0Specified) {
        object[] results = this.Invoke("findById", new object[] {
                    arg0,
                    arg0Specified});
        return ((user)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginfindById(long arg0, bool arg0Specified, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("findById", new object[] {
                    arg0,
                    arg0Specified}, callback, asyncState);
    }
    
    /// <remarks/>
    public user EndfindById(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((user)(results[0]));
    }
    
    /// <remarks/>
    public void findByIdAsync(long arg0, bool arg0Specified) {
        this.findByIdAsync(arg0, arg0Specified, null);
    }
    
    /// <remarks/>
    public void findByIdAsync(long arg0, bool arg0Specified, object userState) {
        if ((this.findByIdOperationCompleted == null)) {
            this.findByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindByIdOperationCompleted);
        }
        this.InvokeAsync("findById", new object[] {
                    arg0,
                    arg0Specified}, this.findByIdOperationCompleted, userState);
    }
    
    private void OnfindByIdOperationCompleted(object arg) {
        if ((this.findByIdCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.findByIdCompleted(this, new findByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://impl.business.sdi.com/", ResponseNamespace="http://impl.business.sdi.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public bool saveUser([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] user arg0) {
        object[] results = this.Invoke("saveUser", new object[] {
                    arg0});
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginsaveUser(user arg0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("saveUser", new object[] {
                    arg0}, callback, asyncState);
    }
    
    /// <remarks/>
    public bool EndsaveUser(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((bool)(results[0]));
    }
    
    /// <remarks/>
    public void saveUserAsync(user arg0) {
        this.saveUserAsync(arg0, null);
    }
    
    /// <remarks/>
    public void saveUserAsync(user arg0, object userState) {
        if ((this.saveUserOperationCompleted == null)) {
            this.saveUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsaveUserOperationCompleted);
        }
        this.InvokeAsync("saveUser", new object[] {
                    arg0}, this.saveUserOperationCompleted, userState);
    }
    
    private void OnsaveUserOperationCompleted(object arg) {
        if ((this.saveUserCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.saveUserCompleted(this, new saveUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://impl.business.sdi.com/", ResponseNamespace="http://impl.business.sdi.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public user verify([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg1) {
        object[] results = this.Invoke("verify", new object[] {
                    arg0,
                    arg1});
        return ((user)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginverify(string arg0, string arg1, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("verify", new object[] {
                    arg0,
                    arg1}, callback, asyncState);
    }
    
    /// <remarks/>
    public user Endverify(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((user)(results[0]));
    }
    
    /// <remarks/>
    public void verifyAsync(string arg0, string arg1) {
        this.verifyAsync(arg0, arg1, null);
    }
    
    /// <remarks/>
    public void verifyAsync(string arg0, string arg1, object userState) {
        if ((this.verifyOperationCompleted == null)) {
            this.verifyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnverifyOperationCompleted);
        }
        this.InvokeAsync("verify", new object[] {
                    arg0,
                    arg1}, this.verifyOperationCompleted, userState);
    }
    
    private void OnverifyOperationCompleted(object arg) {
        if ((this.verifyCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.verifyCompleted(this, new verifyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://impl.business.sdi.com/", ResponseNamespace="http://impl.business.sdi.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void updateUser([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] user arg0) {
        this.Invoke("updateUser", new object[] {
                    arg0});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginupdateUser(user arg0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("updateUser", new object[] {
                    arg0}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndupdateUser(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    public void updateUserAsync(user arg0) {
        this.updateUserAsync(arg0, null);
    }
    
    /// <remarks/>
    public void updateUserAsync(user arg0, object userState) {
        if ((this.updateUserOperationCompleted == null)) {
            this.updateUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateUserOperationCompleted);
        }
        this.InvokeAsync("updateUser", new object[] {
                    arg0}, this.updateUserOperationCompleted, userState);
    }
    
    private void OnupdateUserOperationCompleted(object arg) {
        if ((this.updateUserCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.updateUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://impl.business.sdi.com/", ResponseNamespace="http://impl.business.sdi.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public user[] findAllUsers() {
        object[] results = this.Invoke("findAllUsers", new object[0]);
        return ((user[])(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginfindAllUsers(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("findAllUsers", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public user[] EndfindAllUsers(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((user[])(results[0]));
    }
    
    /// <remarks/>
    public void findAllUsersAsync() {
        this.findAllUsersAsync(null);
    }
    
    /// <remarks/>
    public void findAllUsersAsync(object userState) {
        if ((this.findAllUsersOperationCompleted == null)) {
            this.findAllUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindAllUsersOperationCompleted);
        }
        this.InvokeAsync("findAllUsers", new object[0], this.findAllUsersOperationCompleted, userState);
    }
    
    private void OnfindAllUsersOperationCompleted(object arg) {
        if ((this.findAllUsersCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.findAllUsersCompleted(this, new findAllUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void findByIdCompletedEventHandler(object sender, findByIdCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class findByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal findByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public user Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((user)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void saveUserCompletedEventHandler(object sender, saveUserCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class saveUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal saveUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public bool Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void verifyCompletedEventHandler(object sender, verifyCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class verifyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal verifyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public user Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((user)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void updateUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void findAllUsersCompletedEventHandler(object sender, findAllUsersCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class findAllUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal findAllUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public user[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((user[])(this.results[0]));
        }
    }
}
