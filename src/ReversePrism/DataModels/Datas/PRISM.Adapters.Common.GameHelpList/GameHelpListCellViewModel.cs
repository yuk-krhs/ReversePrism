using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionOffsetHeight                  float IL2CPP_TYPE_R4
    // 010 BaseCellHeight                           ModelPrimitiveType float float float Single
    // 014 ExpandedCellHeight                       ModelPrimitiveType float float float Single
    // 018 Title                                    ModelPrimitiveType string string string String
    // 020 Description                              ModelPrimitiveType string string string String
    // 028 CellType                                 ModelEnumType HelpListCellType HelpListCellType HelpListCellType Int32
    // 02C HelpGroupId                              ModelPrimitiveType int int int Int32
    // 030 HelpId                                   ModelPrimitiveType int int int Int32
    // 034 DescriptionPreferredHeight               ModelPrimitiveType float float float Single
    // 038 IsExpanded                               ModelPrimitiveType bool bool bool Bool
    public partial class GameHelpListCellViewModel : DataModel
    {
        public float                                    BaseCellHeight                          { get; set; }
        public float                                    ExpandedCellHeight                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public HelpListCellType                         CellType                                { get; set; }
        public int                                      HelpGroupId                             { get; set; }
        public int                                      HelpId                                  { get; set; }
        public float                                    DescriptionPreferredHeight              { get; set; }
        public bool                                     IsExpanded                              { get; set; }

        public static GameHelpListCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GameHelpListCellViewModel() { Pointer= p0 };

            value.BaseCellHeight                            = GetSingle(new IntPtr(p + 0x010)); // 0x10 BaseCellHeight              ( ModelPrimitiveType float float float Single )
            value.ExpandedCellHeight                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 ExpandedCellHeight          ( ModelPrimitiveType float float float Single )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0x18 Title                       ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0x20 Description                 ( ModelPrimitiveType string string string String )
            value.CellType                                  = (HelpListCellType)GetInt32(new IntPtr(p + 0x028)); // 0x28 CellType                    ( ModelEnumType HelpListCellType HelpListCellType HelpListCellType Int32 )
            value.HelpGroupId                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C HelpGroupId                 ( ModelPrimitiveType int int int Int32 )
            value.HelpId                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 HelpId                      ( ModelPrimitiveType int int int Int32 )
            value.DescriptionPreferredHeight                = GetSingle(new IntPtr(p + 0x034)); // 0x34 DescriptionPreferredHeight  ( ModelPrimitiveType float float float Single )
            value.IsExpanded                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsExpanded                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
