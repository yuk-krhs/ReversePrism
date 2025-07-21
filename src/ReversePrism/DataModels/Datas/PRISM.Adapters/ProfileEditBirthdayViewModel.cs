using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Month                                    ModelPrimitiveType int int int Int32
    // 014 Day                                      ModelPrimitiveType int int int Int32
    // 018 IsPublic                                 ModelPrimitiveType bool bool bool Bool
    public partial class ProfileEditBirthdayViewModel : DataModel
    {
        public int                                      Month                                   { get; set; }
        public int                                      Day                                     { get; set; }
        public bool                                     IsPublic                                { get; set; }

        public static ProfileEditBirthdayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditBirthdayViewModel() { Pointer= p0 };

            value.Month                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Month                       ( ModelPrimitiveType int int int Int32 )
            value.Day                                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 Day                         ( ModelPrimitiveType int int int Int32 )
            value.IsPublic                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsPublic                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
