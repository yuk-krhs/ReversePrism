using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultLoadingScreen                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Counter                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MobileLoadingScreen
    {
        public GameObject?                              DefaultLoadingScreen                    { get; set; }
        public int                                      Counter                                 { get; set; }

        public static MobileLoadingScreen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileLoadingScreen();

            value.DefaultLoadingScreen                      = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB11C988 0x20 DefaultLoadingScreen        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Counter                                   = GetInt32(new IntPtr(p + 0x028)); // 0270DB11C9A8 0x28 Counter                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
