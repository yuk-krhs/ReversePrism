using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FontEngineError
    {
        Success,
        Invalid_File_Path,
        Invalid_File_Format,
        Invalid_File_Structure,
        Invalid_File,
        Invalid_Table,
        Invalid_Glyph_Index,
        Invalid_Character_Code,
        Invalid_Pixel_Size,
        Invalid_Library,
        Invalid_Face,
        Invalid_Library_or_Face,
        Atlas_Generation_Cancelled,
        Invalid_SharedTextureData,
        OpenTypeLayoutLookup_Mismatch,
    }
}
