using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 transformDataPool                        List`1<HierarchyDataTransform> IL2CPP_TYPE_GENERICINST
    // 008 childrenListPool                         List`1<List`1<HierarchyDataTransform>> IL2CPP_TYPE_GENERICINST
    // 010 Children                                 000185CDFC48 ModelClassListType List`1<HierarchyDataTransform> List`1<HierarchyDataTransform> List<HierarchyDataTransform> Pointer
    // 018 Parent                                   0001866B3EB0 ModelClassType HierarchyData HierarchyData HierarchyData Pointer
    // 020 M_index                                  0001865F3220 ModelPrimitiveType int int int Int32
    // 024 M_height                                 0001865F3220 ModelPrimitiveType int int int Int32
    // 028 M_depth                                  0001865F3220 ModelPrimitiveType int int int Int32
    public partial class HierarchyData
    {
        public List<HierarchyDataTransform>?            Children                                { get; set; }
        public HierarchyData?                           Parent                                  { get; set; }
        public int                                      M_index                                 { get; set; }
        public int                                      M_height                                { get; set; }
        public int                                      M_depth                                 { get; set; }

        public static HierarchyData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HierarchyData();

            value.Children                                  = GetObjectList<HierarchyDataTransform>(new IntPtr(p + 0x010), ReversePrism.DataModels.HierarchyDataTransform.FromPointer); // 0270DB193380 0x10 Children                    ( 000185CDFC48 ModelClassListType List`1<HierarchyDataTransform> List`1<HierarchyDataTransform> List<HierarchyDataTransform> Pointer )
            value.Parent                                    = GetObject<HierarchyData>(new IntPtr(p + 0x018), ReversePrism.DataModels.HierarchyData.FromPointer); // 0270DB1933A0 0x18 Parent                      ( 0001866B3EB0 ModelClassType HierarchyData HierarchyData HierarchyData Pointer )
            value.M_index                                   = GetInt32(new IntPtr(p + 0x020)); // 0270DB1933C0 0x20 M_index                     ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_height                                  = GetInt32(new IntPtr(p + 0x024)); // 0270DB1933E0 0x24 M_height                    ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_depth                                   = GetInt32(new IntPtr(p + 0x028)); // 0270DB193400 0x28 M_depth                     ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
