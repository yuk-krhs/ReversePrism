using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                ModelPrimitiveType int int int Int32
    // 018 IsDefault                                ModelPrimitiveType bool bool bool Bool
    public partial class MstChallengeTour : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public bool                                     IsDefault                               { get; set; }

        public static MstChallengeTour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChallengeTour() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.IsDefault                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 IsDefault                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
