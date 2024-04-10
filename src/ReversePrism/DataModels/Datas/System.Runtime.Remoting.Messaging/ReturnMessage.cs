using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _outArgs                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 018 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 020 CallCtx                                  0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 028 _returnValue                             <object> IL2CPP_TYPE_OBJECT
    // 030 Uri                                      000186671910 ModelPrimitiveType string string string String
    // 038 Exception                                0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 040 MethodBase                               000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer
    // 048 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 050 MethodSignature                          000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 058 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 060 Properties                               000186612700 ModelClassType MethodReturnDictionary MethodReturnDictionary MethodReturnDictionary Pointer
    // 068 TargetIdentity                           0001866A3B00 ModelClassType Identity Identity Identity Pointer
    // 070 InArgInfo                                0001866D3890 ModelClassType ArgInfo ArgInfo ArgInfo Pointer
    public partial class ReturnMessage : DataModel
    {
        public LogicalCallContext?                      CallCtx                                 { get; set; }
        public string                                   Uri                                     { get; set; }
        public Exception?                               Exception                               { get; set; }
        public MethodBase?                              MethodBase                              { get; set; }
        public string                                   MethodName                              { get; set; }
        public List<Type>?                              MethodSignature                         { get; set; }
        public string                                   TypeName                                { get; set; }
        public MethodReturnDictionary?                  Properties                              { get; set; }
        public Identity?                                TargetIdentity                          { get; set; }
        public ArgInfo?                                 InArgInfo                               { get; set; }

        public static ReturnMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReturnMessage() { Pointer= p0 };

            value.CallCtx                                   = GetObject<LogicalCallContext>(new IntPtr(p + 0x020), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 024666C5CCA8 0x20 CallCtx                     ( 0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.Uri                                       = GetString(new IntPtr(p + 0x030)); // 024666C5CCE8 0x30 Uri                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x038), ReversePrism.DataModels.Exception.FromPointer); // 024666C5CD08 0x38 Exception                   ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.MethodBase                                = GetObject<MethodBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodBase.FromPointer); // 024666C5CD28 0x40 MethodBase                  ( 000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.MethodName                                = GetString(new IntPtr(p + 0x048)); // 024666C5CD48 0x48 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodSignature                           = GetObjectList<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 024666C5CD68 0x50 MethodSignature             ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.TypeName                                  = GetString(new IntPtr(p + 0x058)); // 024666C5CD88 0x58 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Properties                                = GetObject<MethodReturnDictionary>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodReturnDictionary.FromPointer); // 024666C5CDA8 0x60 Properties                  ( 000186612700 ModelClassType MethodReturnDictionary MethodReturnDictionary MethodReturnDictionary Pointer )
            value.TargetIdentity                            = GetObject<Identity>(new IntPtr(p + 0x068), ReversePrism.DataModels.Identity.FromPointer); // 024666C5CDC8 0x68 TargetIdentity              ( 0001866A3B00 ModelClassType Identity Identity Identity Pointer )
            value.InArgInfo                                 = GetObject<ArgInfo>(new IntPtr(p + 0x070), ReversePrism.DataModels.ArgInfo.FromPointer); // 024666C5CDE8 0x70 InArgInfo                   ( 0001866D3890 ModelClassType ArgInfo ArgInfo ArgInfo Pointer )

            return value;
        }
    }
}
