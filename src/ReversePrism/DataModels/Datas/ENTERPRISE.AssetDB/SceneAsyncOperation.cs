using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Op                                       0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    // 018 Scene                                    000186660100 ModelEnumType Scene Scene Scene Int32
    // 020 OperationException                       0001865CA820 ModelClassType Exception Exception Exception Pointer
    // 028 Succeeded                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 AssetKey                                 000186671910 ModelPrimitiveType string string string String
    public partial class SceneAsyncOperation
    {
        public AsyncOperation?                          Op                                      { get; set; }
        public Scene                                    Scene                                   { get; set; }
        public Exception?                               OperationException                      { get; set; }
        public bool                                     Succeeded                               { get; set; }
        public string                                   AssetKey                                { get; set; }

        public static SceneAsyncOperation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneAsyncOperation();

            value.Op                                        = GetObject<AsyncOperation>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncOperation.FromPointer); // 027003F51D18 0x10 Op                          ( 0001866FAA20 ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )
            value.Scene                                     = (Scene)GetInt32(new IntPtr(p + 0x018)); // 027003F51D38 0x18 Scene                       ( 000186660100 ModelEnumType Scene Scene Scene Int32 )
            value.OperationException                        = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 027003F51D58 0x20 OperationException          ( 0001865CA820 ModelClassType Exception Exception Exception Pointer )
            value.Succeeded                                 = GetBool(new IntPtr(p + 0x028)); // 027003F51D78 0x28 Succeeded                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AssetKey                                  = GetString(new IntPtr(p + 0x030)); // 027003F51D98 0x30 AssetKey                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
