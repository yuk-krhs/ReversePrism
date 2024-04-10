using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SpecialCharacters                        char[] IL2CPP_TYPE_SZARRAY
    // 010 Type                                     00018674FF70 ModelEnumType JsonContainerType JsonContainerType JsonContainerType Int32
    // 014 Position                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 PropertyName                             000186671BA0 ModelPrimitiveType string string string String
    // 020 HasIndex                                 000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class JsonPosition : DataModel
    {
        public JsonContainerType                        Type                                    { get; set; }
        public int                                      Position                                { get; set; }
        public string                                   PropertyName                            { get; set; }
        public bool                                     HasIndex                                { get; set; }

        public static JsonPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonPosition() { Pointer= p0 };

            value.Type                                      = (JsonContainerType)GetInt32(new IntPtr(p + 0x010)); // 0245A5FAA688 0x10 Type                        ( 00018674FF70 ModelEnumType JsonContainerType JsonContainerType JsonContainerType Int32 )
            value.Position                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A5FAA6A8 0x14 Position                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.PropertyName                              = GetString(new IntPtr(p + 0x018)); // 0245A5FAA6C8 0x18 PropertyName                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.HasIndex                                  = GetBool(new IntPtr(p + 0x020)); // 0245A5FAA6E8 0x20 HasIndex                    ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
