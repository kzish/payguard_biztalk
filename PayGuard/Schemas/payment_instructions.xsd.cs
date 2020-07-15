namespace PayGuard.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"https://softrite.co.zw/PayGuard.Schemas.payment_instructions",@"payment_instructions")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"payment_instructions"})]
    public sealed class payment_instructions : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://softrite.co.zw/PayGuard.Schemas.payment_instructions"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://softrite.co.zw/PayGuard.Schemas.payment_instructions"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""payment_instructions"">
    <xs:complexType>
      <xs:sequence>
        <xs:sequence minOccurs=""1"">
          <xs:element name=""payments"">
            <xs:complexType>
              <xs:sequence>
                <xs:element minOccurs=""1"" name=""date_time_submitted"" type=""xs:dateTime"" />
                <xs:element minOccurs=""1"" name=""sender_bank_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""sender_bank_branch_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""sender_account_number"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""recipient_bank_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""recipient_bank_branch_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""recipient_amount"" type=""xs:decimal"" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public payment_instructions() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "payment_instructions";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
