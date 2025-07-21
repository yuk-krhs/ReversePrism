using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurveType                                ModelEnumType CurveType CurveType CurveType Int32
    // 014 CurveStrength                            ModelPrimitiveType float float float Single
    // 018 FadeTimeMs                               ModelPrimitiveType ushort ushort ushort UInt16
    public partial class ReactFadeParameter : DataModel
    {
        public CurveType                                CurveType                               { get; set; }
        public float                                    CurveStrength                           { get; set; }
        public ushort                                   FadeTimeMs                              { get; set; }

        public static ReactFadeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactFadeParameter() { Pointer= p0 };

            value.CurveType                                 = (CurveType)GetInt32(new IntPtr(p + 0x010)); // 0x10 CurveType                   ( ModelEnumType CurveType CurveType CurveType Int32 )
            value.CurveStrength                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 CurveStrength               ( ModelPrimitiveType float float float Single )
            value.FadeTimeMs                                = GetUInt16(new IntPtr(p + 0x018)); // 0x18 FadeTimeMs                  ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
