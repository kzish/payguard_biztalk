namespace PayGuard.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"https://softrite.co.zw/PayGuard.Schemas.bulk_payment_out",@"bulk_payment_out")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"bulk_payment_out"})]
    public sealed class bulk_payment_out : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""https://softrite.co.zw/PayGuard.Schemas.bulk_payment_out"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://softrite.co.zw/PayGuard.Schemas.bulk_payment_out"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""bulk_payment_out"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" name=""date_time_submitted"" type=""xs:dateTime"" />
        <xs:element minOccurs=""1"" name=""sender_bank_code"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""sender_bank_branch_code"" type=""xs:string"" />
        <xs:element minOccurs=""1"" name=""sender_account_number"" type=""xs:string"" />
        <xs:element minOccurs=""1"" default=""0"" name=""sender_total_amount"" type=""xs:decimal"" />
        <xs:sequence minOccurs=""1"">
          <xs:element name=""recipients"">
            <xs:complexType>
              <xs:sequence>
                <xs:element minOccurs=""1"" name=""recipient_bank_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""recipient_bank_branch_code"" type=""xs:string"" />
                <xs:element minOccurs=""1"" name=""recipient_account_number"" type=""xs:string"" />
                <xs:element minOccurs=""1"" default=""0"" name=""recipient_amount"" type=""xs:decimal"" />
              </xs:sequence>
            </xs:complexType>
          </xs:element>
        </xs:sequence>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public bulk_payment_out() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "bulk_payment_out";
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
