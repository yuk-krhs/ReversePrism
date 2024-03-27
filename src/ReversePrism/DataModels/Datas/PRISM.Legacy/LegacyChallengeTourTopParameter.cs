using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnitStageDesignation                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 SelectUnitIndex                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SelectStageIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsStageDetailFirstView                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 ViewStacks                               000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LegacyChallengeTourTopParameter
    {
        public bool                                     IsUnitStageDesignation                  { get; set; }
        public int                                      SelectUnitIndex                         { get; set; }
        public int                                      SelectStageIndex                        { get; set; }
        public bool                                     IsStageDetailFirstView                  { get; set; }
        public List<ViewValue>?                         ViewStacks                              { get; set; }

        public static LegacyChallengeTourTopParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyChallengeTourTopParameter();

            value.IsUnitStageDesignation                    = GetBool(new IntPtr(p + 0x010)); // 0270D5E3D5D0 0x10 IsUnitStageDesignation      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectUnitIndex                           = GetInt32(new IntPtr(p + 0x014)); // 0270D5E3D5F0 0x14 SelectUnitIndex             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectStageIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0270D5E3D610 0x18 SelectStageIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsStageDetailFirstView                    = GetBool(new IntPtr(p + 0x01C)); // 0270D5E3D630 0x1C IsStageDetailFirstView      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.ViewValue.FromPointer); // 0270D5E3D650 0x20 ViewStacks                  ( 000185CC58D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
