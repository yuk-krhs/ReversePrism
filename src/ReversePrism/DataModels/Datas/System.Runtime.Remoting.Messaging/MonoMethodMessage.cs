using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   ModelClassType RuntimeMethodInfo RuntimeMethodInfo RuntimeMethodInfo Pointer
    // 018 args                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Names                                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Arg_types                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Ctx                                      ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 038 rval                                     <object> IL2CPP_TYPE_OBJECT
    // 040 Exc                                      ModelClassType Exception Exception Exception Pointer
    // 048 AsyncResult                              ModelClassType AsyncResult AsyncResult AsyncResult Pointer
    // 050 Call_type                                ModelEnumType CallType CallType CallType Int32
    // 058 Uri                                      ModelPrimitiveType string string string String
    // 060 Properties                               ModelClassType MCMDictionary MCMDictionary MCMDictionary Pointer
    // 068 Identity                                 ModelClassType Identity Identity Identity Pointer
    // 070 MethodSignature                          ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class MonoMethodMessage : DataModel
    {
        public RuntimeMethodInfo?                       Method                                  { get; set; }
        public List<string>?                            Names                                   { get; set; }
        public List<sbyte>?                             Arg_types                               { get; set; }
        public LogicalCallContext?                      Ctx                                     { get; set; }
        public Exception?                               Exc                                     { get; set; }
        public AsyncResult?                             AsyncResult                             { get; set; }
        public CallType                                 Call_type                               { get; set; }
        public string                                   Uri                                     { get; set; }
        public MCMDictionary?                           Properties                              { get; set; }
        public Identity?                                Identity                                { get; set; }
        public List<Type>?                              MethodSignature                         { get; set; }

        public static MonoMethodMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoMethodMessage() { Pointer= p0 };

            value.Method                                    = GetObject<RuntimeMethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.RuntimeMethodInfo.FromPointer); // 0x10 Method                      ( ModelClassType RuntimeMethodInfo RuntimeMethodInfo RuntimeMethodInfo Pointer )
            value.Names                                     = GetStringList(new IntPtr(p + 0x020)); // 0x20 Names                       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Arg_types                                 = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Arg_types                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ctx                                       = GetObject<LogicalCallContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 0x30 Ctx                         ( ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.Exc                                       = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 0x40 Exc                         ( ModelClassType Exception Exception Exception Pointer )
            value.AsyncResult                               = GetObject<AsyncResult>(new IntPtr(p + 0x048), ReversePrism.DataModels.AsyncResult.FromPointer); // 0x48 AsyncResult                 ( ModelClassType AsyncResult AsyncResult AsyncResult Pointer )
            value.Call_type                                 = (CallType)GetInt32(new IntPtr(p + 0x050)); // 0x50 Call_type                   ( ModelEnumType CallType CallType CallType Int32 )
            value.Uri                                       = GetString(new IntPtr(p + 0x058)); // 0x58 Uri                         ( ModelPrimitiveType string string string String )
            value.Properties                                = GetObject<MCMDictionary>(new IntPtr(p + 0x060), ReversePrism.DataModels.MCMDictionary.FromPointer); // 0x60 Properties                  ( ModelClassType MCMDictionary MCMDictionary MCMDictionary Pointer )
            value.Identity                                  = GetObject<Identity>(new IntPtr(p + 0x068), ReversePrism.DataModels.Identity.FromPointer); // 0x68 Identity                    ( ModelClassType Identity Identity Identity Pointer )
            value.MethodSignature                           = GetObjectList<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0x70 MethodSignature             ( ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
