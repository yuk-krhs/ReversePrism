using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType IdolListView IdolListView IdolListView Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PiView                                   ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer
    // 038 ScView                                   ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer
    // 040 FuView                                   ModelClassType FesUnitListView FesUnitListView FesUnitListView Pointer
    // 048 FiView                                   ModelClassType FesIdolListView FesIdolListView FesIdolListView Pointer
    public partial class IdolListBuilder : DataModel
    {
        public IdolListView?                            View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolListView?                     PiView                                  { get; set; }
        public SupportCharaListView?                    ScView                                  { get; set; }
        public FesUnitListView?                         FuView                                  { get; set; }
        public FesIdolListView?                         FiView                                  { get; set; }

        public static IdolListBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListBuilder() { Pointer= p0 };

            value.View                                      = GetObject<IdolListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolListView.FromPointer); // 0x20 View                        ( ModelClassType IdolListView IdolListView IdolListView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<ProduceIdolListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolListView.FromPointer); // 0x30 PiView                      ( ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer )
            value.ScView                                    = GetObject<SupportCharaListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaListView.FromPointer); // 0x38 ScView                      ( ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer )
            value.FuView                                    = GetObject<FesUnitListView>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesUnitListView.FromPointer); // 0x40 FuView                      ( ModelClassType FesUnitListView FesUnitListView FesUnitListView Pointer )
            value.FiView                                    = GetObject<FesIdolListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.FesIdolListView.FromPointer); // 0x48 FiView                      ( ModelClassType FesIdolListView FesIdolListView FesIdolListView Pointer )

            return value;
        }
    }
}
