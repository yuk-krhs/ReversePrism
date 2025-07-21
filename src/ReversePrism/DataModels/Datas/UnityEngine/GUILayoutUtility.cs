using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_StoredLayouts                          Dictionary`2<int, LayoutCache> IL2CPP_TYPE_GENERICINST
    // 008 s_StoredWindows                          Dictionary`2<int, LayoutCache> IL2CPP_TYPE_GENERICINST
    // 010 Current                                  ModelClassType LayoutCache LayoutCache LayoutCache Pointer
    // 018 KDummyRect                               ModelEnumType Rect Rect Rect Int32
    // 028 Unbalancedgroupscount                    ModelPrimitiveType int int int Int32
    public partial class GUILayoutUtility : DataModel
    {
        public LayoutCache?                             Current                                 { get; set; }
        public Rect                                     KDummyRect                              { get; set; }
        public int                                      Unbalancedgroupscount                   { get; set; }

        public static GUILayoutUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUILayoutUtility() { Pointer= p0 };

            value.Current                                   = GetObject<LayoutCache>(new IntPtr(p + 0x010), ReversePrism.DataModels.LayoutCache.FromPointer); // 0x10 Current                     ( ModelClassType LayoutCache LayoutCache LayoutCache Pointer )
            value.KDummyRect                                = (Rect)GetInt32(new IntPtr(p + 0x018)); // 0x18 KDummyRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.Unbalancedgroupscount                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Unbalancedgroupscount       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
