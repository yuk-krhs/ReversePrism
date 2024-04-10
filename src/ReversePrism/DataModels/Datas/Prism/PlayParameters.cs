using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pause                                    0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 014 Volume                                   000186666CB0 ModelPrimitiveType float float float Single
    // 018 StartTime                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C IsLoop                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 FadeInTime                               0001865F4260 ModelPrimitiveType int int int Int32
    // 024 FadeOutTime                              0001865F4260 ModelPrimitiveType int int int Int32
    // 028 <IsCancelOnOtherSEPlayed>k__BackingField Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 Default                                  PlayParameters IL2CPP_TYPE_CLASS
    public partial class PlayParameters : DataModel
    {
        public bool                                     Pause                                   { get; set; }
        public float                                    Volume                                  { get; set; }
        public int                                      StartTime                               { get; set; }
        public bool                                     IsLoop                                  { get; set; }
        public int                                      FadeInTime                              { get; set; }
        public int                                      FadeOutTime                             { get; set; }

        public static PlayParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayParameters() { Pointer= p0 };

            value.Pause                                     = GetBool(new IntPtr(p + 0x010)); // 0245A4AAA628 0x10 Pause                       ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Volume                                    = GetSingle(new IntPtr(p + 0x014)); // 0245A4AAA648 0x14 Volume                      ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.StartTime                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A4AAA668 0x18 StartTime                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x01C)); // 0245A4AAA688 0x1C IsLoop                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.FadeInTime                                = GetInt32(new IntPtr(p + 0x020)); // 0245A4AAA6A8 0x20 FadeInTime                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FadeOutTime                               = GetInt32(new IntPtr(p + 0x024)); // 0245A4AAA6C8 0x24 FadeOutTime                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
