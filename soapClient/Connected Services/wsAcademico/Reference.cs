﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace soapClient.wsAcademico {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", ConfigurationName="wsAcademico.AcademicoWebService")]
    public interface AcademicoWebService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getEstudianteReques" +
            "t", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getEstudianteRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        soapClient.wsAcademico.getEstudianteResponse getEstudiante(soapClient.wsAcademico.getEstudianteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getEstudianteReques" +
            "t", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getEstudianteRespon" +
            "se")]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getEstudianteResponse> getEstudianteAsync(soapClient.wsAcademico.getEstudianteRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getProfesorRequest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getProfesorResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        soapClient.wsAcademico.getProfesorResponse getProfesor(soapClient.wsAcademico.getProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getProfesorRequest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getProfesorResponse" +
            "")]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getProfesorResponse> getProfesorAsync(soapClient.wsAcademico.getProfesorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAllEstudianteReq" +
            "uest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAllEstudianteRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        soapClient.wsAcademico.getAllEstudianteResponse getAllEstudiante(soapClient.wsAcademico.getAllEstudianteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAllEstudianteReq" +
            "uest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAllEstudianteRes" +
            "ponse")]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getAllEstudianteResponse> getAllEstudianteAsync(soapClient.wsAcademico.getAllEstudianteRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAsignaturaReques" +
            "t", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAsignaturaRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        soapClient.wsAcademico.getAsignaturaResponse getAsignatura(soapClient.wsAcademico.getAsignaturaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAsignaturaReques" +
            "t", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/getAsignaturaRespon" +
            "se")]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getAsignaturaResponse> getAsignaturaAsync(soapClient.wsAcademico.getAsignaturaRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/holaMundoRequest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/holaMundoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        soapClient.wsAcademico.holaMundoResponse holaMundo(soapClient.wsAcademico.holaMundoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/holaMundoRequest", ReplyAction="http://soap.sparkjavasoap.avathartech.com/AcademicoWebService/holaMundoResponse")]
        System.Threading.Tasks.Task<soapClient.wsAcademico.holaMundoResponse> holaMundoAsync(soapClient.wsAcademico.holaMundoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/")]
    public partial class estudiante : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int matriculaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int matricula {
            get {
                return this.matriculaField;
            }
            set {
                this.matriculaField = value;
                this.RaisePropertyChanged("matricula");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/")]
    public partial class asignatura : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string claveField;
        
        private estudiante[] estudiantesField;
        
        private int grupoField;
        
        private int idField;
        
        private string nombreField;
        
        private profesor profesorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string clave {
            get {
                return this.claveField;
            }
            set {
                this.claveField = value;
                this.RaisePropertyChanged("clave");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("estudiantes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=1)]
        public estudiante[] estudiantes {
            get {
                return this.estudiantesField;
            }
            set {
                this.estudiantesField = value;
                this.RaisePropertyChanged("estudiantes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int grupo {
            get {
                return this.grupoField;
            }
            set {
                this.grupoField = value;
                this.RaisePropertyChanged("grupo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public profesor profesor {
            get {
                return this.profesorField;
            }
            set {
                this.profesorField = value;
                this.RaisePropertyChanged("profesor");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/")]
    public partial class profesor : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cedulaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cedula {
            get {
                return this.cedulaField;
            }
            set {
                this.cedulaField = value;
                this.RaisePropertyChanged("cedula");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstudiante", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getEstudianteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getEstudianteRequest() {
        }
        
        public getEstudianteRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstudianteResponse", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getEstudianteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapClient.wsAcademico.estudiante @return;
        
        public getEstudianteResponse() {
        }
        
        public getEstudianteResponse(soapClient.wsAcademico.estudiante @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesor", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public getProfesorRequest() {
        }
        
        public getProfesorRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getProfesorResponse", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapClient.wsAcademico.profesor @return;
        
        public getProfesorResponse() {
        }
        
        public getProfesorResponse(soapClient.wsAcademico.profesor @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllEstudiante", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getAllEstudianteRequest {
        
        public getAllEstudianteRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllEstudianteResponse", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getAllEstudianteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapClient.wsAcademico.estudiante[] @return;
        
        public getAllEstudianteResponse() {
        }
        
        public getAllEstudianteResponse(soapClient.wsAcademico.estudiante[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAsignatura", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getAsignaturaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getAsignaturaRequest() {
        }
        
        public getAsignaturaRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAsignaturaResponse", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class getAsignaturaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public soapClient.wsAcademico.asignatura @return;
        
        public getAsignaturaResponse() {
        }
        
        public getAsignaturaResponse(soapClient.wsAcademico.asignatura @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="holaMundo", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class holaMundoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public holaMundoRequest() {
        }
        
        public holaMundoRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="holaMundoResponse", WrapperNamespace="http://soap.sparkjavasoap.avathartech.com/", IsWrapped=true)]
    public partial class holaMundoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.sparkjavasoap.avathartech.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public holaMundoResponse() {
        }
        
        public holaMundoResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AcademicoWebServiceChannel : soapClient.wsAcademico.AcademicoWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AcademicoWebServiceClient : System.ServiceModel.ClientBase<soapClient.wsAcademico.AcademicoWebService>, soapClient.wsAcademico.AcademicoWebService {
        
        public AcademicoWebServiceClient() {
        }
        
        public AcademicoWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AcademicoWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcademicoWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AcademicoWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        soapClient.wsAcademico.getEstudianteResponse soapClient.wsAcademico.AcademicoWebService.getEstudiante(soapClient.wsAcademico.getEstudianteRequest request) {
            return base.Channel.getEstudiante(request);
        }
        
        public soapClient.wsAcademico.estudiante getEstudiante(int arg0) {
            soapClient.wsAcademico.getEstudianteRequest inValue = new soapClient.wsAcademico.getEstudianteRequest();
            inValue.arg0 = arg0;
            soapClient.wsAcademico.getEstudianteResponse retVal = ((soapClient.wsAcademico.AcademicoWebService)(this)).getEstudiante(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getEstudianteResponse> soapClient.wsAcademico.AcademicoWebService.getEstudianteAsync(soapClient.wsAcademico.getEstudianteRequest request) {
            return base.Channel.getEstudianteAsync(request);
        }
        
        public System.Threading.Tasks.Task<soapClient.wsAcademico.getEstudianteResponse> getEstudianteAsync(int arg0) {
            soapClient.wsAcademico.getEstudianteRequest inValue = new soapClient.wsAcademico.getEstudianteRequest();
            inValue.arg0 = arg0;
            return ((soapClient.wsAcademico.AcademicoWebService)(this)).getEstudianteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        soapClient.wsAcademico.getProfesorResponse soapClient.wsAcademico.AcademicoWebService.getProfesor(soapClient.wsAcademico.getProfesorRequest request) {
            return base.Channel.getProfesor(request);
        }
        
        public soapClient.wsAcademico.profesor getProfesor(string arg0) {
            soapClient.wsAcademico.getProfesorRequest inValue = new soapClient.wsAcademico.getProfesorRequest();
            inValue.arg0 = arg0;
            soapClient.wsAcademico.getProfesorResponse retVal = ((soapClient.wsAcademico.AcademicoWebService)(this)).getProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getProfesorResponse> soapClient.wsAcademico.AcademicoWebService.getProfesorAsync(soapClient.wsAcademico.getProfesorRequest request) {
            return base.Channel.getProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<soapClient.wsAcademico.getProfesorResponse> getProfesorAsync(string arg0) {
            soapClient.wsAcademico.getProfesorRequest inValue = new soapClient.wsAcademico.getProfesorRequest();
            inValue.arg0 = arg0;
            return ((soapClient.wsAcademico.AcademicoWebService)(this)).getProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        soapClient.wsAcademico.getAllEstudianteResponse soapClient.wsAcademico.AcademicoWebService.getAllEstudiante(soapClient.wsAcademico.getAllEstudianteRequest request) {
            return base.Channel.getAllEstudiante(request);
        }
        
        public soapClient.wsAcademico.estudiante[] getAllEstudiante() {
            soapClient.wsAcademico.getAllEstudianteRequest inValue = new soapClient.wsAcademico.getAllEstudianteRequest();
            soapClient.wsAcademico.getAllEstudianteResponse retVal = ((soapClient.wsAcademico.AcademicoWebService)(this)).getAllEstudiante(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getAllEstudianteResponse> soapClient.wsAcademico.AcademicoWebService.getAllEstudianteAsync(soapClient.wsAcademico.getAllEstudianteRequest request) {
            return base.Channel.getAllEstudianteAsync(request);
        }
        
        public System.Threading.Tasks.Task<soapClient.wsAcademico.getAllEstudianteResponse> getAllEstudianteAsync() {
            soapClient.wsAcademico.getAllEstudianteRequest inValue = new soapClient.wsAcademico.getAllEstudianteRequest();
            return ((soapClient.wsAcademico.AcademicoWebService)(this)).getAllEstudianteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        soapClient.wsAcademico.getAsignaturaResponse soapClient.wsAcademico.AcademicoWebService.getAsignatura(soapClient.wsAcademico.getAsignaturaRequest request) {
            return base.Channel.getAsignatura(request);
        }
        
        public soapClient.wsAcademico.asignatura getAsignatura(int arg0) {
            soapClient.wsAcademico.getAsignaturaRequest inValue = new soapClient.wsAcademico.getAsignaturaRequest();
            inValue.arg0 = arg0;
            soapClient.wsAcademico.getAsignaturaResponse retVal = ((soapClient.wsAcademico.AcademicoWebService)(this)).getAsignatura(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<soapClient.wsAcademico.getAsignaturaResponse> soapClient.wsAcademico.AcademicoWebService.getAsignaturaAsync(soapClient.wsAcademico.getAsignaturaRequest request) {
            return base.Channel.getAsignaturaAsync(request);
        }
        
        public System.Threading.Tasks.Task<soapClient.wsAcademico.getAsignaturaResponse> getAsignaturaAsync(int arg0) {
            soapClient.wsAcademico.getAsignaturaRequest inValue = new soapClient.wsAcademico.getAsignaturaRequest();
            inValue.arg0 = arg0;
            return ((soapClient.wsAcademico.AcademicoWebService)(this)).getAsignaturaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        soapClient.wsAcademico.holaMundoResponse soapClient.wsAcademico.AcademicoWebService.holaMundo(soapClient.wsAcademico.holaMundoRequest request) {
            return base.Channel.holaMundo(request);
        }
        
        public string holaMundo(string arg0) {
            soapClient.wsAcademico.holaMundoRequest inValue = new soapClient.wsAcademico.holaMundoRequest();
            inValue.arg0 = arg0;
            soapClient.wsAcademico.holaMundoResponse retVal = ((soapClient.wsAcademico.AcademicoWebService)(this)).holaMundo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<soapClient.wsAcademico.holaMundoResponse> soapClient.wsAcademico.AcademicoWebService.holaMundoAsync(soapClient.wsAcademico.holaMundoRequest request) {
            return base.Channel.holaMundoAsync(request);
        }
        
        public System.Threading.Tasks.Task<soapClient.wsAcademico.holaMundoResponse> holaMundoAsync(string arg0) {
            soapClient.wsAcademico.holaMundoRequest inValue = new soapClient.wsAcademico.holaMundoRequest();
            inValue.arg0 = arg0;
            return ((soapClient.wsAcademico.AcademicoWebService)(this)).holaMundoAsync(inValue);
        }
    }
}
