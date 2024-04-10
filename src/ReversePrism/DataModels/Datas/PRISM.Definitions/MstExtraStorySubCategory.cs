using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstExtraStoryCategoryId                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 MstExtraStoryCategory                    0001866200A0 ModelClassType MstExtraStoryCategory MstExtraStoryCategory MstExtraStoryCategory Pointer
    public partial class MstExtraStorySubCategory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstExtraStoryCategoryId                 { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public MstExtraStoryCategory?                   MstExtraStoryCategory                   { get; set; }

        public static MstExtraStorySubCategory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstExtraStorySubCategory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46C4098 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExtraStoryCategoryId                   = GetInt32(new IntPtr(p + 0x014)); // 0245A46C40B8 0x14 MstExtraStoryCategoryId     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x018)); // 0245A46C40D8 0x18 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.MstExtraStoryCategory                     = GetObject<MstExtraStoryCategory>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstExtraStoryCategory.FromPointer); // 0245A46C40F8 0x20 MstExtraStoryCategory       ( 0001866200A0 ModelClassType MstExtraStoryCategory MstExtraStoryCategory MstExtraStoryCategory Pointer )

            return value;
        }
    }
}
