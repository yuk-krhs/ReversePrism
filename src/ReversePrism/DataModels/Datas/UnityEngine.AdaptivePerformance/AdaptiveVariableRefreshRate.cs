using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 M_AdaptiveVRREnabled                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 M_VRR                                    0001866929B0 ModelClassType IVariableRefreshRate IVariableRefreshRate IVariableRefreshRate Pointer
    // 058 M_CurrentRefreshRateIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C M_DefaultRefreshRateIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AdaptiveVariableRefreshRate : DataModel
    {
        public bool                                     M_AdaptiveVRREnabled                    { get; set; }
        public IVariableRefreshRate?                    M_VRR                                   { get; set; }
        public int                                      M_CurrentRefreshRateIndex               { get; set; }
        public int                                      M_DefaultRefreshRateIndex               { get; set; }

        public static AdaptiveVariableRefreshRate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveVariableRefreshRate() { Pointer= p0 };

            value.M_AdaptiveVRREnabled                      = GetBool(new IntPtr(p + 0x048)); // 02466BFB3298 0x48 M_AdaptiveVRREnabled        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VRR                                     = GetObject<IVariableRefreshRate>(new IntPtr(p + 0x050), ReversePrism.DataModels.IVariableRefreshRate.FromPointer); // 02466BFB32B8 0x50 M_VRR                       ( 0001866929B0 ModelClassType IVariableRefreshRate IVariableRefreshRate IVariableRefreshRate Pointer )
            value.M_CurrentRefreshRateIndex                 = GetInt32(new IntPtr(p + 0x058)); // 02466BFB32D8 0x58 M_CurrentRefreshRateIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_DefaultRefreshRateIndex                 = GetInt32(new IntPtr(p + 0x05C)); // 02466BFB32F8 0x5C M_DefaultRefreshRateIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
