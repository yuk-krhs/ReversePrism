using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdolService                              ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer
    // 018 CostumeService                           ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer
    // 020 ProduceIdolService                       ModelClassType ICachedProduceIdolService ICachedProduceIdolService ICachedProduceIdolService Pointer
    // 028 FesIdolService                           ModelClassType ICachedFesIdolService ICachedFesIdolService ICachedFesIdolService Pointer
    public partial class LiveIdolFactory : DataModel
    {
        public ICachedIdolService?                      IdolService                             { get; set; }
        public ICachedCostumeService?                   CostumeService                          { get; set; }
        public ICachedProduceIdolService?               ProduceIdolService                      { get; set; }
        public ICachedFesIdolService?                   FesIdolService                          { get; set; }

        public static LiveIdolFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolFactory() { Pointer= p0 };

            value.IdolService                               = GetObject<ICachedIdolService>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICachedIdolService.FromPointer); // 0x10 IdolService                 ( ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer )
            value.CostumeService                            = GetObject<ICachedCostumeService>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICachedCostumeService.FromPointer); // 0x18 CostumeService              ( ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer )
            value.ProduceIdolService                        = GetObject<ICachedProduceIdolService>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICachedProduceIdolService.FromPointer); // 0x20 ProduceIdolService          ( ModelClassType ICachedProduceIdolService ICachedProduceIdolService ICachedProduceIdolService Pointer )
            value.FesIdolService                            = GetObject<ICachedFesIdolService>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICachedFesIdolService.FromPointer); // 0x28 FesIdolService              ( ModelClassType ICachedFesIdolService ICachedFesIdolService ICachedFesIdolService Pointer )

            return value;
        }
    }
}
