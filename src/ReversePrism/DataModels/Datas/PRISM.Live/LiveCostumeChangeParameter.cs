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
    public partial class LiveCostumeChangeParameter
    {
        public ILiveUnit?                               Unit                                    { get; set; }
        public int                                      IdolPosition                            { get; set; }
        public CasualCostumeIdol?                       CasualCostumeIdol                       { get; set; }
        public CostumeCategory                          FirstViewCategory                       { get; set; }
        public List<ViewValue>?                         ViewStacks                              { get; set; }

        public static LiveCostumeChangeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeParameter();

            value.Unit                                      = GetObject<ILiveUnit>(new IntPtr(p + 0x010), ReversePrism.DataModels.ILiveUnit.FromPointer); // 0270D50D0870 0x10 Unit                        ( 00018659C550 ModelClassType ILiveUnit ILiveUnit ILiveUnit Pointer )
            value.IdolPosition                              = GetInt32(new IntPtr(p + 0x018)); // 0270D50D0890 0x18 IdolPosition                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CasualCostumeIdol                         = GetObject<CasualCostumeIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.CasualCostumeIdol.FromPointer); // 0270D50D08B0 0x20 CasualCostumeIdol           ( 00018654A810 ModelClassType CasualCostumeIdol CasualCostumeIdol CasualCostumeIdol Pointer )
            value.FirstViewCategory                         = (CostumeCategory)GetInt32(new IntPtr(p + 0x028)); // 0270D50D08D0 0x28 FirstViewCategory           ( 0001866298D0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.ViewStacks                                = GetObjectList<ViewValue>(new IntPtr(p + 0x030), ReversePrism.DataModels.ViewValue.FromPointer); // 0270D50D08F0 0x30 ViewStacks                  ( 000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
