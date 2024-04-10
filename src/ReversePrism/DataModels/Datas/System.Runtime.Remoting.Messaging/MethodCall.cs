using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uri                                      000186671910 ModelPrimitiveType string string string String
    // 018 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 020 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 028 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 030 MethodSignature                          000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 038 MethodBase                               000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer
    // 040 CallContext                              0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 048 TargetIdentity                           0001866A3B00 ModelClassType Identity Identity Identity Pointer
    // 050 GenericArguments                         000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 058 ExternalProperties                       000186750460 ModelClassType IDictionary IDictionary IDictionary Pointer
    // 060 InternalProperties                       000186750460 ModelClassType IDictionary IDictionary IDictionary Pointer
    public partial class MethodCall : DataModel
    {
        public string                                   Uri                                     { get; set; }
        public string                                   TypeName                                { get; set; }
        public string                                   MethodName                              { get; set; }
        public List<Type>?                              MethodSignature                         { get; set; }
        public MethodBase?                              MethodBase                              { get; set; }
        public LogicalCallContext?                      CallContext                             { get; set; }
        public Identity?                                TargetIdentity                          { get; set; }
        public List<Type>?                              GenericArguments                        { get; set; }
        public IDictionary?                             ExternalProperties                      { get; set; }
        public IDictionary?                             InternalProperties                      { get; set; }

        public static MethodCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodCall() { Pointer= p0 };

            value.Uri                                       = GetString(new IntPtr(p + 0x010)); // 024666C34498 0x10 Uri                         ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 024666C344B8 0x18 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x020)); // 024666C344D8 0x20 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodSignature                           = GetObjectList<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 024666C34518 0x30 MethodSignature             ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.MethodBase                                = GetObject<MethodBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodBase.FromPointer); // 024666C34538 0x38 MethodBase                  ( 000186612B80 ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.CallContext                               = GetObject<LogicalCallContext>(new IntPtr(p + 0x040), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 024666C34558 0x40 CallContext                 ( 0001865B5810 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.TargetIdentity                            = GetObject<Identity>(new IntPtr(p + 0x048), ReversePrism.DataModels.Identity.FromPointer); // 024666C34578 0x48 TargetIdentity              ( 0001866A3B00 ModelClassType Identity Identity Identity Pointer )
            value.GenericArguments                          = GetObjectList<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 024666C34598 0x50 GenericArguments            ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.ExternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDictionary.FromPointer); // 024666C345B8 0x58 ExternalProperties          ( 000186750460 ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.InternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDictionary.FromPointer); // 024666C345D8 0x60 InternalProperties          ( 000186750460 ModelClassType IDictionary IDictionary IDictionary Pointer )

            return value;
        }
    }
}
