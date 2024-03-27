using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsError                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Result                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 _isPopupReady                            bool IL2CPP_TYPE_BOOLEAN
    // 001 _isShowPopup                             bool IL2CPP_TYPE_BOOLEAN
    public partial class GGIregualDetector
    {
        public bool                                     IsError                                 { get; set; }
        public int                                      Result                                  { get; set; }

        public static GGIregualDetector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GGIregualDetector();

            value.IsError                                   = GetBool(new IntPtr(p + 0x010)); // 027003C04090 0x10 IsError                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 027003C040B0 0x14 Result                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
