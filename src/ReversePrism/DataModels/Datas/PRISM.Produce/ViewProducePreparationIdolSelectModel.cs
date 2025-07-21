using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MustSupportCharaNum                      int IL2CPP_TYPE_I4
    // 010 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 018 StaminaModel                             ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 020 JewelModel                               ModelClassType JewelModel JewelModel JewelModel Pointer
    // 028 Units                                    ModelClassListType List`1<ProduceUnitModel> List`1<ProduceUnitModel> List<ProduceUnitModel> Pointer
    // 030 onUpdateSupportCharaFavoriteMark         Action`2<int, int> IL2CPP_TYPE_GENERICINST
    // 038 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
    // 03C CurrentUnitNumber                        ModelPrimitiveType int int int Int32
    public partial class ViewProducePreparationIdolSelectModel : DataModel
    {
        public CancellationToken                        Ct                                      { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }
        public List<ProduceUnitModel>?                  Units                                   { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }
        public int                                      CurrentUnitNumber                       { get; set; }

        public static ViewProducePreparationIdolSelectModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewProducePreparationIdolSelectModel() { Pointer= p0 };

            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x010)); // 0x10 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x18 StaminaModel                ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.JewelModel.FromPointer); // 0x20 JewelModel                  ( ModelClassType JewelModel JewelModel JewelModel Pointer )
            value.Units                                     = GetObjectList<ProduceUnitModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0x28 Units                       ( ModelClassListType List`1<ProduceUnitModel> List`1<ProduceUnitModel> List<ProduceUnitModel> Pointer )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentUnitNumber                         = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CurrentUnitNumber           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
