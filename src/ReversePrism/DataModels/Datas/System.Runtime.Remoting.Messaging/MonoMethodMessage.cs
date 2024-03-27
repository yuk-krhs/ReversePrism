using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   00018669C610 ModelClassType RuntimeMethodInfo RuntimeMethodInfo RuntimeMethodInfo Pointer
    // 018 args                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Names                                    000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Arg_types                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Ctx                                      0001865B5A60 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer
    // 038 rval                                     <object> IL2CPP_TYPE_OBJECT
    // 040 Exc                                      0001865CACE0 ModelClassType Exception Exception Exception Pointer
    // 048 AsyncResult                              000186702100 ModelClassType AsyncResult AsyncResult AsyncResult Pointer
    // 050 Call_type                                0001865312F0 ModelEnumType CallType CallType CallType Int32
    // 058 Uri                                      000186671910 ModelPrimitiveType string string string String
    // 060 Properties                               0001865C3AB0 ModelClassType MCMDictionary MCMDictionary MCMDictionary Pointer
    // 068 Identity                                 0001866A3B00 ModelClassType Identity Identity Identity Pointer
    // 070 MethodSignature                          000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class MonoMethodMessage
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
            var value   = new MonoMethodMessage();

            value.Method                                    = GetObject<RuntimeMethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.RuntimeMethodInfo.FromPointer); // 0270D6BBB4F0 0x10 Method                      ( 00018669C610 ModelClassType RuntimeMethodInfo RuntimeMethodInfo RuntimeMethodInfo Pointer )
            value.Names                                     = GetStringList(new IntPtr(p + 0x020)); // 0270D6BBB530 0x20 Names                       ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Arg_types                                 = GetSByteList(new IntPtr(p + 0x028)); // 0270D6BBB550 0x28 Arg_types                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Ctx                                       = GetObject<LogicalCallContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.LogicalCallContext.FromPointer); // 0270D6BBB570 0x30 Ctx                         ( 0001865B5A60 ModelClassType LogicalCallContext LogicalCallContext LogicalCallContext Pointer )
            value.Exc                                       = GetObject<Exception>(new IntPtr(p + 0x040), ReversePrism.DataModels.Exception.FromPointer); // 0270D6BBB5B0 0x40 Exc                         ( 0001865CACE0 ModelClassType Exception Exception Exception Pointer )
            value.AsyncResult                               = GetObject<AsyncResult>(new IntPtr(p + 0x048), ReversePrism.DataModels.AsyncResult.FromPointer); // 0270D6BBB5D0 0x48 AsyncResult                 ( 000186702100 ModelClassType AsyncResult AsyncResult AsyncResult Pointer )
            value.Call_type                                 = (CallType)GetInt32(new IntPtr(p + 0x050)); // 0270D6BBB5F0 0x50 Call_type                   ( 0001865312F0 ModelEnumType CallType CallType CallType Int32 )
            value.Uri                                       = GetString(new IntPtr(p + 0x058)); // 0270D6BBB610 0x58 Uri                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Properties                                = GetObject<MCMDictionary>(new IntPtr(p + 0x060), ReversePrism.DataModels.MCMDictionary.FromPointer); // 0270D6BBB630 0x60 Properties                  ( 0001865C3AB0 ModelClassType MCMDictionary MCMDictionary MCMDictionary Pointer )
            value.Identity                                  = GetObject<Identity>(new IntPtr(p + 0x068), ReversePrism.DataModels.Identity.FromPointer); // 0270D6BBB650 0x68 Identity                    ( 0001866A3B00 ModelClassType Identity Identity Identity Pointer )
            value.MethodSignature                           = GetObjectList<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0270D6BBB670 0x70 MethodSignature             ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
