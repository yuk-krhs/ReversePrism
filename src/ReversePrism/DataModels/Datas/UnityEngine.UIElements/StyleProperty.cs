using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_Line                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_Values                                 000185CA81B8 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer
    // 028 IsCustomProperty                         0001865976C0 ModelPrimitiveType bool bool bool Bool
    // 029 RequireVariableResolve                   0001865976C0 ModelPrimitiveType bool bool bool Bool
    public partial class StyleProperty
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_Line                                  { get; set; }
        public List<StyleValueHandle>?                  M_Values                                { get; set; }
        public bool                                     IsCustomProperty                        { get; set; }
        public bool                                     RequireVariableResolve                  { get; set; }

        public static StyleProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleProperty();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 027006841D20 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Line                                    = GetInt32(new IntPtr(p + 0x018)); // 027006841D40 0x18 M_Line                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Values                                  = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x020)); // 027006841D60 0x20 M_Values                    ( 000185CA81B8 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )
            value.IsCustomProperty                          = GetBool(new IntPtr(p + 0x028)); // 027006841D80 0x28 IsCustomProperty            ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )
            value.RequireVariableResolve                    = GetBool(new IntPtr(p + 0x029)); // 027006841DA0 0x29 RequireVariableResolve      ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
