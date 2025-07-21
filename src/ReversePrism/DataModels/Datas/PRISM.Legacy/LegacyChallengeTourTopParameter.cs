using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsUnitStageDesignation                   ModelPrimitiveType bool bool bool Bool
    // 014 SelectUnitIndex                          ModelPrimitiveType int int int Int32
    // 018 SelectStageIndex                         ModelPrimitiveType int int int Int32
    // 01C IsStageDetailFirstView                   ModelPrimitiveType bool bool bool Bool
    // 020 ViewStacks                               ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LegacyChallengeTourTopParameter : DataModel
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
            var value   = new LegacyChallengeTourTopParameter() { Pointer= p0 };

            value.IsUnitStageDesignation                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsUnitStageDesignation      ( ModelPrimitiveType bool bool bool Bool )
            value.SelectUnitIndex                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 SelectUnitIndex             ( ModelPrimitiveType int int int Int32 )
            value.SelectStageIndex                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 SelectStageIndex            ( ModelPrimitiveType int int int Int32 )
            value.IsStageDetailFirstView                    = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsStageDetailFirstView      ( ModelPrimitiveType bool bool bool Bool )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.ViewValue.FromPointer); // 0x20 ViewStacks                  ( ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
