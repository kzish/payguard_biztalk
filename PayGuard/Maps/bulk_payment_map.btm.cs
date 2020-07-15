namespace PayGuard.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PayGuard.Schemas.bulk_payment_in", typeof(global::PayGuard.Schemas.bulk_payment_in))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PayGuard.Schemas.bulk_payment_out", typeof(global::PayGuard.Schemas.bulk_payment_out))]
    public sealed class bulk_payment_map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""https://softrite.co.zw/PayGuard.Schemas.bulk_payment_out"" xmlns:s0=""https://softrite.co.zw/PayGuard.Schemas.bulk_payment_in"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:bulk_payment_in"" />
  </xsl:template>
  <xsl:template match=""/s0:bulk_payment_in"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(string(recipients/recipient_bank_code/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string($var:v2) , string(recipients/recipient_bank_branch_code/text()))"" />
    <xsl:variable name=""var:v4"" select=""string(recipients/recipient_bank_code/text())"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringUpperCase($var:v4)"" />
    <xsl:variable name=""var:v6"" select=""string(recipients/recipient_bank_branch_code/text())"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(string($var:v5) , $var:v6)"" />
    <ns0:bulk_payment_out>
      <date_time_submitted>
        <xsl:value-of select=""$var:v1"" />
      </date_time_submitted>
      <sender_bank_code>
        <xsl:value-of select=""sender_bank_code/text()"" />
      </sender_bank_code>
      <sender_bank_branch_code>
        <xsl:value-of select=""sender_bank_branch_code/text()"" />
      </sender_bank_branch_code>
      <sender_account_number>
        <xsl:value-of select=""sender_account_number/text()"" />
      </sender_account_number>
      <sender_total_amount>
        <xsl:value-of select=""sender_total_amount/text()"" />
      </sender_total_amount>
      <recipients>
        <recipient_bank_code>
          <xsl:value-of select=""$var:v3"" />
        </recipient_bank_code>
        <recipient_bank_branch_code>
          <xsl:value-of select=""$var:v7"" />
        </recipient_bank_branch_code>
        <recipient_account_number>
          <xsl:value-of select=""recipients/recipient_account_number/text()"" />
        </recipient_account_number>
        <recipient_amount>
          <xsl:value-of select=""recipients/recipient_amount/text()"" />
        </recipient_amount>
      </recipients>
    </ns0:bulk_payment_out>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PayGuard.Schemas.bulk_payment_in";
        
        private const global::PayGuard.Schemas.bulk_payment_in _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PayGuard.Schemas.bulk_payment_out";
        
        private const global::PayGuard.Schemas.bulk_payment_out _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"PayGuard.Schemas.bulk_payment_in";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PayGuard.Schemas.bulk_payment_out";
                return _TrgSchemas;
            }
        }
    }
}
