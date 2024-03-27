using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_stackOverflowType                      Type IL2CPP_TYPE_CLASS
    // 008 s_outOfMemoryType                        Type IL2CPP_TYPE_CLASS
    // 010 S_threadAbortType                        000186693E20 ModelClassType Type Type Type Pointer
    // 018 S_nullReferenceType                      000186693E20 ModelClassType Type Type Type Pointer
    // 020 S_accessViolationType                    000186693E20 ModelClassType Type Type Type Pointer
    // 028 S_securityType                           000186693E20 ModelClassType Type Type Type Pointer
    // 030 StrEmpty                                 000186673B80 ModelPrimitiveType string string string String
    // 038 AzureSqlServerEndpoints                  000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 PtrZero                                  <int> IL2CPP_TYPE_I
    // 048 PtrSize                                  0001865F4E00 ModelPrimitiveType int int int Int32
    public partial class ADP
    {
        public Type?                                    S_threadAbortType                       { get; set; }
        public Type?                                    S_nullReferenceType                     { get; set; }
        public Type?                                    S_accessViolationType                   { get; set; }
        public Type?                                    S_securityType                          { get; set; }
        public string                                   StrEmpty                                { get; set; }
        public List<string>?                            AzureSqlServerEndpoints                 { get; set; }
        public int                                      PtrSize                                 { get; set; }

        public static ADP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADP();

            value.S_threadAbortType                         = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D89A60C8 0x10 S_threadAbortType           ( 000186693E20 ModelClassType Type Type Type Pointer )
            value.S_nullReferenceType                       = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D89A60E8 0x18 S_nullReferenceType         ( 000186693E20 ModelClassType Type Type Type Pointer )
            value.S_accessViolationType                     = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D89A6108 0x20 S_accessViolationType       ( 000186693E20 ModelClassType Type Type Type Pointer )
            value.S_securityType                            = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270D89A6128 0x28 S_securityType              ( 000186693E20 ModelClassType Type Type Type Pointer )
            value.StrEmpty                                  = GetString(new IntPtr(p + 0x030)); // 0270D89A6148 0x30 StrEmpty                    ( 000186673B80 ModelPrimitiveType string string string String )
            value.AzureSqlServerEndpoints                   = GetStringList(new IntPtr(p + 0x038)); // 0270D89A6168 0x38 AzureSqlServerEndpoints     ( 000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.PtrSize                                   = GetInt32(new IntPtr(p + 0x048)); // 0270D89A61A8 0x48 PtrSize                     ( 0001865F4E00 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
