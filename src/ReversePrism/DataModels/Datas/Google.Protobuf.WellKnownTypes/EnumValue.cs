using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EnumValue> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Number                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 028 Options                                  000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    public partial class EnumValue : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Number                                  { get; set; }
        public List<Option>?                            Options                                 { get; set; }

        public static EnumValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumValue() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466A52A188 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Number                                    = GetInt32(new IntPtr(p + 0x020)); // 02466A52A1C8 0x20 Number                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x028), ReversePrism.DataModels.Option.FromPointer); // 02466A52A228 0x28 Options                     ( 000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )

            return value;
        }
    }
}
