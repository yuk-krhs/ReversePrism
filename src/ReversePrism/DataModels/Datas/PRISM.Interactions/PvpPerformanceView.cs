using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 028 Content                                  0001865ECA70 ModelClassType PvpPerformanceContent PvpPerformanceContent PvpPerformanceContent Pointer
    public partial class PvpPerformanceView
    {
        public IResourceTag?                            ResourceTag                             { get; set; }
        public PvpPerformanceContent?                   Content                                 { get; set; }

        public static PvpPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceView();

            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB61F548 0x20 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Content                                   = GetObject<PvpPerformanceContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.PvpPerformanceContent.FromPointer); // 0270DB61F568 0x28 Content                     ( 0001865ECA70 ModelClassType PvpPerformanceContent PvpPerformanceContent PvpPerformanceContent Pointer )

            return value;
        }
    }
}
