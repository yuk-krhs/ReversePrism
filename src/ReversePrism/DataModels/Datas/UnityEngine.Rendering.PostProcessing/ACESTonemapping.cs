using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ParamA                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 038 ParamB                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 ParamC                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 ParamD                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 050 ParamE                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class ACESTonemapping : DataModel
    {
        public FloatParameter?                          ParamA                                  { get; set; }
        public FloatParameter?                          ParamB                                  { get; set; }
        public FloatParameter?                          ParamC                                  { get; set; }
        public FloatParameter?                          ParamD                                  { get; set; }
        public FloatParameter?                          ParamE                                  { get; set; }

        public static ACESTonemapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ACESTonemapping() { Pointer= p0 };

            value.ParamA                                    = GetObject<FloatParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x30 ParamA                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ParamB                                    = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 ParamB                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ParamC                                    = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 ParamC                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ParamD                                    = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 ParamD                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ParamE                                    = GetObject<FloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x50 ParamE                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
