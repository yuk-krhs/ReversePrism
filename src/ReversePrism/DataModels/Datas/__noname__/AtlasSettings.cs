using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Resolution                               ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 Format                                   ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 01C UseMips                                  ModelPrimitiveType bool bool bool Bool
    public partial class AtlasSettings : DataModel
    {
        public Vector2Int                               Resolution                              { get; set; }
        public GraphicsFormat                           Format                                  { get; set; }
        public bool                                     UseMips                                 { get; set; }

        public static AtlasSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasSettings() { Pointer= p0 };

            value.Resolution                                = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 Resolution                  ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.Format                                    = (GraphicsFormat)GetInt32(new IntPtr(p + 0x018)); // 0x18 Format                      ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.UseMips                                   = GetBool(new IntPtr(p + 0x01C)); // 0x1C UseMips                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
