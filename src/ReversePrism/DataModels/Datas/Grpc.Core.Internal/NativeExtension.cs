using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CsharpExtOverrideLocationEnvVarName      string IL2CPP_TYPE_STRING
    // 000 Logger                                   ILogger IL2CPP_TYPE_CLASS
    // 008 staticLock                               <object> IL2CPP_TYPE_OBJECT
    // 010 Instance                                 ModelClassType NativeExtension NativeExtension NativeExtension Pointer
    // 010 NativeMethods                            ModelClassType NativeMethods NativeMethods NativeMethods Pointer
    public partial class NativeExtension : DataModel
    {
        public NativeExtension?                         Instance                                { get; set; }
        public NativeMethods?                           NativeMethods                           { get; set; }

        public static NativeExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeExtension() { Pointer= p0 };

            value.Instance                                  = GetObject<NativeExtension>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeExtension.FromPointer); // 0x10 Instance                    ( ModelClassType NativeExtension NativeExtension NativeExtension Pointer )
            value.NativeMethods                             = GetObject<NativeMethods>(new IntPtr(p + 0x010), ReversePrism.DataModels.NativeMethods.FromPointer); // 0x10 NativeMethods               ( ModelClassType NativeMethods NativeMethods NativeMethods Pointer )

            return value;
        }
    }
}
