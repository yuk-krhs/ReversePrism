using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Colored                                  000186768DE0 ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 038 Intensity                                0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 Size                                     0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 LumContrib                               0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class Grain : DataModel
    {
        public BoolParameter?                           Colored                                 { get; set; }
        public FloatParameter?                          Intensity                               { get; set; }
        public FloatParameter?                          Size                                    { get; set; }
        public FloatParameter?                          LumContrib                              { get; set; }

        public static Grain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Grain() { Pointer= p0 };

            value.Colored                                   = GetObject<BoolParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.BoolParameter.FromPointer); // 0245A6550FB8 0x30 Colored                     ( 000186768DE0 ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.Intensity                                 = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6550FD8 0x38 Intensity                   ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Size                                      = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6550FF8 0x40 Size                        ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.LumContrib                                = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0245A6551018 0x48 LumContrib                  ( 0001865A6E60 ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
