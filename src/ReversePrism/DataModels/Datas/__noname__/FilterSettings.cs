using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderQueueType                          ModelEnumType RenderQueueType RenderQueueType RenderQueueType Int32
    // 014 LayerMask                                ModelEnumType LayerMask LayerMask LayerMask Int32
    // 018 PassNames                                ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class FilterSettings : DataModel
    {
        public RenderQueueType                          RenderQueueType                         { get; set; }
        public LayerMask                                LayerMask                               { get; set; }
        public List<string>?                            PassNames                               { get; set; }

        public static FilterSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FilterSettings() { Pointer= p0 };

            value.RenderQueueType                           = (RenderQueueType)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderQueueType             ( ModelEnumType RenderQueueType RenderQueueType RenderQueueType Int32 )
            value.LayerMask                                 = (LayerMask)GetInt32(new IntPtr(p + 0x014)); // 0x14 LayerMask                   ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.PassNames                                 = GetStringList(new IntPtr(p + 0x018)); // 0x18 PassNames                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
