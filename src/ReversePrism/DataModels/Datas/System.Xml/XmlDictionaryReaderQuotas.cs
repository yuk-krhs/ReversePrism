using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReadOnly                                 ModelPrimitiveType bool bool bool Bool
    // 014 MaxStringContentLength                   ModelPrimitiveType int int int Int32
    // 018 MaxArrayLength                           ModelPrimitiveType int int int Int32
    // 01C MaxDepth                                 ModelPrimitiveType int int int Int32
    // 020 MaxNameTableCharCount                    ModelPrimitiveType int int int Int32
    // 024 MaxBytesPerRead                          ModelPrimitiveType int int int Int32
    // 028 ModifiedQuotas                           ModelEnumType XmlDictionaryReaderQuotaTypes XmlDictionaryReaderQuotaTypes XmlDictionaryReaderQuotaTypes Int32
    // 000 DefaultMaxDepth                          int IL2CPP_TYPE_I4
    // 000 DefaultMaxStringContentLength            int IL2CPP_TYPE_I4
    // 000 DefaultMaxArrayLength                    int IL2CPP_TYPE_I4
    // 000 DefaultMaxBytesPerRead                   int IL2CPP_TYPE_I4
    // 000 DefaultMaxNameTableCharCount             int IL2CPP_TYPE_I4
    // 000 defaultQuota                             XmlDictionaryReaderQuotas IL2CPP_TYPE_CLASS
    // 008 maxQuota                                 XmlDictionaryReaderQuotas IL2CPP_TYPE_CLASS
    public partial class XmlDictionaryReaderQuotas : DataModel
    {
        public bool                                     ReadOnly                                { get; set; }
        public int                                      MaxStringContentLength                  { get; set; }
        public int                                      MaxArrayLength                          { get; set; }
        public int                                      MaxDepth                                { get; set; }
        public int                                      MaxNameTableCharCount                   { get; set; }
        public int                                      MaxBytesPerRead                         { get; set; }
        public XmlDictionaryReaderQuotaTypes            ModifiedQuotas                          { get; set; }

        public static XmlDictionaryReaderQuotas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDictionaryReaderQuotas() { Pointer= p0 };

            value.ReadOnly                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 ReadOnly                    ( ModelPrimitiveType bool bool bool Bool )
            value.MaxStringContentLength                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxStringContentLength      ( ModelPrimitiveType int int int Int32 )
            value.MaxArrayLength                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxArrayLength              ( ModelPrimitiveType int int int Int32 )
            value.MaxDepth                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxDepth                    ( ModelPrimitiveType int int int Int32 )
            value.MaxNameTableCharCount                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxNameTableCharCount       ( ModelPrimitiveType int int int Int32 )
            value.MaxBytesPerRead                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 MaxBytesPerRead             ( ModelPrimitiveType int int int Int32 )
            value.ModifiedQuotas                            = (XmlDictionaryReaderQuotaTypes)GetInt32(new IntPtr(p + 0x028)); // 0x28 ModifiedQuotas              ( ModelEnumType XmlDictionaryReaderQuotaTypes XmlDictionaryReaderQuotaTypes XmlDictionaryReaderQuotaTypes Int32 )

            return value;
        }
    }
}
