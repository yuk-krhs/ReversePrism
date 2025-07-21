using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer
    // 018 IdolPosition                             ModelPrimitiveType int int int Int32
    // 020 CasualCostumeIdol                        ModelClassType CasualCostumeIdol CasualCostumeIdol CasualCostumeIdol Pointer
    // 028 FirstViewCategory                        ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 02C NeedSetEnableOnChange                    ModelPrimitiveType bool bool bool Bool
    public partial class LiveCostumeChangeArgument : DataModel
    {
        public ILiveUnit?                               Unit                                    { get; set; }
        public int                                      IdolPosition                            { get; set; }
        public CasualCostumeIdol?                       CasualCostumeIdol                       { get; set; }
        public CostumeCategory                          FirstViewCategory                       { get; set; }
        public bool                                     NeedSetEnableOnChange                   { get; set; }

        public static LiveCostumeChangeArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeArgument() { Pointer= p0 };

            value.Unit                                      = GetObject<ILiveUnit>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILiveUnit.FromPointer); // 0x10 Unit                        ( ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 IdolPosition                ( ModelPrimitiveType int int int Int32 )
            value.CasualCostumeIdol                         = GetObject<CasualCostumeIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.CasualCostumeIdol.FromPointer); // 0x20 CasualCostumeIdol           ( ModelClassType CasualCostumeIdol CasualCostumeIdol CasualCostumeIdol Pointer )
            value.FirstViewCategory                         = (CostumeCategory)GetInt32(new IntPtr(p + 0x028)); // 0x28 FirstViewCategory           ( ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.NeedSetEnableOnChange                     = GetBool(new IntPtr(p + 0x02C)); // 0x2C NeedSetEnableOnChange       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
