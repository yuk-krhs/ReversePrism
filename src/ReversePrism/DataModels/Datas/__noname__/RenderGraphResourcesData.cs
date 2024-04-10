using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 resourceArray                            DynamicArray`1<IRenderGraphResource> IL2CPP_TYPE_GENERICINST
    // 018 SharedResourcesCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Pool                                     000186618EC0 ModelClassType IRenderGraphResourcePool IRenderGraphResourcePool IRenderGraphResourcePool Pointer
    // 028 CreateResourceCallback                   0001866CE410 ModelClassType ResourceCallback ResourceCallback ResourceCallback Pointer
    // 030 ReleaseResourceCallback                  0001866CE410 ModelClassType ResourceCallback ResourceCallback ResourceCallback Pointer
    public partial class RenderGraphResourcesData : DataModel
    {
        public int                                      SharedResourcesCount                    { get; set; }
        public IRenderGraphResourcePool?                Pool                                    { get; set; }
        public ResourceCallback?                        CreateResourceCallback                  { get; set; }
        public ResourceCallback?                        ReleaseResourceCallback                 { get; set; }

        public static RenderGraphResourcesData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphResourcesData() { Pointer= p0 };

            value.SharedResourcesCount                      = GetInt32(new IntPtr(p + 0x018)); // 024669154D78 0x18 SharedResourcesCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Pool                                      = GetObject<IRenderGraphResourcePool>(new IntPtr(p + 0x020), ReversePrism.DataModels.IRenderGraphResourcePool.FromPointer); // 024669154D98 0x20 Pool                        ( 000186618EC0 ModelClassType IRenderGraphResourcePool IRenderGraphResourcePool IRenderGraphResourcePool Pointer )
            value.CreateResourceCallback                    = GetObject<ResourceCallback>(new IntPtr(p + 0x028), ReversePrism.DataModels.ResourceCallback.FromPointer); // 024669154DB8 0x28 CreateResourceCallback      ( 0001866CE410 ModelClassType ResourceCallback ResourceCallback ResourceCallback Pointer )
            value.ReleaseResourceCallback                   = GetObject<ResourceCallback>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResourceCallback.FromPointer); // 024669154DD8 0x30 ReleaseResourceCallback     ( 0001866CE410 ModelClassType ResourceCallback ResourceCallback ResourceCallback Pointer )

            return value;
        }
    }
}
