using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActiveEventSystem                        00018676C190 ModelClassType EventSystem EventSystem EventSystem Pointer
    // 018 SendEvents                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 019 CreatePanelGameObjectsOnStart            000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class UIToolkitOverrideConfig
    {
        public EventSystem?                             ActiveEventSystem                       { get; set; }
        public bool                                     SendEvents                              { get; set; }
        public bool                                     CreatePanelGameObjectsOnStart           { get; set; }

        public static UIToolkitOverrideConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIToolkitOverrideConfig();

            value.ActiveEventSystem                         = GetObject<EventSystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventSystem.FromPointer); // 027003E88FD0 0x10 ActiveEventSystem           ( 00018676C190 ModelClassType EventSystem EventSystem EventSystem Pointer )
            value.SendEvents                                = GetBool(new IntPtr(p + 0x018)); // 027003E88FF0 0x18 SendEvents                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CreatePanelGameObjectsOnStart             = GetBool(new IntPtr(p + 0x019)); // 027003E89010 0x19 CreatePanelGameObjectsOnStart ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
