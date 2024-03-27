using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Color> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RedFieldNumber                           int IL2CPP_TYPE_I4
    // 018 Red                                      0001866656B0 ModelPrimitiveType float float float Single
    // 000 GreenFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Green                                    0001866656B0 ModelPrimitiveType float float float Single
    // 000 BlueFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Blue                                     0001866656B0 ModelPrimitiveType float float float Single
    // 000 AlphaFieldNumber                         int IL2CPP_TYPE_I4
    // 008 _single_alpha_codec                      FieldCodec`1<Nullable`1<float>> IL2CPP_TYPE_GENERICINST
    // 024 alpha_                                   Nullable`1<float> IL2CPP_TYPE_GENERICINST
    public partial class Color
    {
        public float                                    Red                                     { get; set; }
        public float                                    Green                                   { get; set; }
        public float                                    Blue                                    { get; set; }

        public static Color? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color();

            value.Red                                       = GetSingle(new IntPtr(p + 0x018)); // 0270DA65D628 0x18 Red                         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Green                                     = GetSingle(new IntPtr(p + 0x01C)); // 0270DA65D668 0x1C Green                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Blue                                      = GetSingle(new IntPtr(p + 0x020)); // 0270DA65D6A8 0x20 Blue                        ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
