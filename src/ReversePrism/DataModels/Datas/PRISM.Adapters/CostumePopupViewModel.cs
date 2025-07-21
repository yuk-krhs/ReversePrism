using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeSetList                           ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer
    // 018 DressList                                ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 020 HairStyleList                            ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 028 GlassList                                ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 030 EarringList                              ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 038 MakeUpList                               ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 040 CasualCostumeSetList                     ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer
    // 048 CasualDressList                          ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 050 CasualHairStyleList                      ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 058 CasualGlassList                          ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 060 CasualEarringList                        ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 068 CasualMakeUpList                         ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 070 possessionCount                          <Array> IL2CPP_TYPE_ARRAY
    // 078 casualPossessionCount                    <Array> IL2CPP_TYPE_ARRAY
    // 080 IsActive                                 ModelPrimitiveType bool bool bool Bool
    // 081 IsSet                                    ModelPrimitiveType bool bool bool Bool
    // 082 IsCasual                                 ModelPrimitiveType bool bool bool Bool
    // 084 PartsType                                ModelEnumType PartsType PartsType PartsType Int32
    public partial class CostumePopupViewModel : DataModel
    {
        public List<GalleryCostumeSetViewModel>?        CostumeSetList                          { get; set; }
        public List<GalleryCostumeViewModel>?           DressList                               { get; set; }
        public List<GalleryCostumeViewModel>?           HairStyleList                           { get; set; }
        public List<GalleryCostumeViewModel>?           GlassList                               { get; set; }
        public List<GalleryCostumeViewModel>?           EarringList                             { get; set; }
        public List<GalleryCostumeViewModel>?           MakeUpList                              { get; set; }
        public List<GalleryCostumeSetViewModel>?        CasualCostumeSetList                    { get; set; }
        public List<GalleryCostumeViewModel>?           CasualDressList                         { get; set; }
        public List<GalleryCostumeViewModel>?           CasualHairStyleList                     { get; set; }
        public List<GalleryCostumeViewModel>?           CasualGlassList                         { get; set; }
        public List<GalleryCostumeViewModel>?           CasualEarringList                       { get; set; }
        public List<GalleryCostumeViewModel>?           CasualMakeUpList                        { get; set; }
        public bool                                     IsActive                                { get; set; }
        public bool                                     IsSet                                   { get; set; }
        public bool                                     IsCasual                                { get; set; }
        public PartsType                                PartsType                               { get; set; }

        public static CostumePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePopupViewModel() { Pointer= p0 };

            value.CostumeSetList                            = GetObjectList<GalleryCostumeSetViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GalleryCostumeSetViewModel.FromPointer); // 0x10 CostumeSetList              ( ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer )
            value.DressList                                 = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x18 DressList                   ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.HairStyleList                             = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x20 HairStyleList               ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.GlassList                                 = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x28 GlassList                   ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.EarringList                               = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x30 EarringList                 ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.MakeUpList                                = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x38 MakeUpList                  ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualCostumeSetList                      = GetObjectList<GalleryCostumeSetViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.GalleryCostumeSetViewModel.FromPointer); // 0x40 CasualCostumeSetList        ( ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer )
            value.CasualDressList                           = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x48 CasualDressList             ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualHairStyleList                       = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x50 CasualHairStyleList         ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualGlassList                           = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x58 CasualGlassList             ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualEarringList                         = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x60 CasualEarringList           ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualMakeUpList                          = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 0x68 CasualMakeUpList            ( ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x080)); // 0x80 IsActive                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsSet                                     = GetBool(new IntPtr(p + 0x081)); // 0x81 IsSet                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsCasual                                  = GetBool(new IntPtr(p + 0x082)); // 0x82 IsCasual                    ( ModelPrimitiveType bool bool bool Bool )
            value.PartsType                                 = (PartsType)GetInt32(new IntPtr(p + 0x084)); // 0x84 PartsType                   ( ModelEnumType PartsType PartsType PartsType Int32 )

            return value;
        }
    }
}
