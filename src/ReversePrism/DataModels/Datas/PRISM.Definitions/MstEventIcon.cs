using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 Place                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ImageResourceId                          000186672F10 ModelPrimitiveType string string string String
    // 020 Text                                     000186672F10 ModelPrimitiveType string string string String
    // 028 DisplayCondition                         0001865F4260 ModelPrimitiveType int int int Int32
    // 02C Priority                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstEventIcon : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      Place                                   { get; set; }
        public string                                   ImageResourceId                         { get; set; }
        public string                                   Text                                    { get; set; }
        public int                                      DisplayCondition                        { get; set; }
        public int                                      Priority                                { get; set; }

        public static MstEventIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEventIcon() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4669580 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Place                                     = GetInt32(new IntPtr(p + 0x014)); // 0245A46695A0 0x14 Place                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ImageResourceId                           = GetString(new IntPtr(p + 0x018)); // 0245A46695C0 0x18 ImageResourceId             ( 000186672F10 ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x020)); // 0245A46695E0 0x20 Text                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.DisplayCondition                          = GetInt32(new IntPtr(p + 0x028)); // 0245A4669600 0x28 DisplayCondition            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x02C)); // 0245A4669620 0x2C Priority                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
