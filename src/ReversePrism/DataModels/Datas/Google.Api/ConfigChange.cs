using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ConfigChange> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ElementFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Element                                  000186671910 ModelPrimitiveType string string string String
    // 000 OldValueFieldNumber                      int IL2CPP_TYPE_I4
    // 020 OldValue                                 000186671910 ModelPrimitiveType string string string String
    // 000 NewValueFieldNumber                      int IL2CPP_TYPE_I4
    // 028 NewValue                                 000186671910 ModelPrimitiveType string string string String
    // 000 ChangeTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ChangeType                               00018658E830 ModelEnumType ChangeType ChangeType ChangeType Int32
    // 000 AdvicesFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_advices_codec                  FieldCodec`1<Advice> IL2CPP_TYPE_GENERICINST
    // 038 Advices                                  000185CCDAC8 ModelClassListType RepeatedField`1<Advice> RepeatedField`1<Advice> List<Advice> Pointer
    public partial class ConfigChange : DataModel
    {
        public string                                   Element                                 { get; set; }
        public string                                   OldValue                                { get; set; }
        public string                                   NewValue                                { get; set; }
        public ChangeType                               ChangeType                              { get; set; }
        public List<Advice>?                            Advices                                 { get; set; }

        public static ConfigChange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfigChange() { Pointer= p0 };

            value.Element                                   = GetString(new IntPtr(p + 0x018)); // 02466A7D7F80 0x18 Element                     ( 000186671910 ModelPrimitiveType string string string String )
            value.OldValue                                  = GetString(new IntPtr(p + 0x020)); // 02466A7D7FC0 0x20 OldValue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.NewValue                                  = GetString(new IntPtr(p + 0x028)); // 02466A7D8000 0x28 NewValue                    ( 000186671910 ModelPrimitiveType string string string String )
            value.ChangeType                                = (ChangeType)GetInt32(new IntPtr(p + 0x030)); // 02466A7D8040 0x30 ChangeType                  ( 00018658E830 ModelEnumType ChangeType ChangeType ChangeType Int32 )
            value.Advices                                   = GetObjectList<Advice>(new IntPtr(p + 0x038), ReversePrism.DataModels.Advice.FromPointer); // 02466A7D80A0 0x38 Advices                     ( 000185CCDAC8 ModelClassListType RepeatedField`1<Advice> RepeatedField`1<Advice> List<Advice> Pointer )

            return value;
        }
    }
}
