using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Op                                       ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer
    // 018 Scene                                    ModelEnumType Scene Scene Scene Int32
    // 020 OperationException                       ModelClassType Exception Exception Exception Pointer
    // 028 Succeeded                                ModelPrimitiveType bool bool bool Bool
    // 030 AssetKey                                 ModelPrimitiveType string string string String
    public partial class SceneAsyncOperation : DataModel
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
            var value   = new SceneAsyncOperation() { Pointer= p0 };

            value.Op                                        = GetObject<AsyncOperation>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncOperation.FromPointer); // 0x10 Op                          ( ModelClassType AsyncOperation AsyncOperation AsyncOperation Pointer )
            value.Scene                                     = (Scene)GetInt32(new IntPtr(p + 0x018)); // 0x18 Scene                       ( ModelEnumType Scene Scene Scene Int32 )
            value.OperationException                        = GetObject<Exception>(new IntPtr(p + 0x020), ReversePrism.DataModels.Exception.FromPointer); // 0x20 OperationException          ( ModelClassType Exception Exception Exception Pointer )
            value.Succeeded                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 Succeeded                   ( ModelPrimitiveType bool bool bool Bool )
            value.AssetKey                                  = GetString(new IntPtr(p + 0x030)); // 0x30 AssetKey                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
