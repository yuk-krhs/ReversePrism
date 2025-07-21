using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsLocked                                 ModelPrimitiveType bool bool bool Bool
    public partial class MusicRankingCategoryData : DataModel
    {
        public bool                                     IsLocked                                { get; set; }

        public static MusicRankingCategoryData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingCategoryData() { Pointer= p0 };

            value.IsLocked                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 IsLocked                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
