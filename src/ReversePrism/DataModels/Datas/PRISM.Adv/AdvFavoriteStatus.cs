using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InitFavoriteStatus                       ModelPrimitiveType bool bool bool Bool
    // 011 IsFavorite                               ModelPrimitiveType bool bool bool Bool
    // 018 StoryId                                  ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer
    public partial class AdvFavoriteStatus : DataModel
    {
        public bool                                     InitFavoriteStatus                      { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public IStoryIDStatus?                          StoryId                                 { get; set; }

        public static AdvFavoriteStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvFavoriteStatus() { Pointer= p0 };

            value.InitFavoriteStatus                        = GetBool(new IntPtr(p + 0x010)); // 0x10 InitFavoriteStatus          ( ModelPrimitiveType bool bool bool Bool )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x011)); // 0x11 IsFavorite                  ( ModelPrimitiveType bool bool bool Bool )
            value.StoryId                                   = GetObject<IStoryIDStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoryIDStatus.FromPointer); // 0x18 StoryId                     ( ModelClassType IStoryIDStatus IStoryIDStatus IStoryIDStatus Pointer )

            return value;
        }
    }
}
