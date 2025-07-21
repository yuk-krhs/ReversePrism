using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartTime                                ModelPrimitiveType float float float Single
    // 014 StepSize                                 ModelPrimitiveType float float float Single
    // 018 M_Cache                                  ModelEnumListType List`1<Item> List`1<Item> List<Item> Pointer
    public partial class CacheCurve : DataModel
    {
        public float                                    StartTime                               { get; set; }
        public float                                    StepSize                                { get; set; }
        public List<Item>?                              M_Cache                                 { get; set; }

        public static CacheCurve? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CacheCurve() { Pointer= p0 };

            value.StartTime                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 StartTime                   ( ModelPrimitiveType float float float Single )
            value.StepSize                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 StepSize                    ( ModelPrimitiveType float float float Single )
            value.M_Cache                                   = GetEnumList<Item>(new IntPtr(p + 0x018)); // 0x18 M_Cache                     ( ModelEnumListType List`1<Item> List`1<Item> List<Item> Pointer )

            return value;
        }
    }
}
