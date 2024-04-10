using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     00018659C550 ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer
    // 018 IdolPosition                             0001865F4260 ModelPrimitiveType int int int Int32
    // 020 CasualCostumeIdol                        00018654A810 ModelClassType CasualCostumeIdol CasualCostumeIdol CasualCostumeIdol Pointer
    // 028 FirstViewCategory                        0001866298D0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 030 ViewStacks                               000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LiveCostumeChangeArgument : DataModel
    {
        public ILiveUnit?                               Unit                                    { get; set; }
        public int                                      IdolPosition                            { get; set; }
        public CasualCostumeIdol?                       CasualCostumeIdol                       { get; set; }
        public CostumeCategory                          FirstViewCategory                       { get; set; }
        public List<ViewValue>?                         ViewStacks                              { get; set; }

        public static LiveCostumeChangeArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeArgument() { Pointer= p0 };

            value.Unit                                      = GetObject<ILiveUnit>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILiveUnit.FromPointer); // 02466643AAC8 0x10 Unit                        ( 00018659C550 ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x018)); // 02466643AAE8 0x18 IdolPosition                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CasualCostumeIdol                         = GetObject<CasualCostumeIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.CasualCostumeIdol.FromPointer); // 02466643AB08 0x20 CasualCostumeIdol           ( 00018654A810 ModelClassType CasualCostumeIdol CasualCostumeIdol CasualCostumeIdol Pointer )
            value.FirstViewCategory                         = (CostumeCategory)GetInt32(new IntPtr(p + 0x028)); // 02466643AB28 0x28 FirstViewCategory           ( 0001866298D0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x030), ReversePrism.DataModels.ViewValue.FromPointer); // 02466643AB48 0x30 ViewStacks                  ( 000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
