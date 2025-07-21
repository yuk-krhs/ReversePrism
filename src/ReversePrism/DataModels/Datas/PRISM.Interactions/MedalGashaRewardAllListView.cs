using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 BodyRowPrefab                            ModelClassType MedalGashaRewardAllListRow MedalGashaRewardAllListRow MedalGashaRewardAllListRow Pointer
    // 060 BodyRowSize                              ModelPrimitiveType int int int Int32
    // 064 FeaturedBodyRowSize                      ModelPrimitiveType int int int Int32
    // 068 HeaderRowViewPrefab                      ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer
    // 070 HeaderSize                               ModelPrimitiveType int int int Int32
    // 074 FeaturedHeaderSize                       ModelPrimitiveType int int int Int32
    // 078 FooterRowViewPrefab                      ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer
    // 080 FooterSize                               ModelPrimitiveType int int int Int32
    // 084 NextStartingIndex                        ModelPrimitiveType int int int Int32
    // 088 Model                                    ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer
    public partial class MedalGashaRewardAllListView : DataModel
    {
        public MedalGashaRewardAllListRow?              BodyRowPrefab                           { get; set; }
        public int                                      BodyRowSize                             { get; set; }
        public int                                      FeaturedBodyRowSize                     { get; set; }
        public MedalGashaRewardAllListHeader?           HeaderRowViewPrefab                     { get; set; }
        public int                                      HeaderSize                              { get; set; }
        public int                                      FeaturedHeaderSize                      { get; set; }
        public MedalGashaRewardAllListHeader?           FooterRowViewPrefab                     { get; set; }
        public int                                      FooterSize                              { get; set; }
        public int                                      NextStartingIndex                       { get; set; }
        public MedalGashaRewardAllListViewModel?        Model                                   { get; set; }

        public static MedalGashaRewardAllListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListView() { Pointer= p0 };

            value.BodyRowPrefab                             = GetObject<MedalGashaRewardAllListRow>(new IntPtr(p + 0x058), ReversePrism.DataModels.MedalGashaRewardAllListRow.FromPointer); // 0x58 BodyRowPrefab               ( ModelClassType MedalGashaRewardAllListRow MedalGashaRewardAllListRow MedalGashaRewardAllListRow Pointer )
            value.BodyRowSize                               = GetInt32(new IntPtr(p + 0x060)); // 0x60 BodyRowSize                 ( ModelPrimitiveType int int int Int32 )
            value.FeaturedBodyRowSize                       = GetInt32(new IntPtr(p + 0x064)); // 0x64 FeaturedBodyRowSize         ( ModelPrimitiveType int int int Int32 )
            value.HeaderRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 0x68 HeaderRowViewPrefab         ( ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.HeaderSize                                = GetInt32(new IntPtr(p + 0x070)); // 0x70 HeaderSize                  ( ModelPrimitiveType int int int Int32 )
            value.FeaturedHeaderSize                        = GetInt32(new IntPtr(p + 0x074)); // 0x74 FeaturedHeaderSize          ( ModelPrimitiveType int int int Int32 )
            value.FooterRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x078), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 0x78 FooterRowViewPrefab         ( ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.FooterSize                                = GetInt32(new IntPtr(p + 0x080)); // 0x80 FooterSize                  ( ModelPrimitiveType int int int Int32 )
            value.NextStartingIndex                         = GetInt32(new IntPtr(p + 0x084)); // 0x84 NextStartingIndex           ( ModelPrimitiveType int int int Int32 )
            value.Model                                     = GetObject<MedalGashaRewardAllListViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.MedalGashaRewardAllListViewModel.FromPointer); // 0x88 Model                       ( ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer )

            return value;
        }
    }
}
