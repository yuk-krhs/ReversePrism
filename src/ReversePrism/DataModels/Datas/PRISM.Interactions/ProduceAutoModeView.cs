using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Factory                                  00018652FB90 ModelClassType ProduceAutoResultPopupViewFactory ProduceAutoResultPopupViewFactory ProduceAutoResultPopupViewFactory Pointer
    // 028 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ProduceAutoModeView : DataModel
    {
        public ProduceAutoResultPopupViewFactory?       Factory                                 { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ProduceAutoModeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoModeView() { Pointer= p0 };

            value.Factory                                   = GetObject<ProduceAutoResultPopupViewFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoResultPopupViewFactory.FromPointer); // 02466A126A88 0x20 Factory                     ( 00018652FB90 ModelClassType ProduceAutoResultPopupViewFactory ProduceAutoResultPopupViewFactory ProduceAutoResultPopupViewFactory Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A126AA8 0x28 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
