using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellType                                 ModelEnumType SupportCharaFilterCellType SupportCharaFilterCellType SupportCharaFilterCellType Int32
    // 014 Index                                    ModelPrimitiveType int int int Int32
    public partial class SupportCharaSupportEffectFilterCellViewModel : DataModel
    {
        public SupportCharaFilterCellType               CellType                                { get; set; }
        public int                                      Index                                   { get; set; }

        public static SupportCharaSupportEffectFilterCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSupportEffectFilterCellViewModel() { Pointer= p0 };

            value.CellType                                  = (SupportCharaFilterCellType)GetInt32(new IntPtr(p + 0x010)); // 0x10 CellType                    ( ModelEnumType SupportCharaFilterCellType SupportCharaFilterCellType SupportCharaFilterCellType Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
