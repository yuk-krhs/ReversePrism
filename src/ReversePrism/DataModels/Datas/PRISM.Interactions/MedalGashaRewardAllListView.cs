using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 BodyRowPrefab                            0001865EB0F0 ModelClassType MedalGashaRewardAllListRow MedalGashaRewardAllListRow MedalGashaRewardAllListRow Pointer
    // 070 BodyRowSize                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 FeaturedBodyRowSize                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 HeaderRowViewPrefab                      0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer
    // 080 HeaderSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 FeaturedHeaderSize                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 FooterRowViewPrefab                      0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer
    // 090 FooterSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 NextStartingIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 Model                                    0001865EBA70 ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer
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

            value.BodyRowPrefab                             = GetObject<MedalGashaRewardAllListRow>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardAllListRow.FromPointer); // 02466B9B3B78 0x68 BodyRowPrefab               ( 0001865EB0F0 ModelClassType MedalGashaRewardAllListRow MedalGashaRewardAllListRow MedalGashaRewardAllListRow Pointer )
            value.BodyRowSize                               = GetInt32(new IntPtr(p + 0x070)); // 02466B9B3B98 0x70 BodyRowSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FeaturedBodyRowSize                       = GetInt32(new IntPtr(p + 0x074)); // 02466B9B3BB8 0x74 FeaturedBodyRowSize         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HeaderRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x078), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 02466B9B3BD8 0x78 HeaderRowViewPrefab         ( 0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.HeaderSize                                = GetInt32(new IntPtr(p + 0x080)); // 02466B9B3BF8 0x80 HeaderSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FeaturedHeaderSize                        = GetInt32(new IntPtr(p + 0x084)); // 02466B9B3C18 0x84 FeaturedHeaderSize          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FooterRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x088), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 02466B9B3C38 0x88 FooterRowViewPrefab         ( 0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.FooterSize                                = GetInt32(new IntPtr(p + 0x090)); // 02466B9B3C58 0x90 FooterSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NextStartingIndex                         = GetInt32(new IntPtr(p + 0x094)); // 02466B9B3C78 0x94 NextStartingIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Model                                     = GetObject<MedalGashaRewardAllListViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.MedalGashaRewardAllListViewModel.FromPointer); // 02466B9B3C98 0x98 Model                       ( 0001865EBA70 ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer )

            return value;
        }
    }
}
