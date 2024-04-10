using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nativeDisplay                            <int> IL2CPP_TYPE_I
    // 000 displays                                 Display[] IL2CPP_TYPE_SZARRAY
    // 008 _mainDisplay                             Display IL2CPP_TYPE_CLASS
    // 010 M_ActiveEditorGameViewTarget             0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 OnDisplaysUpdated                        0001865A9360 ModelClassType DisplaysUpdatedDelegate DisplaysUpdatedDelegate DisplaysUpdatedDelegate Pointer
    public partial class Display : DataModel
    {
        public int                                      M_ActiveEditorGameViewTarget            { get; set; }
        public DisplaysUpdatedDelegate?                 OnDisplaysUpdated                       { get; set; }

        public static Display? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Display() { Pointer= p0 };

            value.M_ActiveEditorGameViewTarget              = GetInt32(new IntPtr(p + 0x010)); // 0245A236CCF8 0x10 M_ActiveEditorGameViewTarget ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.OnDisplaysUpdated                         = GetObject<DisplaysUpdatedDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.DisplaysUpdatedDelegate.FromPointer); // 0245A236CD18 0x18 OnDisplaysUpdated           ( 0001865A9360 ModelClassType DisplaysUpdatedDelegate DisplaysUpdatedDelegate DisplaysUpdatedDelegate Pointer )

            return value;
        }
    }
}
