using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               ModelPrimitiveType string string string String
    // 018 Uri                                      ModelPrimitiveType string string string String
    // 020 TypeName                                 ModelPrimitiveType string string string String
    // 028 MethodBase                               ModelClassType MethodBase MethodBase MethodBase Pointer
    // 030 _returnValue                             <object> IL2CPP_TYPE_OBJECT
    // 038 Exception                                ModelClassType Exception Exception Exception Pointer
    // 040 MethodSignature                          ModelClassListType Type[] Type[] List<Type> Pointer
    // 048 InArgInfo                                ModelClassType ArgInfo ArgInfo ArgInfo Pointer
    // 050 _args                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 058 _outArgs                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 060 CallMsg                                  ModelClassType IMethodCallMessage IMethodCallMessage IMethodCallMessage Pointer
    // 068 CallContext                              ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 070 TargetIdentity                           ModelClassType Identity Identity Identity Pointer
    // 078 ExternalProperties                       ModelClassType IDictionary IDictionary IDictionary Pointer
    // 080 InternalProperties                       ModelClassType IDictionary IDictionary IDictionary Pointer
    public partial class MethodResponse : DataModel
    {
        public string                                   MethodName                              { get; set; }
        public string                                   Uri                                     { get; set; }
        public string                                   TypeName                                { get; set; }
        public MethodBase?                              MethodBase                              { get; set; }
        public Exception?                               Exception                               { get; set; }
        public List<Type>?                              MethodSignature                         { get; set; }
        public ArgInfo?                                 InArgInfo                               { get; set; }
        public IMethodCallMessage?                      CallMsg                                 { get; set; }
        public LogicalCallContext?                      CallContext                             { get; set; }
        public Identity?                                TargetIdentity                          { get; set; }
        public IDictionary?                             ExternalProperties                      { get; set; }
        public IDictionary?                             InternalProperties                      { get; set; }

        public static MethodResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodResponse() { Pointer= p0 };

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 0x10 MethodName                  ( ModelPrimitiveType string string string String )
            value.Uri                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Uri                         ( ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 TypeName                    ( ModelPrimitiveType string string string String )
            value.MethodBase                                = GetObject<MethodBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodBase.FromPointer); // 0x28 MethodBase                  ( ModelClassType MethodBase MethodBase MethodBase Pointer )
            value.Exception                                 = GetObject<Exception>(new IntPtr(p + 0x038), ReversePrism.DataModels.Exception.FromPointer); // 0x38 Exception                   ( ModelClassType Exception Exception Exception Pointer )
            value.MethodSignature                           = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 MethodSignature             ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.InArgInfo                                 = GetObject<ArgInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.ArgInfo.FromPointer); // 0x48 InArgInfo                   ( ModelClassType ArgInfo ArgInfo ArgInfo Pointer )
            value.CallMsg                                   = GetObject<IMethodCallMessage>(new IntPtr(p + 0x060), ReversePrism.DataModels.IMethodCallMessage.FromPointer); // 0x60 CallMsg                     ( ModelClassType IMethodCallMessage IMethodCallMessage IMethodCallMessage Pointer )
            value.CallContext                               = GetObject<LogicalCallContext>(new IntPtr(p + 0x068), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 0x68 CallContext                 ( ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.TargetIdentity                            = GetObject<Identity>(new IntPtr(p + 0x070), ReversePrism.DataModels.Identity.FromPointer); // 0x70 TargetIdentity              ( ModelClassType Identity Identity Identity Pointer )
            value.ExternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x078), ReversePrism.DataModels.IDictionary.FromPointer); // 0x78 ExternalProperties          ( ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.InternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x080), ReversePrism.DataModels.IDictionary.FromPointer); // 0x80 InternalProperties          ( ModelClassType IDictionary IDictionary IDictionary Pointer )

            return value;
        }
    }
}
