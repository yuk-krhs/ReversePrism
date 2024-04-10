using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DescriptionOffsetHeight                  float IL2CPP_TYPE_R4
    // 010 BaseCellHeight                           000186666CB0 ModelPrimitiveType float float float Single
    // 014 ExpandedCellHeight                       0001866656B0 ModelPrimitiveType float float float Single
    // 018 Title                                    0001866736C0 ModelPrimitiveType string string string String
    // 020 Description                              0001866736C0 ModelPrimitiveType string string string String
    // 028 CellType                                 0001866B0B50 ModelEnumType HelpListCellType HelpListCellType HelpListCellType Int32
    // 02C HelpGroupId                              0001865F4940 ModelPrimitiveType int int int Int32
    // 030 HelpId                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 034 DescriptionPreferredHeight               0001866656B0 ModelPrimitiveType float float float Single
    // 038 IsExpanded                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.BaseCellHeight                            = GetSingle(new IntPtr(p + 0x010)); // 024666981B40 0x10 BaseCellHeight              ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.ExpandedCellHeight                        = GetSingle(new IntPtr(p + 0x014)); // 024666981B60 0x14 ExpandedCellHeight          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 024666981B80 0x18 Title                       ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 024666981BA0 0x20 Description                 ( 0001866736C0 ModelPrimitiveType string string string String )
            value.CellType                                  = (HelpListCellType)GetInt32(new IntPtr(p + 0x028)); // 024666981BC0 0x28 CellType                    ( 0001866B0B50 ModelEnumType HelpListCellType HelpListCellType HelpListCellType Int32 )
            value.HelpGroupId                               = GetInt32(new IntPtr(p + 0x02C)); // 024666981BE0 0x2C HelpGroupId                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.HelpId                                    = GetInt32(new IntPtr(p + 0x030)); // 024666981C00 0x30 HelpId                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.DescriptionPreferredHeight                = GetSingle(new IntPtr(p + 0x034)); // 024666981C20 0x34 DescriptionPreferredHeight  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsExpanded                                = GetBool(new IntPtr(p + 0x038)); // 024666981C40 0x38 IsExpanded                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
