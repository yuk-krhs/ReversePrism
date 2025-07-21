using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsError                                  ModelPrimitiveType bool bool bool Bool
    // 014 Result                                   ModelPrimitiveType int int int Int32
    // 000 _isPopupReady                            bool IL2CPP_TYPE_BOOLEAN
    // 001 _isShowPopup                             bool IL2CPP_TYPE_BOOLEAN
    public partial class GGIregualDetector : DataModel
    {
        public bool                                     IsError                                 { get; set; }
        public int                                      Result                                  { get; set; }

        public static GGIregualDetector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GGIregualDetector() { Pointer= p0 };

            value.IsError                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 IsError                     ( ModelPrimitiveType bool bool bool Bool )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Result                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
