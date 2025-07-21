using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnSelected                               ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 FavoriteId                               ModelPrimitiveType int int int Int32
    public partial class FavoriteIconViewModel : DataModel
    {
        public BoolReactiveProperty?                    OnSelected                              { get; set; }
        public int                                      FavoriteId                              { get; set; }

        public static FavoriteIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FavoriteIconViewModel() { Pointer= p0 };

            value.OnSelected                                = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 OnSelected                  ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.FavoriteId                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 FavoriteId                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
