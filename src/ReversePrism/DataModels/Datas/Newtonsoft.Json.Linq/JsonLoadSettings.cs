using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CommentHandling                          0001865E2260 ModelEnumType CommentHandling CommentHandling CommentHandling Int32
    // 014 LineInfoHandling                         00018652FB80 ModelEnumType LineInfoHandling LineInfoHandling LineInfoHandling Int32
    // 018 DuplicatePropertyNameHandling            00018670D4D0 ModelEnumType DuplicatePropertyNameHandling DuplicatePropertyNameHandling DuplicatePropertyNameHandling Int32
    public partial class JsonLoadSettings : DataModel
    {
        public CommentHandling                          CommentHandling                         { get; set; }
        public LineInfoHandling                         LineInfoHandling                        { get; set; }
        public DuplicatePropertyNameHandling            DuplicatePropertyNameHandling           { get; set; }

        public static JsonLoadSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonLoadSettings() { Pointer= p0 };

            value.CommentHandling                           = (CommentHandling)GetInt32(new IntPtr(p + 0x010)); // 024668841A80 0x10 CommentHandling             ( 0001865E2260 ModelEnumType CommentHandling CommentHandling CommentHandling Int32 )
            value.LineInfoHandling                          = (LineInfoHandling)GetInt32(new IntPtr(p + 0x014)); // 024668841AA0 0x14 LineInfoHandling            ( 00018652FB80 ModelEnumType LineInfoHandling LineInfoHandling LineInfoHandling Int32 )
            value.DuplicatePropertyNameHandling             = (DuplicatePropertyNameHandling)GetInt32(new IntPtr(p + 0x018)); // 024668841AC0 0x18 DuplicatePropertyNameHandling ( 00018670D4D0 ModelEnumType DuplicatePropertyNameHandling DuplicatePropertyNameHandling DuplicatePropertyNameHandling Int32 )

            return value;
        }
    }
}
