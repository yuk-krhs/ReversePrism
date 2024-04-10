using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FreeBindsCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 FreeFilesCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 FreeLoadersCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class FileOpenCondition : DataModel
    {
        public int                                      FreeBindsCount                          { get; set; }
        public int                                      FreeFilesCount                          { get; set; }
        public int                                      FreeLoadersCount                        { get; set; }

        public static FileOpenCondition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileOpenCondition() { Pointer= p0 };

            value.FreeBindsCount                            = GetInt32(new IntPtr(p + 0x010)); // 02466AC82DC8 0x10 FreeBindsCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FreeFilesCount                            = GetInt32(new IntPtr(p + 0x014)); // 02466AC82DE8 0x14 FreeFilesCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FreeLoadersCount                          = GetInt32(new IntPtr(p + 0x018)); // 02466AC82E08 0x18 FreeLoadersCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
