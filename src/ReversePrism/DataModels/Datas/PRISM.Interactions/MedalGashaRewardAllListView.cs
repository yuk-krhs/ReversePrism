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
    public partial class MedalGashaRewardAllListView
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
            var value   = new MedalGashaRewardAllListView();

            value.BodyRowPrefab                             = GetObject<MedalGashaRewardAllListRow>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardAllListRow.FromPointer); // 0270DB9348E0 0x68 BodyRowPrefab               ( 0001865EB0F0 ModelClassType MedalGashaRewardAllListRow MedalGashaRewardAllListRow MedalGashaRewardAllListRow Pointer )
            value.BodyRowSize                               = GetInt32(new IntPtr(p + 0x070)); // 0270DB934900 0x70 BodyRowSize                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FeaturedBodyRowSize                       = GetInt32(new IntPtr(p + 0x074)); // 0270DB934920 0x74 FeaturedBodyRowSize         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HeaderRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x078), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 0270DB934940 0x78 HeaderRowViewPrefab         ( 0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.HeaderSize                                = GetInt32(new IntPtr(p + 0x080)); // 0270DB934960 0x80 HeaderSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FeaturedHeaderSize                        = GetInt32(new IntPtr(p + 0x084)); // 0270DB934980 0x84 FeaturedHeaderSize          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FooterRowViewPrefab                       = GetObject<MedalGashaRewardAllListHeader>(new IntPtr(p + 0x088), ReversePrism.DataModels.MedalGashaRewardAllListHeader.FromPointer); // 0270DB9349A0 0x88 FooterRowViewPrefab         ( 0001865EAC50 ModelClassType MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader MedalGashaRewardAllListHeader Pointer )
            value.FooterSize                                = GetInt32(new IntPtr(p + 0x090)); // 0270DB9349C0 0x90 FooterSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NextStartingIndex                         = GetInt32(new IntPtr(p + 0x094)); // 0270DB9349E0 0x94 NextStartingIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Model                                     = GetObject<MedalGashaRewardAllListViewModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.MedalGashaRewardAllListViewModel.FromPointer); // 0270DB934A00 0x98 Model                       ( 0001865EBA70 ModelClassType MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel MedalGashaRewardAllListViewModel Pointer )

            return value;
        }
    }
}
