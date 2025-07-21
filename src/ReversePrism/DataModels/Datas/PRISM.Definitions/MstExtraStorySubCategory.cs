using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstExtraStoryCategoryId                  ModelPrimitiveType int int int Int32
    // 018 SortId                                   ModelPrimitiveType int int int Int32
    // 01C JumpType                                 ModelPrimitiveType int int int Int32
    // 020 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 MstExtraStoryCategory                    ModelClassType MstExtraStoryCategory MstExtraStoryCategory MstExtraStoryCategory Pointer
    public partial class MstExtraStorySubCategory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstExtraStoryCategoryId                 { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      JumpType                                { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public MstExtraStoryCategory?                   MstExtraStoryCategory                   { get; set; }

        public static MstExtraStorySubCategory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstExtraStorySubCategory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstExtraStoryCategoryId                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstExtraStoryCategoryId     ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.JumpType                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C JumpType                    ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x020)); // 0x20 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.MstExtraStoryCategory                     = GetObject<MstExtraStoryCategory>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstExtraStoryCategory.FromPointer); // 0x28 MstExtraStoryCategory       ( ModelClassType MstExtraStoryCategory MstExtraStoryCategory MstExtraStoryCategory Pointer )

            return value;
        }
    }
}
