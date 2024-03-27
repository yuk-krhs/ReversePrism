using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeSetId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CostumeSetName                           000186672F10 ModelPrimitiveType string string string String
    // 020 IsUnlocked                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 Dress                                    00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer
    // 030 Hairstyle                                00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer
    // 038 Glasses                                  00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer
    // 040 Earrings                                 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer
    // 048 Makeup                                   00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer
    public partial class CostumeSetListViewCellData
    {
        public int                                      CostumeSetId                            { get; set; }
        public string                                   CostumeSetName                          { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public CostumeCellData?                         Dress                                   { get; set; }
        public CostumeCellData?                         Hairstyle                               { get; set; }
        public CostumeCellData?                         Glasses                                 { get; set; }
        public CostumeCellData?                         Earrings                                { get; set; }
        public CostumeCellData?                         Makeup                                  { get; set; }

        public static CostumeSetListViewCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetListViewCellData();

            value.CostumeSetId                              = GetInt32(new IntPtr(p + 0x010)); // 0270D623D160 0x10 CostumeSetId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CostumeSetName                            = GetString(new IntPtr(p + 0x018)); // 0270D623D180 0x18 CostumeSetName              ( 000186672F10 ModelPrimitiveType string string string String )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x020)); // 0270D623D1A0 0x20 IsUnlocked                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Dress                                     = GetObject<CostumeCellData>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeCellData.FromPointer); // 0270D623D1C0 0x28 Dress                       ( 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer )
            value.Hairstyle                                 = GetObject<CostumeCellData>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeCellData.FromPointer); // 0270D623D1E0 0x30 Hairstyle                   ( 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer )
            value.Glasses                                   = GetObject<CostumeCellData>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeCellData.FromPointer); // 0270D623D200 0x38 Glasses                     ( 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer )
            value.Earrings                                  = GetObject<CostumeCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeCellData.FromPointer); // 0270D623D220 0x40 Earrings                    ( 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer )
            value.Makeup                                    = GetObject<CostumeCellData>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumeCellData.FromPointer); // 0270D623D240 0x48 Makeup                      ( 00018662A1F0 ModelClassType CostumeCellData CostumeCellData CostumeCellData Pointer )

            return value;
        }
    }
}
