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
    public partial class StyleProperty : DataModel
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
            var value   = new StyleProperty() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0245A6803B00 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_Line                                    = GetInt32(new IntPtr(p + 0x018)); // 0245A6803B20 0x18 M_Line                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Values                                  = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x020)); // 0245A6803B40 0x20 M_Values                    ( 000185CA81B8 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )
            value.IsCustomProperty                          = GetBool(new IntPtr(p + 0x028)); // 0245A6803B60 0x28 IsCustomProperty            ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )
            value.RequireVariableResolve                    = GetBool(new IntPtr(p + 0x029)); // 0245A6803B80 0x29 RequireVariableResolve      ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
