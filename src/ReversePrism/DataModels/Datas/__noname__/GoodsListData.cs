using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GroupID                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 GoodsIDs                                 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class GoodsListData : DataModel
    {
        public int                                      GroupID                                 { get; set; }
        public List<int>?                               GoodsIDs                                { get; set; }

        public static GoodsListData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoodsListData() { Pointer= p0 };

            value.GroupID                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A3AAF0B0 0x10 GroupID                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GoodsIDs                                  = GetInt32List(new IntPtr(p + 0x018)); // 0245A3AAF0D0 0x18 GoodsIDs                    ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
