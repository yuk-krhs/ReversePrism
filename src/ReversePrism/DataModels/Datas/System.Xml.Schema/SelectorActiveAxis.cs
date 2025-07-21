using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Cs                                       ModelClassType ConstraintStruct ConstraintStruct ConstraintStruct Pointer
    // 030 KSs                                      ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 KSpointer                                ModelPrimitiveType int int int Int32
    public partial class SelectorActiveAxis : DataModel
    {
        public ConstraintStruct?                        Cs                                      { get; set; }
        public ArrayList?                               KSs                                     { get; set; }
        public int                                      KSpointer                               { get; set; }

        public static SelectorActiveAxis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorActiveAxis() { Pointer= p0 };

            value.Cs                                        = GetObject<ConstraintStruct>(new IntPtr(p + 0x028), ReversePrism.DataModels.ConstraintStruct.FromPointer); // 0x28 Cs                          ( ModelClassType ConstraintStruct ConstraintStruct ConstraintStruct Pointer )
            value.KSs                                       = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0x30 KSs                         ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.KSpointer                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 KSpointer                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
