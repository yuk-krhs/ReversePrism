using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 Place                                    ModelPrimitiveType int int int Int32
    // 018 ImageResourceId                          ModelPrimitiveType string string string String
    // 020 Text                                     ModelPrimitiveType string string string String
    // 028 DisplayCondition                         ModelPrimitiveType int int int Int32
    // 02C Priority                                 ModelPrimitiveType int int int Int32
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Place                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Place                       ( ModelPrimitiveType int int int Int32 )
            value.ImageResourceId                           = GetString(new IntPtr(p + 0x018)); // 0x18 ImageResourceId             ( ModelPrimitiveType string string string String )
            value.Text                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Text                        ( ModelPrimitiveType string string string String )
            value.DisplayCondition                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 DisplayCondition            ( ModelPrimitiveType int int int Int32 )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Priority                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
