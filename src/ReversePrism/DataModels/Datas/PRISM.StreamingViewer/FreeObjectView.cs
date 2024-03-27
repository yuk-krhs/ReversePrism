using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 Loaded                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 ObjectName                               000186671910 ModelPrimitiveType string string string String
    // 030 FreeObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 040 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class FreeObjectView
    {
        public bool                                     Loaded                                  { get; set; }
        public string                                   ObjectName                              { get; set; }
        public GameObject?                              FreeObject                              { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static FreeObjectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FreeObjectView();

            value.Loaded                                    = GetBool(new IntPtr(p + 0x020)); // 0270D4F46E40 0x20 Loaded                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ObjectName                                = GetString(new IntPtr(p + 0x028)); // 0270D4F46E60 0x28 ObjectName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.FreeObject                                = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4F46E80 0x30 FreeObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x040)); // 0270D4F46EC0 0x40 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
